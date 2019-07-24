using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationEntityFramework
{
    static class CustomerDB
    {
        /// <summary>
        /// Returns all customers from the database
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetCustomers()
        {
            //Create instance of DB context 
            //(what is talking to your database)
            var db = new BookRegistrationEntities();

            //Use linq (language integrated query) to query database

            //LINQ Query syntax
            //List<Customer> customers = (from c in db.Customer
            //                           select c).ToList();

            //LINQ method syntax - Same as above
            List<Customer> customers = db.Customer.ToList();

            return customers;
        }

        /// <summary>
        /// Adds a customer. Returns the newly added customer with the CustomerID populated.
        /// </summary>
        /// <param name="c">The new customer</param>
        /// <returns></returns>
        public static Customer AddCustomer(Customer c)
        {
            using(var context = new BookRegistrationEntities())
            {
                context.Customer.Add(c);
                return c;
            }
        }
    }
}
