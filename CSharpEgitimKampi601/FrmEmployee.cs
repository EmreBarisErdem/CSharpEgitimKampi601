﻿using Npgsql;
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
	public partial class FrmEmployee : Form
	{
		public FrmEmployee()
		{
			InitializeComponent();
		}

		string connectionString = "Server=localhost;port=5432;Database=Customer;user Id=postgres;password=09Haz1992."; 

		void EmployeeList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * from Employees";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		void DepartmentList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * From Departments";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);

			cmbDepartment.DisplayMember = "departmentname";
			cmbDepartment.ValueMember = "departmentid";
			cmbDepartment.DataSource = dt;
			connection.Close();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			EmployeeList();
		}

		private void FrmEmployee_Load(object sender, EventArgs e)
		{
			EmployeeList();
			DepartmentList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			string employeeName = txtEmployeeName.Text;
			string employeeSurname = txtEmplyeeSurname.Text;
			decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
			int departmentId = int.Parse(cmbDepartment.SelectedValue.ToString());

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "insert into Employees (EmployeeName, EmployeeSurname, EmployeeSalary, DepartmentId) values (@employeeName, @employeeSurname, @employeeSalary, @departmentid)";

			var command = new NpgsqlCommand(query, connection);

			command.Parameters.AddWithValue("@employeeName", employeeName);
			command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
			command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
			command.Parameters.AddWithValue("@departmentid", departmentId);

			command.ExecuteNonQuery();

			MessageBox.Show("Ekleme İşlemi Başarılı");

			connection.Close();

			EmployeeList();
			

		}
	}
}