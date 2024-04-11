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
                // Initialize customer list
                List<Customer> customers = new List<Customer>();

                // Initialize 3 fake customers
                Customer customer1 = new Customer();
                Customer customer2 = new Customer();
                Customer customer3 = new Customer();

                // Create IDs for customers
                customer1.ID = 1;
                customer2.ID = 2;
                customer3.ID = 3;

                // Populate deposit data for customers
                customer1.Deposits = DepositManager.Populate(customer1.ID);
                customer2.Deposits = DepositManager.Populate(customer2.ID);
                customer3.Deposits = DepositManager.Populate(customer3.ID);

                // Populate withdrawal data for customers
                customer1.Withdrawals = WithdrawalManager.Populate(customer1.ID);
                customer2.Withdrawals = WithdrawalManager.Populate(customer2.ID);
                customer3.Withdrawals = WithdrawalManager.Populate(customer3.ID);

                // Add customers to list
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
