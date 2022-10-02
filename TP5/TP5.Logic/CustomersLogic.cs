using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entities;

namespace TP5.Logic
{
    public class CustomersLogic : BaseLogic<Customers>
    {
        public string ReturnACustomer() 
        {
            var customer= context.Customers.Find("CHOPS");
            string query = customer.ToString();

            return query;
        }

        public string ReturnAllCustomersFromRegionWA()
        {
            StringBuilder message = new StringBuilder();
            var query = context.Customers.Where(p => p.Region=="WA").Select(p => p);

            foreach (var item in query)
            {
                message.AppendLine($"Id del cliente: {item.CustomerID}");
                message.AppendLine($"Nombre del cliente: {item.CompanyName}");
                message.AppendLine($"Región: {item.Region}{Environment.NewLine}");
            }

            return message.ToString();
        }

        public string ReturnAllCustomers()
        {
            StringBuilder message = new StringBuilder();
            var query = context.Customers.ToList();

            foreach (var item in query)
            {
                message.AppendLine($"Cliente en minúscula: {item.CompanyName.ToLower()}.");
                message.AppendLine($"Cliente en mayúscula: {item.CompanyName.ToUpper()}{Environment.NewLine}"); 
            }
            return message.ToString();
        }

        public string ReturnAllCustomersFromWAWithOrderDateGreaterThanYear1997()
        {
            StringBuilder message = new StringBuilder();
            DateTime orderDateLimit= new DateTime(1997, 01, 01);

            var query = from customer in context.Customers
                         join orders in context.Orders
                         on customer.CustomerID equals orders.CustomerID
                         where customer.Region== "WA" && orders.OrderDate > orderDateLimit
                         select new
                         {
                             customer.CustomerID,
                             customer.CompanyName,
                             customer.Region,
                             orders.OrderDate
                         };

            foreach (var item in query)
            {
                message.AppendLine($"Id del cliente: {item.CustomerID}");
                message.AppendLine($"Nombre del cliente: {item.CompanyName}");
                message.AppendLine($"Región del cliente: {item.Region}");
                message.AppendLine($"Fecha de orden: {item.OrderDate}{Environment.NewLine}");
            }

            return message.ToString();
        }

        public string ReturnFirstThreeCustomersFromWA()
        {
            StringBuilder message = new StringBuilder();
            var query = context.Customers.Where(c=>c.Region == "WA").Take(3);

            foreach (var item in query)
            {
                message.AppendLine($"Id del cliente: {item.CustomerID}");
                message.AppendLine($"Nombre del cliente: {item.CompanyName}");
                message.AppendLine($"Región del cliente: {item.Region}{Environment.NewLine}");
            }

            return message.ToString();
        }
        public string ReturnNumberOfOrdersPerCustomer()
        {
            StringBuilder message = new StringBuilder();

            var query = from customer in context.Customers
                        join order in context.Orders
                        on customer.CustomerID equals order.CustomerID into joined
                        from j in joined.DefaultIfEmpty()
                        group j by customer.CustomerID into grouped
                        select new
                        {
                            CustomerID = grouped.Key,
                            Count = grouped.Count(j => j.CustomerID != null)
                        };

            foreach (var item in query)
            {
                message.AppendLine($"Id del cliente: {item.CustomerID}");
                string companyName= context.Customers.Where(c => c.CustomerID == item.CustomerID).First().CompanyName;
                message.AppendLine($"Nombre del cliente: {companyName}");
                message.AppendLine($"Cantidad de órdenes: {item.Count}{Environment.NewLine}");
            }

            return message.ToString();
        }
    }
}
