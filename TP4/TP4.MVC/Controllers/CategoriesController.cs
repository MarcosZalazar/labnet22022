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

        public ActionResult InsertUpdate(int id=0)
        {
            try
            {
                if (id>0)
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
                else 
                {
                    return View();
                }

            }
            catch (Exception)
            {
                ErrorView error = new ErrorView()
                {
                    ErrorMessage = "No se pudo realizar la operación. Intente nuevamente"
                };
                return RedirectToAction("Index", "Error", error);
            }
        }

        [HttpPost]
        public ActionResult InsertUpdate(CategoriesView categoriesView, int id = 0)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (id >0 )
                    {
                        Categories categoryEntity = new Categories
                        {
                            CategoryID = categoriesView.Id,
                            CategoryName = categoriesView.CategoryName,
                            Description = categoriesView.Description
                        };

                        categoriesLogic.Update(categoryEntity);
                    }
                    else 
                    {
                        Categories categoryEntity = new Categories
                        {
                            CategoryName = categoriesView.CategoryName,
                            Description = categoriesView.Description
                        };

                        categoriesLogic.Add(categoryEntity);
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ErrorView error = new ErrorView()
                {
                    ErrorMessage = "No se pudo realizar la operación. Intente nuevamente"
                };
                return RedirectToAction("Index", "Error", error);
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
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                ErrorView error = new ErrorView()
                {
                    ErrorMessage = "No se puede eliminar el registro ya que es usado por la entidad 'Productos'." +
                                   "Para eliminar el registro, elimine primero los productos relacionados"
                };
                return RedirectToAction("Index", "Error",error);
            }
            catch (Exception)
            {
                ErrorView error = new ErrorView()
                {
                    ErrorMessage = "No se pudo eliminar la categóría. Intente nuevamente"
                };
                return RedirectToAction("Index", "Error",error);
            }
        }

        public ActionResult Details(int id=0)
        {
            try
            {
                Categories category = this.categoriesLogic.GetOne(id);
                CategoriesView categoryView = new CategoriesView()
                {
                    Id = category.CategoryID,
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                };

                return View(categoryView);
            }
            catch (Exception)
            {
                ErrorView error = new ErrorView()
                {
                    ErrorMessage = "No se pudo mostrar los detalles. Intente nuevamente"
                };
                return RedirectToAction("Index", "Error", error);
            }
        }
    }
}