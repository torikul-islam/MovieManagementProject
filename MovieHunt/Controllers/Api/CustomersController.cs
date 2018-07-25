using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Description;
using MovieHunt.Models;

namespace MovieHunt.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Customers
        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }

        // GET: api/Customers/5
        public Customer GetCustomer(int id)
        {
            var customer =  db.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return customer;
        }
        // POST: api/Customers
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            db.Customers.Add(customer);
            db.SaveChangesAsync();

            return customer;
        }
        // PUT: api/Customers/1
        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDb =db.Customers.SingleOrDefault(c => c.Id == id);
            if(customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            customerInDb.Name = customer.Name;
            customerInDb.BirthDate = customer.BirthDate;
            customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;
            db.SaveChanges();

        }



        // DELETE: api/Customers/5
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = db.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
            {

                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            db.Customers.Remove(customerInDb);
            db.SaveChangesAsync();

        }

        protected override void Dispose(bool disposing)
        {
           db.Dispose();
        }

        private bool CustomerExists(int id)
        {
            return db.Customers.Count(e => e.Id == id) > 0;
        }
    }
}