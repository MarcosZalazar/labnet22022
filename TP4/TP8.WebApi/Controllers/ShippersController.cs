using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TP4.Entities;
using TP4.Service;
using TP8.WebApi.Models;
using TP8.WebApi.Models.ShippersDTOs;

namespace TP8.WebApi.Controllers
{
    public class ShippersController : ApiController
    {
        private ShippersService _shippersService;

        public ShippersService ShippersService
        {
            get
            {
                if (_shippersService == null)
                {
                    _shippersService = new ShippersService();
                }
                return _shippersService;
            }
        }

        //GET: api/Shippers
        public IHttpActionResult GetShippers()
        {
            try
            {
                var shippersList = this.ShippersService.GetAll();

                var shippersDto = shippersList.Select(s => new ShipperDTO()
                {
                    Id = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).ToList();

                return Ok(shippersDto);
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo obtener el listado de transportistas.Intente nuevamente"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
        }

        //GET: api/Shippers/{id}
        public IHttpActionResult GetShipper(int id)
        {
            try
            {
                var shipper = this.ShippersService.GetById(id);

                ShipperDTO shipperDto = new ShipperDTO()
                {
                    Id = shipper.ShipperID,
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone
                };

                return Ok(shipperDto);
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo obtener el transportista solicitado. Intente nuevamente"
                };
                return Content(HttpStatusCode.NotFound, apiError);
            }
        }

        //POST: api/Shippers
        public IHttpActionResult InsertCategory([FromBody] InsertShipperDTO shipperDTOToBeInserted)
        {
            try
            {
                Shippers shipper = new Shippers()
                {
                    CompanyName = shipperDTOToBeInserted.CompanyName,
                    Phone = shipperDTOToBeInserted.Phone
                };

                this.ShippersService.Insert(shipper);
                return Content(HttpStatusCode.Created, shipper);
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo agregar al transportista.Recuerde que el tamaño máximo " +
                    "del campo nombre de la compañía es de 40 letras y el del campo teléfono es de 24 caracteres. " +
                    "Intente nuevamente"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
        }

        //PUT: api/Shippers
        public IHttpActionResult Put([FromUri] int id, [FromBody] UpdateShipperDTO shipper)
        {
            try
            {
                var existingShipper = this.ShippersService.GetById(id);
                if (existingShipper != null)
                {
                    existingShipper.CompanyName = shipper.CompanyName;
                    existingShipper.Phone = shipper.Phone;

                    this.ShippersService.Update(existingShipper);
                    return Content(HttpStatusCode.OK, existingShipper);
                }
                else
                {
                    APIResponse apiError = new APIResponse()
                    {
                        ApiMessage = "Transportista inexistente"
                    };
                    return Content(HttpStatusCode.NotFound, apiError);
                }
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo modificar al transportista.Recuerde que el tamaño máximo " +
                    "del campo nombre de la compañía es de 40 letras y el del campo teléfono es de 24 caracteres." +
                    "Intente nuevamente"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
        }

        //DELETE: api/Shippers
        public IHttpActionResult Delete([FromUri] int id)
        {
            try
            {
                var shipperToBeDeleted = this.ShippersService.GetById(id);
                if (shipperToBeDeleted != null)
                {
                    this.ShippersService.Delete(id);
                    APIResponse apiResponse = new APIResponse()
                    {
                        ApiMessage = "Transportista borrado"
                    };
                    return Content(HttpStatusCode.OK, apiResponse);
                }
                else
                {
                    APIResponse apiError = new APIResponse()
                    {
                        ApiMessage = "Transportista inexistente"
                    };
                    return Content(HttpStatusCode.NotFound, apiError);
                }
            }
            catch (DbUpdateException)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se puede eliminar el registro ya que es usado en las órdenes de pagos." +
                                   "Para eliminar el registro, elimine primero las ordenes de pagos relacionadas"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo borrar al transportista. Intente nuevamente"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
        }
    }
}