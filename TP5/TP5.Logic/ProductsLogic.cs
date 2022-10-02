using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Logic
{
    public class ProductsLogic : BaseLogic<Products>
    {
        public string ReturnAnOutOfStockList()
        {
            StringBuilder message = new StringBuilder();
            var query = context.Products.Where(p => p.UnitsInStock == 0).Select(p => p);

            foreach (var item in query)
            {
                message.AppendLine($"Id de producto: {item.ProductID}");
                message.AppendLine($"Nombre del producto: {item.ProductName}");
                message.AppendLine($"Unidades en stock: {item.UnitsInStock}{Environment.NewLine}");
            }

            return message.ToString();
        }

        public string ReturnAStockListWithPricesAbove3Dollars()
        {
            StringBuilder message = new StringBuilder();
            var query = context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice>3).Select(p => p);

            foreach (var item in query)
            {
                message.AppendLine($"Id de producto: {item.ProductID}");
                message.AppendLine($"Nombre del producto: {item.ProductName}");
                message.AppendLine($"Unidades en stock: {item.UnitsInStock}{Environment.NewLine}");
            }

            return message.ToString();
        }

        public string ReturnFirstItemOrNullWithId789()
        {
            StringBuilder message = new StringBuilder();
            var item = context.Products.Where(p => p.ProductID == 789).FirstOrDefault();
            if (item != null)
            {
                message.AppendLine($"Id de producto: {item.ProductID}");
                message.AppendLine($"Nombre del producto: {item.ProductName}");
            }
            else
            {
                message.AppendLine($"Ningún elemento cumple con el criterio de búsqueda");
            }

            return message.ToString();
        }

        public string ReturnProductsListOrderedByName()
        {
            StringBuilder message = new StringBuilder();

            var query = from product in context.Products
                        orderby product.ProductName ascending
                        select new 
                        { 
                           product.ProductName,
                           product.ProductID,
                        };

            foreach (var item in query)
            {
                message.AppendLine($"Nombre del producto: {item.ProductName}");
                message.AppendLine($"Id del producto: {item.ProductID}{Environment.NewLine}");
            }

            return message.ToString();
        }

        public string ReturnProductsListOrderedByUnitsInStockDesc()
        {
            StringBuilder message = new StringBuilder();

            var query = from product in context.Products
                        orderby product.UnitsInStock descending
                        select new
                        {
                            product.ProductName,
                            product.ProductID,
                            product.UnitsInStock,
                        };

            foreach (var item in query)
            {
                message.AppendLine($"Id del producto: {item.ProductID}");
                message.AppendLine($"Nombre del producto: {item.ProductName}");
                message.AppendLine($"Unidades en stock: {item.UnitsInStock}{Environment.NewLine}");
            }

            return message.ToString();
        }

        public string ReturnProductsCategories()
        {
            StringBuilder message = new StringBuilder();

            var query = from product in context.Products
                        join category in context.Categories
                        on product.CategoryID equals category.CategoryID into joined
                        from j in joined.DefaultIfEmpty()
                        select new
                        {
                            product.ProductID,
                            product.ProductName,
                            product.CategoryID,
                            j.CategoryName
                        };

            foreach (var item in query)
            {
                message.AppendLine($"Id del producto: {item.ProductID}");
                message.AppendLine($"Nombre del producto: {item.ProductName}");
                message.AppendLine($"Id de la categoría: {item.CategoryID}");
                message.AppendLine($"Nombre de la categoría: {item.CategoryName}{Environment.NewLine}");
            }

            return message.ToString();
        }

        public string ReturnFirstProductFromAProductsList()
        {
            StringBuilder message = new StringBuilder();
            var item = context.Products.First();
            if (item != null)
            {
                message.AppendLine($"Id de producto: {item.ProductID}");
                message.AppendLine($"Nombre del producto: {item.ProductName}");
                message.AppendLine($"Precio unitario: {item.UnitPrice}");
                message.AppendLine($"Unidades en stock: {item.UnitsInStock}");
            }
            else
            {
                message.AppendLine($"Ningún elemento cumple con el criterio de búsqueda");
            }

            return message.ToString();
        }
    }
}
