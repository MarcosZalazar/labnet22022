using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Data;

namespace TP5.Logic
{
    public abstract class BaseLogic<T> 
    {
        protected readonly NorthwindContext context;
        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
