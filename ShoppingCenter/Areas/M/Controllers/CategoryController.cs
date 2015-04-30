using ShoppingCenter.Areas.M.Models;
using ShoppingCenter.ProductManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCenter.Areas.M.Controllers
{
    public class CategoryController : Controller
    {
        ProductManageServiceClient client = new ProductManageServiceClient();

        // GET: M/Category
        public ActionResult Index()
        {
            return View();
        }

        // GET: M/Category/Create
        public async Task<ActionResult> Create()
        {
            var viewModel = new CategoryViewModel();
            var CategoryList = await client.GetAllCategoryAsync();
            viewModel.Categories = new SelectList(CategoryList, "CategoryId", "CategoryName");
            return View(viewModel);
        }

        // POST: M/Category/Create
        [HttpPost]
        public async Task<ActionResult> Create(FormCollection collection)
        {
            try
            {
                Category category = new Category()
                {
                     CategoryName = collection.
                }
                var result = await client.AddCategoryAsync(

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

        // GET: M/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
