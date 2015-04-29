using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCenter.Areas.M.Controllers
{
    public class CategoryController : Controller
    {
        // GET: M/Category
        public ActionResult Index()
        {
            return View();
        }

        // GET: M/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: M/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: M/Category/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: M/Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: M/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: M/Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: M/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
