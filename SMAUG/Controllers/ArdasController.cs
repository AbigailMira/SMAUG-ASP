﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SMAUG.Dto;
using SMAUG.Models;
using static SMAUG.Models.ViewModels.ArdaViewModels;

namespace SMAUG.Controllers
{
    public class ArdasController : Controller
    {
        private SMAUGEntities db = new SMAUGEntities();

        // GET: Arda
        public ActionResult Index()
        {
            ArdaListViewModel vm = new ArdaListViewModel();

            vm.Ardas = GetArdas().ToList<DtoArda>();

            return View(vm);
        }
        
        // GET: DtoArda
        public IQueryable<DtoArda> GetArdas()
        {
            var ardas = from a in db.Arda
                          select new DtoArda()
                          {
                              Ard_Id = a.Ard_Id,
                              Ard_Type = a.Ard_Type,
                              Ard_Name = a.Ard_Name,
                              Ard_Race = a.Ard_Race,
                              Ard_People = a.Ard_People,
                              Ard_Gender = a.Ard_Gender,
                              Ard_FirstAppearance = a.Ard_FirstAppearance
                          };
            return ardas;
        }
        // GET: Arda/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arda arda = db.Arda.Find(id);
            if (arda == null)
            {
                return HttpNotFound();
            }
            return View(arda);
        }

        // GET: Arda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arda/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ard_Id,Ard_Name,Ard_Type,Ard_Race,Ard_People,Ard_FirstAppearance")] Arda arda)
        {
            if (ModelState.IsValid)
            {
                db.Arda.Add(arda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arda);
        }

        // GET: Arda/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arda arda = db.Arda.Find(id);
            if (arda == null)
            {
                return HttpNotFound();
            }
            return View(arda);
        }

        // POST: Arda/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ard_Id,Ard_Name,Ard_Type,Ard_Race,Ard_People,Ard_FirstAppearance")] Arda arda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arda);
        }

        // GET: Arda/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arda arda = db.Arda.Find(id);
            if (arda == null)
            {
                return HttpNotFound();
            }
            return View(arda);
        }

        // POST: Arda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arda arda = db.Arda.Find(id);
            db.Arda.Remove(arda);
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
