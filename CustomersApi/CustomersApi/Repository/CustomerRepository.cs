using CustomersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
namespace CustomersApi.Repository
{
	public class CustomerRepository : ICustomerRepository 
	{
		public IEnumerable<Customer> FindAll()
		{
			IList<Customer> customers = new List<Customer>();
			customers.Add(new Customer() { Name = "Nice customer", Address = "USA", Telephone = "123345456" });
			customers.Add(new Customer() { Name = "Good customer", Address = "UK", Telephone = "9878757654" });
			customers.Add(new Customer() { Name = "Awesome customer", Address = "France", Telephone = "34546456" });
            //Add new user
            customers.Add(new Customer() { Name = "Min Xie", Address = "USA", Telephone = "88888888" });
            customers.Add(new Customer() { Name = "Test User", Address = "USA", Telephone = "88888888" });

            //add another user
            customers.Add(new Customer() { Name = "Test User", Address = "USA", Telephone = "88888888" });
            return customers;
		}
	}
}