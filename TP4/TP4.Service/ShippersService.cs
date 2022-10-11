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
    public class ShippersService : IService<Shippers>
    {
        private ShippersLogic _shippersLogic;

        public ShippersLogic ShippersLogic
        {
            get
            {
                if (_shippersLogic == null)
                {
                    _shippersLogic = new ShippersLogic();
                }
                return _shippersLogic;
            }
        }

        public List<Shippers> GetAll()
        {
            try
            {
                return this.ShippersLogic.GetAll();
            }
            catch (Exception)
            {
                throw new Exception("No se pudo realizar la acción");
            }
        }

        public Shippers GetById(int id)
        {
            try
            {
                return this.ShippersLogic.GetOne(id);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo realizar la acción");
            }
        }

        public void Insert(Shippers shipper)
        {
            try
            {
                this.ShippersLogic.Add(shipper);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Shippers shipper)
        {
            try
            {
                this.ShippersLogic.Update(shipper);
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
                this.ShippersLogic.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
