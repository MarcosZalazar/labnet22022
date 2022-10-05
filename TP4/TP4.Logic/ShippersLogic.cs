using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Data;
using TP4.Entities;

namespace TP4.Logic
{
    public class ShippersLogic : BaseLogic<Shippers>
    {
        public ShippersLogic( )
        {

        }

        public ShippersLogic(NorthwindContext contextMoq) :base(contextMoq)
        {
            
        }

        public override Shippers GetOne(int id)
        {
            return context.Shippers.Find(id);
        }

        public override List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public override void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }

        public override void Delete(int id)
        {
            try
            {
                var shipperToDelete = context.Shippers.Find(id);
                context.Shippers.Remove(shipperToDelete);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex) 
            {
                RollBackChanges();
                throw ex;
            }
        }

        public override void Update(Shippers existingShipper)
        {
            var shipperToUpdate = this.GetOne(existingShipper.ShipperID);
            shipperToUpdate.CompanyName = existingShipper.CompanyName;
            shipperToUpdate.Phone = existingShipper.Phone;
            context.SaveChanges();
        }
    }
}
