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
        //IQueryable<Customers> customers;

        public string ReturnACustomer() 
        {
            var customer= context.Customers.Find("CHOPS");
            string query = customer.ToString();

            return query;
        }

        public static void ReturnAllCustomersFromRegionWA()
        {

        }

        public static void ReturnAllCustomers()
        {

        }
        public static void ReturnAllCustomersFromWAWithOrderDateGreaterThanYear1997()
        {

        }

        public static void ReturnFirstThreeCustomersFromWA()
        {

        }
    }
}
