﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SMAUG.Models;

namespace SMAUG.Controllers
{
    public class PublicationsController : Controller
    {
        private SMAUGEntities db = new SMAUGEntities();

        // GET: Publications
        public ActionResult Index()
        {
            var publication = db.Publication.Include(p => p.Person);
            return View(publication.ToList());
        }

        // GET: Publications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publication publication = db.Publication.Find(id);
            if (publication == null)
            {
                return HttpNotFound();
            }
            return View(publication);
        }

        // GET: Publications/Create
        public ActionResult Create()
        {
            ViewBag.Pub_Author = new SelectList(db.Person, "Per_Id", "Per_LastName");
            return View();
        }

        // POST: Publications/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Pub_Id,Pub_Title,Pub_Date,Pub_SeriesTitle,Pub_Volume,Pub_Author")] Publication publication)
        {
            if (ModelState.IsValid)
            {
                db.Publication.Add(publication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Pub_Author = new SelectList(db.Person, "Per_Id", "Per_LastName", publication.Pub_Author);
            return View(publication);
        }

        // GET: Publications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publication publication = db.Publication.Find(id);
            if (publication == null)
            {
                return HttpNotFound();
            }
            ViewBag.Pub_Author = new SelectList(db.Person, "Per_Id", "Per_LastName", publication.Pub_Author);
            return View(publication);
        }

        // POST: Publications/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Pub_Id,Pub_Title,Pub_Date,Pub_SeriesTitle,Pub_Volume,Pub_Author")] Publication publication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Pub_Author = new SelectList(db.Person, "Per_Id", "Per_LastName", publication.Pub_Author);
            return View(publication);
        }

        // GET: Publications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publication publication = db.Publication.Find(id);
            if (publication == null)
            {
                return HttpNotFound();
            }
            return View(publication);
        }

        // POST: Publications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Publication publication = db.Publication.Find(id);
            db.Publication.Remove(publication);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
