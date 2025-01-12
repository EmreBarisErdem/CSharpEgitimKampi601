namespace CSharpEgitimKampi601
{
	partial class FrmEmployee
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGetById = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmplyeeSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmplyeeId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnGetById.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnGetById.Location = new System.Drawing.Point(184, 640);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(209, 56);
			this.btnGetById.TabIndex = 49;
			this.btnGetById.Text = "Id\'ye göre getir";
			this.btnGetById.UseVisualStyleBackColor = false;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUpdate.Location = new System.Drawing.Point(184, 564);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(209, 56);
			this.btnUpdate.TabIndex = 48;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.Location = new System.Drawing.Point(184, 492);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(209, 56);
			this.btnDelete.TabIndex = 47;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCreate.Location = new System.Drawing.Point(184, 420);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(209, 56);
			this.btnCreate.TabIndex = 46;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnList.Location = new System.Drawing.Point(184, 348);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(209, 56);
			this.btnList.TabIndex = 45;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(417, 55);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1533, 641);
			this.dataGridView1.TabIndex = 44;
			// 
			// txtEmployeeSalary
			// 
			this.txtEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmployeeSalary.Location = new System.Drawing.Point(184, 217);
			this.txtEmployeeSalary.Name = "txtEmployeeSalary";
			this.txtEmployeeSalary.Size = new System.Drawing.Size(209, 30);
			this.txtEmployeeSalary.TabIndex = 43;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(26, 218);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 25);
			this.label4.TabIndex = 42;
			this.label4.Text = "Personel Maaş:";
			// 
			// txtEmplyeeSurname
			// 
			this.txtEmplyeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmplyeeSurname.Location = new System.Drawing.Point(184, 163);
			this.txtEmplyeeSurname.Name = "txtEmplyeeSurname";
			this.txtEmplyeeSurname.Size = new System.Drawing.Size(209, 30);
			this.txtEmplyeeSurname.TabIndex = 41;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(14, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 25);
			this.label3.TabIndex = 40;
			this.label3.Text = "Personel Soyadı:";
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmployeeName.Location = new System.Drawing.Point(184, 109);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(209, 30);
			this.txtEmployeeName.TabIndex = 39;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(46, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 25);
			this.label2.TabIndex = 38;
			this.label2.Text = "Personel Adı:";
			// 
			// txtEmplyeeId
			// 
			this.txtEmplyeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmplyeeId.Location = new System.Drawing.Point(184, 55);
			this.txtEmplyeeId.Name = "txtEmplyeeId";
			this.txtEmplyeeId.Size = new System.Drawing.Size(209, 30);
			this.txtEmplyeeId.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(56, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 25);
			this.label1.TabIndex = 36;
			this.label1.Text = "Personel ID:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(61, 273);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 25);
			this.label5.TabIndex = 50;
			this.label5.Text = "Departman:";
			// 
			// cmbDepartment
			// 
			this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(184, 273);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(209, 33);
			this.cmbDepartment.TabIndex = 51;
			// 
			// FrmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1989, 747);
			this.Controls.Add(this.cmbDepartment);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtEmployeeSalary);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEmplyeeSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmplyeeId);
			this.Controls.Add(this.label1);
			this.Name = "FrmEmployee";
			this.Text = "FrmEmployee";
			this.Load += new System.EventHandler(this.FrmEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtEmployeeSalary;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmplyeeSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmplyeeId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbDepartment;
	}
}