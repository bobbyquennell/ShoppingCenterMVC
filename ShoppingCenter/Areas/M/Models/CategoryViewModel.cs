using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCenter.Areas.M.Models
{
    public class CategoryViewModel
    {
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Choose Parent Category")]
        public int ParentCategoryId { get; set; }

        public SelectList Categories { get; set; }
    }
}