using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
	public class CustomerOperations
	{
		public void AddCustomer(Customer customer)
		{
			// Add customer to database

			var connection = new MongoDbConnection();

			var customerCollection = connection.GetCustomerCollection();

			var document = new BsonDocument
			{
				{ "CustomerName", customer.CustomerName },
				{ "CustomerSurname", customer.CustomerSurname },
				{ "CustomerCity", customer.CustomerCity },
				{ "CustomerBalance", customer.CustomerBalance },
				{ "CustomerShoppingCount", customer.CustomerShoppingCount }
			};

			customerCollection.InsertOne(document);

		}

		public List<Customer> GetCustomers()
		{
			var connection = new MongoDbConnection();

			var customerCollection = connection.GetCustomerCollection();

			var customers = customerCollection.Find(new BsonDocument()).ToList();

			List<Customer> customerList = new List<Customer>();

			foreach (var customer in customers)
			{
				customerList.Add(new Customer
				{
					CustomerId = customer["_id"].ToString(),
					CustomerName = customer["CustomerName"].ToString(),
					CustomerBalance = Convert.ToDecimal(customer["CustomerBalance"]),
					CustomerCity = customer["CustomerCity"].ToString(),
					CustomerShoppingCount = Convert.ToInt32(customer["CustomerShoppingCount"]),
					CustomerSurname = customer["CustomerSurname"].ToString()


				});
			}

			return customerList;
		}

		public void DeleteCustomer(string customerId)
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomerCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));

			customerCollection.DeleteOne(filter);
		}

		public void UpdateCustomer(Customer customer)
		{
			var connection = new MongoDbConnection();

			var customerCollection = connection.GetCustomerCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));

			var updatedValue = Builders<BsonDocument>.Update
				.Set("CustomerName", customer.CustomerName)
				.Set("CustomerSurname", customer.CustomerSurname)
				.Set("CustomerCity", customer.CustomerCity)
				.Set("CustomerBalance", customer.CustomerBalance)
				.Set("CustomerShoppingCount", customer.CustomerShoppingCount);

			customerCollection.UpdateOne(filter, updatedValue);
		}

		public Customer GetCustomerById(string id)
		{
			var connection = new MongoDbConnection();

			var customerCollection = connection.GetCustomerCollection();

			var filter = Builders<BsonDocument>.Filter.Eq(id, ObjectId.Parse(id));

			var result = customerCollection.Find(filter).FirstOrDefault();

			return new Customer 
			{
				CustomerBalance = Convert.ToDecimal(result["CustomerBalance"]),
				CustomerCity = result["CustomerCity"].ToString(),
				CustomerId = result["_id"].ToString(),
				CustomerName = result["CustomerName"].ToString(),
				CustomerShoppingCount = Convert.ToInt32(result["CustomerShoppingCount"]),
				CustomerSurname = result["CustomerSurname"].ToString()
			};
		}
	}
}
