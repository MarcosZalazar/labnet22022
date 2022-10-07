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
                if (ModelState.IsValid) 
                {
                    Categories categoryEntity = new Categories
                    {
                        CategoryName = categoriesView.CategoryName,
                        Description = categoriesView.Description
                    };

                    categoriesLogic.Add(categoryEntity);
                    return RedirectToAction("Index");

                }
                return View(categoriesView);
            }
            catch (Exception) 
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Update(int id)
        {
            try
            {
                CategoriesLogic categoriesLogic = new CategoriesLogic();
                var categoryEntity = categoriesLogic.GetOne(id);
                CategoriesView categoriesViews = new CategoriesView()
                {
                    Id = categoryEntity.CategoryID, 
                    CategoryName = categoryEntity.CategoryName,
                    Description = categoryEntity.Description,
                };

                return View(categoriesViews);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [HttpPost]
        public ActionResult Update(CategoriesView categoriesView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Categories categoryEntity = new Categories
                    {
                        CategoryID = categoriesView.Id,
                        CategoryName = categoriesView.CategoryName,
                        Description = categoriesView.Description
                    };
 
                    categoriesLogic.Update(categoryEntity);
                }
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
                if (ModelState.IsValid)
                {
                    categoriesLogic.Delete(id);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

    }
}