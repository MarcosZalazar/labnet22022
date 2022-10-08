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
    public class ShippersController : Controller
    {
        ShippersLogic shippersLogic = new ShippersLogic();

        // GET: Shippers
        public ActionResult Index()
        {
            var shippersLogic = new ShippersLogic();
            List<Shippers> listOfShippers = shippersLogic.GetAll();

            List<ShippersView> shippersViews = listOfShippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone,
            }).ToList();

            return View(shippersViews);
        }

        public ActionResult InsertUpdate(int id = 0)
        {
            try
            {
                if (id > 0)
                {
                    ShippersLogic shippersLogic = new ShippersLogic();
                    var shippersEntity = shippersLogic.GetOne(id);
                    ShippersView shippersViews = new ShippersView()
                    {
                        Id = shippersEntity.ShipperID,
                        CompanyName = shippersEntity.CompanyName,
                        Phone = shippersEntity.Phone,
                    };

                    return View(shippersViews);
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
        public ActionResult InsertUpdate(ShippersView shippersView, int id = 0)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (id > 0)
                    {
                        Shippers shipperEntity = new Shippers
                        {
                            ShipperID = shippersView.Id,
                            CompanyName = shippersView.CompanyName,
                            Phone = shippersView.Phone
                        };

                        shippersLogic.Update(shipperEntity);
                    }
                    else
                    {
                        Shippers shipperEntity = new Shippers
                        {
                            CompanyName = shippersView.CompanyName,
                            Phone = shippersView.Phone
                        };

                        shippersLogic.Add(shipperEntity);
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
                    shippersLogic.Delete(id);
                }
                return RedirectToAction("Index");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                ErrorView error = new ErrorView()
                {
                    ErrorMessage = "No se puede eliminar el registro ya que es usado por las órdenes de pagos." +
                                   "Para eliminar el registro, elimine primero las órdenes de pagos relacionadas"
                };
                return RedirectToAction("Index", "Error", error);
            }
            catch (Exception)
            {
                ErrorView error = new ErrorView()
                {
                    ErrorMessage = "No se pudo eliminar el registro. Intente nuevamente"
                };
                return RedirectToAction("Index", "Error", error);
            }
        }

        public ActionResult Details(int id = 0)
        {
            try
            {
                Shippers shipper = this.shippersLogic.GetOne(id);
                ShippersView shipperView = new ShippersView()
                {
                    Id = shipper.ShipperID,
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone,
                };

                return View(shipperView);
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