using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using TP4.Entities;
using TP4.Service;
using TP8.WebApi.Models;
using TP8.WebApi.Models.CategoriesDTOs;

namespace TP8.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        private CategoriesService _categoriesService;

        public CategoriesService CategoriesService
        {
            get
            {
                if (_categoriesService == null)
                {
                    _categoriesService = new CategoriesService();
                }
                return _categoriesService;
            }
        }

        //GET: api/Categories
        public IHttpActionResult GetCategories()
        {
            try
            {
                var categoriesList = this.CategoriesService.GetAll();

                var categoriesDto = categoriesList.Select(s => new CategoryDTO()
                {
                    Id = s.CategoryID,
                    CategoryName = s.CategoryName,
                    Description = s.Description
                }).ToList();

                return Ok(categoriesDto);
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo obtener el listado de categorías.Intente nuevamente"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
        }

        //GET: api/Categories/{id}
        public IHttpActionResult GetCategory(int id)
        {
            try
            {
                var category = this.CategoriesService.GetById(id);

                CategoryDTO categoryDto = new CategoryDTO()
                {
                    Id = category.CategoryID,
                    CategoryName = category.CategoryName,
                    Description = category.Description
                };

                return Ok(categoryDto);
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo obtener la categoría solicitada. Intente nuevamente"
                };
                return Content(HttpStatusCode.NotFound, apiError);
            }
        }

        //POST: api/Categories
        public IHttpActionResult InsertCategory([FromBody] InsertCategoryDTO categoryDTOToBeInserted)
        {
            try
            {
                Categories category = new Categories()
                {
                    CategoryName = categoryDTOToBeInserted.CategoryName,
                    Description = categoryDTOToBeInserted.Description
                };

                this.CategoriesService.Insert(category);
                return Content(HttpStatusCode.Created, category);
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo agregar la categoría.Recuerde que el tamaño máximo " +
                    "del campo categorías es de 15 letras y el del campo Descripción es de 50 letras. " +
                    "Intente nuevamente"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
        }

        //PUT: api/Categories
        public IHttpActionResult Put([FromUri]int id, [FromBody] UpdateCategoryDTO category)
        {
            try
            {
                var existingCategory = this.CategoriesService.GetById(id);
                if (existingCategory != null)
                {
                    existingCategory.CategoryName = category.CategoryName;
                    existingCategory.Description = category.Description;

                    this.CategoriesService.Update(existingCategory);
                    return Content(HttpStatusCode.OK, existingCategory);
                }
                else 
                {
                    APIResponse apiError = new APIResponse()
                    {
                        ApiMessage = "Categoria inexistente"
                    };
                    return Content(HttpStatusCode.NotFound, apiError);
                }
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo modificar la categoría.Recuerde que el tamaño máximo " +
                    "del campo categorías es de 15 letras y el del campo Descripción es de 50 letras. " +
                    "Intente nuevamente"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
        }

        //DELETE: api/Categories
        public IHttpActionResult Delete([FromUri] int id)
        {
            try
            {
                var categoryToBeDeleted = this.CategoriesService.GetById(id);
                if (categoryToBeDeleted != null)
                {
                    this.CategoriesService.Delete(id);
                    APIResponse apiResponse = new APIResponse()
                    {
                        ApiMessage = "Categoria borrada"
                    };
                    return Content(HttpStatusCode.OK, apiResponse);
                }
                else
                {
                    APIResponse apiError = new APIResponse()
                    {
                        ApiMessage = "Categoria inexistente"
                    };
                    return Content(HttpStatusCode.NotFound, apiError);
                }
            }
            catch (DbUpdateException) 
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se puede eliminar el registro ya que es usado por la entidad 'Productos'." +
                                   "Para eliminar el registro, elimine primero los productos relacionados"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
            catch (Exception)
            {
                APIResponse apiError = new APIResponse()
                {
                    ApiMessage = "No se pudo borrar la categoría. Intente nuevamente"
                };
                return Content(HttpStatusCode.BadRequest, apiError);
            }
        }
    }
}