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
	}
}
