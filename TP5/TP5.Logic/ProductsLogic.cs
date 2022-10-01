using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Logic
{
    public class ProductsLogic : BaseLogic<Customers>
    {
        //IQueryable<Products> products;

        public string ReturnAnOutOfStockList()
        {
            StringBuilder message = new StringBuilder();
            var query = context.Products.Where(p => p.UnitsInStock == 0).Select(p => p);

            foreach (var item in query)
            {
                message.AppendLine($"Id de producto: {item.ProductID}");
                message.AppendLine($"Id de producto: {item.ProductName}");
                message.AppendLine($"Id de producto: {item.UnitsInStock}{Environment.NewLine}");
            }

            return message.ToString();
        }

        public string ReturnAStockListWithPricesAbove3Dolars()
        {
            StringBuilder message = new StringBuilder();
            var query = context.Products.Where(p => p.UnitsInStock == 0).Select(p => p);

            foreach (var item in query)
            {
                message.AppendLine($"Id de producto: {item.ProductID}");
                message.AppendLine($"Id de producto: {item.ProductName}");
                message.AppendLine($"Id de producto: {item.UnitsInStock}{Environment.NewLine}");
            }

            return message.ToString();
        }

        public static void ReturnFirstItemOrNullWithId789()
        {

        }
        public static void ReturnProductsListOrderedByName()
        {

        }

        public static void ReturnProductsListOrderedByUnitsInStockDesc()
        {

        }

        public static void ReturnProductsCategories()
        {

        }

        public static void ReturnFirstProductFromAProductsList()
        {

        }
    }
}
