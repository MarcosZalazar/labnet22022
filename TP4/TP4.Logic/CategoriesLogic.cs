using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;

namespace TP4.Logic
{
    public class CategoriesLogic : BaseLogic<Categories>
    {
        public override Categories GetOne(int id)
        {
            return context.Categories.Find(id);
        }

        public override List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public override void Add(Categories newCategory)
        {
            try
            {
                context.Categories.Add(newCategory);
                context.SaveChanges();
            }
            catch (Exception ex) 
            {
                RollBackChanges();
                throw ex;
            }
        }

        public override void Delete(int id)
        {
            try
            {
                var categoryToDelete = context.Categories.Find(id);
                context.Categories.Remove(categoryToDelete);
                context.SaveChanges();
            }
            catch (Exception ex) 
            {
                RollBackChanges();
                throw ex;
            }   
        }

        public override void Update(Categories existingCategory)
        {
            try
            {
                var categoryToUpdate = this.GetOne(existingCategory.CategoryID);
                categoryToUpdate.CategoryName = existingCategory.CategoryName;
                categoryToUpdate.Description = existingCategory.Description;

                context.SaveChanges();

            }
            catch (Exception ex)
            {
                RollBackChanges();
                throw ex;
            }
        }
    }
}
