using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Data;

namespace TP5.Logic
{
    public abstract class BaseLogic<T> : ILogic<T>
    {
        protected readonly NorthwindContext context;

        public abstract T GetOne(int id);

        public abstract List<T> GetAll();

        public abstract void Add(T newObject);

        public abstract void Delete(int id);

        public abstract void Update(T existingObject);

        public void RollBackChanges()
        {
            var changedEntries = context.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }
    }
}
