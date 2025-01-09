using Npgsql;
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
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}

		string connectionString = "Server=localhost;port=5432;Database=Customer;userId=postgres;Password=09Haz1992.";
		void getAllCustomers()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * from Customers";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command); // is used to execute the command and fill a DataTable with the results.
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		void getById(int id)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * from Customers where CustomerId=@customerId";
			var command = new NpgsqlCommand(query, connection);

			command.Parameters.AddWithValue("customerId", id);

			var adapter = new NpgsqlDataAdapter(command); // is used to execute the command and fill a DataTable with the results.
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			getAllCustomers();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string customerName = txtCustomerName.Text;
			string customerCity = txtCustomerCity.Text;
			string customerSurname = txtCustomerSurname.Text;

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "insert into Customers (CustomerName, CustomerSurname, CustomerCity) values (@customerName, @customerSurname, @customerCity)";

			var command = new NpgsqlCommand(query,connection);

			command.Parameters.AddWithValue("@customerName", customerName);
			command.Parameters.AddWithValue("@customerSurname", customerSurname);
			command.Parameters.AddWithValue("@customerCity", customerCity);

			command.ExecuteNonQuery();

			MessageBox.Show("Ekleme işlemi başarılı!");

			connection.Close();

			getAllCustomers();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCustomerId.Text);

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "delete from Customers where CustomerId = @customerId";

			var command = new NpgsqlCommand(query,connection);

			command.Parameters.AddWithValue("customerId", id);

			command.ExecuteNonQuery();

			MessageBox.Show("Silme İşlemi Başarılı");

			connection.Close();

			getAllCustomers();

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string customerName = txtCustomerName.Text;
			string customerSurname = txtCustomerSurname.Text;
			string customerCity = txtCustomerCity.Text;

			int id = int.Parse(txtCustomerId.Text);

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "Update Customers Set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity where CustomerId=@customerId";

			var command = new NpgsqlCommand(query,connection);

			command.Parameters.AddWithValue("customerName", customerName);
			command.Parameters.AddWithValue("customerSurname", customerSurname);
			command.Parameters.AddWithValue("customerCity", customerCity);
			command.Parameters.AddWithValue("customerId", id);

			command.ExecuteNonQuery();

			MessageBox.Show("Customer Updated!");

			connection.Close();

			getAllCustomers();
			

		}

		private void btnGetById_Click(object sender, EventArgs e)
		{

			int id = int.Parse(txtCustomerId.Text);

			getById(id);
		}
	}
}
