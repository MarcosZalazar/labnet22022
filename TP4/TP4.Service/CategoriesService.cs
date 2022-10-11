using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;
using TP4.Service.Interfaces;

namespace TP4.Service
{
    public class CategoriesService : IService<Categories>
    {
        private CategoriesLogic _categoriesLogic;

        public CategoriesLogic CategoriesLogic
        {
            get 
            {
                if (_categoriesLogic == null)
                {
                    _categoriesLogic = new CategoriesLogic();
                }
                return _categoriesLogic;
            }
        }

        public List<Categories> GetAll()
        {
            try
            {
                return this.CategoriesLogic.GetAll();
            }
            catch (Exception)
            {
                throw new Exception("No se pudo realizar la acción");
            }
        }

        public Categories GetById(int id)
        {
            try
            {
                return this.CategoriesLogic.GetOne(id);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo realizar la acción");
            }
        }

        public void Insert(Categories category)
        {
            try
            {
                this.CategoriesLogic.Add(category); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Categories category)
        {
            try
            {
                this.CategoriesLogic.Update(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(int id)
        {
            try
            {
                this.CategoriesLogic.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
