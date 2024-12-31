using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		CustomerOperations customerOperations = new CustomerOperations();

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var customer = new Entities.Customer
			{
				CustomerName = txtCustomerName.Text,
				CustomerSurname = txtCustomerSurname.Text,
				CustomerCity = txtCustomerCity.Text,
				CustomerBalance = decimal.Parse(txtBalance.Text),
				CustomerShoppingCount = Convert.ToInt32(txtTotalShopping.Text)
			};

			customerOperations.AddCustomer(customer);

			MessageBox.Show("Customer added successfully.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			List<Customer> customers = customerOperations.GetCustomers();

			dataGridView1.DataSource = customers;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string id = txtCustomerId.Text;

			customerOperations.DeleteCustomer(id);

			MessageBox.Show("Customer deleted successfully.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			 string id = txtCustomerId.Text;

			var customer = new Entities.Customer()
			{
				CustomerId = id,
				CustomerName = txtCustomerName.Text,
				CustomerCity = txtCustomerCity.Text,
				CustomerBalance = decimal.Parse(txtBalance.Text),
				CustomerSurname = txtCustomerSurname.Text,
				CustomerShoppingCount = Convert.ToInt32(txtTotalShopping.Text)
			};

			customerOperations.UpdateCustomer(customer);

			MessageBox.Show("Customer updated successfully.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			string id = txtCustomerId.Text;

			Customer customer = customerOperations.GetCustomerById(id);

			dataGridView1.DataSource = new List<Customer> {customer};
		}
	}
}
