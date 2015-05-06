using ShoppingCenter.Areas.M.Models;
using ShoppingCenter.CategoryService;
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
        CategoryServiceClient client = new CategoryServiceClient();

        private async Task<SelectList> GetCategoryListAsync()
        {
            var CategoryList = await client.GetAllCategoryAsync();
            return new SelectList(CategoryList);
        }
        
        // GET: M/Category
        public ActionResult Index()
        {
            return View();
        }

        // GET: M/Category/Create
        public async Task<ActionResult> Create()
        {
            var viewModel = new CategoryViewModel();
            viewModel.Categories = await GetCategoryListAsync();
            return View(viewModel);
        }

        // POST: M/Category/Create
        [HttpPost]
        public async Task<ActionResult> Create(FormCollection collection)
        {
            try
            {
                string categoryName = collection["CategoryName"];
                int parentCategoryId = Int32.Parse(collection["ParentCategoryId"]);
                var result = await client.AddCategoryAsync(categoryName, parentCategoryId);

                if(result.Success)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(collection);
                }

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
