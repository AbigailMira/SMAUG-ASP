using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SMAUG.Dto;
using SMAUG.Models;
using SMAUG.Models.ViewModels;

namespace SMAUG.Controllers
{
    public class ItemsController : Controller
    {
        private SMAUGEntities db = new SMAUGEntities();

        // GET: Item List
        public ActionResult Index()
        {
            ItemListViewModel vm = new ItemListViewModel();

            vm.Items = GetItems().ToList<DtoItem>();

            return View(vm);
        }

        // GET: DtoItems
        public IQueryable<DtoItem> GetItems()
        {
            var items = from i in db.Item
                        select new DtoItem()
                        {
                            Ite_Id = i.Ite_Id,
                            Ite_Name = i.Ite_Name,
                            Ite_Type = i.Ite_Type,
                            Ite_Collection = i.Ite_Collection,
                            Ite_Edition = i.Ite_Edition,
                            Ite_Editor = i.Ite_Editor,
                            Ite_ISBN = i.Ite_ISBN,
                            Ite_ProdDate = i.Ite_ProdDate,
                            Makers = (from m in i.Maker
                                      select new DtoPerson()
                                      {
                                          Per_FirstName = m.Per_FirstName,
                                          Per_LastName = m.Per_LastName
                                      }).ToList()
                        };

            return items;
        }

        // GET: Items/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ItemDetailViewModel vm = new ItemDetailViewModel();

            DtoItem item = (from i in db.Item
                         where i.Ite_Id == id
                        select new DtoItem()
                        {
                            Ite_Id = i.Ite_Id,
                            Ite_Name = i.Ite_Name,
                            Ite_Type = i.Ite_Type,
                            Ite_Collection = i.Ite_Collection,
                            Ite_Edition = i.Ite_Edition,
                            Ite_Editor = i.Ite_Editor,
                            Ite_ISBN = i.Ite_ISBN,
                            Ite_ProdDate = i.Ite_ProdDate,
                            Makers = (from m in i.Maker
                                      select new DtoPerson()
                                      {
                                          Per_FirstName = m.Per_FirstName,
                                          Per_LastName = m.Per_LastName
                                      }).ToList()
                        }).Single();

            if (item == null)
            {
                return HttpNotFound();
            }
            vm.item = item;

            return View(vm);
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ite_Id,Ite_Type,Ite_Name,Ite_Collection,Ite_Edition,Ite_Editor,Ite_ISBN,Ite_ProdDate")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Item.Add(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: Items/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Item.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ite_Id,Ite_Type,Ite_Name,Ite_Collection,Ite_Edition,Ite_Editor,Ite_ISBN,Ite_ProdDate")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: Items/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Item.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Item.Find(id);
            db.Item.Remove(item);
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
