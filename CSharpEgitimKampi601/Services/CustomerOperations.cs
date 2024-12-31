using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
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


	}
}
