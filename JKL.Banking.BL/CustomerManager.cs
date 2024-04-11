using JKL.Banking.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKL.Banking.BL
{
    public static class CustomerManager
    {
        public static List<Customer> Populate()
        {
            try
            {
                List<Customer> customers = new List<Customer>();

                Customer customer1 = new Customer();
                Customer customer2 = new Customer();
                Customer customer3 = new Customer();

                customer1.ID = 1;

                customer2.ID = 2;

                customer3.ID = 3;

                customers.Add(customer1);
                customers.Add(customer2);
                customers.Add(customer3);

                return customers;
            }
            catch(Exception ex)
            {
                throw;
            }

        }
    }
}
