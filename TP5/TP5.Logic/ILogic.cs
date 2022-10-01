using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Logic
{
    public interface ILogic<T>
    {
        T GetOne(int id);
        List<T> GetAll();
        void Add(T newObject);
        void Delete(int id);
        void Update(T existingObject);
        void RollBackChanges();
    }
}
