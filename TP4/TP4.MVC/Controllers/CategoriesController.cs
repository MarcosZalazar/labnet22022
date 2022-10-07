using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4.Entities;
using TP4.Logic;
using TP4.MVC.Models;

namespace TP4.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();

        // GET: Categories
        public ActionResult Index()
        {
            var categoriesLogic = new CategoriesLogic();
            List<Categories> listOfCategories = categoriesLogic.GetAll();

            List<CategoriesView> categoriesViews = listOfCategories.Select(s => new CategoriesView
            {
                Id = s.CategoryID,
                CategoryName = s.CategoryName,
                Description = s.Description,
            }).ToList();    

            return View(categoriesViews);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesView categoriesView)
        {
            try
            {
                Categories categoryEntity = new Categories
                {
                    CategoryName = categoriesView.CategoryName,
                    Description = categoriesView.Description
                };

                categoriesLogic.Add(categoryEntity);
                return RedirectToAction("Index");
            }
            catch (Exception) 
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            try 
            {
                categoriesLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

    }
}