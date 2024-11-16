namespace CSharpEgitimKampi301.EFProject
{
	partial class Form1
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
			this.txtIdas = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtNamesa = new System.Windows.Forms.Label();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtSurnames = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnGetById = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtIdas
			// 
			this.txtIdas.AutoSize = true;
			this.txtIdas.Location = new System.Drawing.Point(88, 48);
			this.txtIdas.Name = "txtIdas";
			this.txtIdas.Size = new System.Drawing.Size(60, 16);
			this.txtIdas.TabIndex = 0;
			this.txtIdas.Text = "Guide Id:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(154, 45);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(157, 22);
			this.txtId.TabIndex = 1;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(236, 177);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(90, 32);
			this.btnList.TabIndex = 2;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(348, 45);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(602, 311);
			this.dataGridView1.TabIndex = 3;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(154, 82);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(157, 22);
			this.txtName.TabIndex = 5;
			// 
			// txtNamesa
			// 
			this.txtNamesa.AutoSize = true;
			this.txtNamesa.Location = new System.Drawing.Point(62, 85);
			this.txtNamesa.Name = "txtNamesa";
			this.txtNamesa.Size = new System.Drawing.Size(86, 16);
			this.txtNamesa.TabIndex = 4;
			this.txtNamesa.Text = "Guide Name:";
			this.txtNamesa.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtSurname
			// 
			this.txtSurname.Location = new System.Drawing.Point(154, 121);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(157, 22);
			this.txtSurname.TabIndex = 7;
			// 
			// txtSurnames
			// 
			this.txtSurnames.AutoSize = true;
			this.txtSurnames.Location = new System.Drawing.Point(45, 121);
			this.txtSurnames.Name = "txtSurnames";
			this.txtSurnames.Size = new System.Drawing.Size(103, 16);
			this.txtSurnames.TabIndex = 6;
			this.txtSurnames.Text = "Guide Surname:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(236, 295);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(90, 32);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(236, 256);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(90, 33);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(236, 215);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(90, 35);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(236, 333);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(90, 32);
			this.btnGetById.TabIndex = 11;
			this.btnGetById.Text = "Get by Id";
			this.btnGetById.UseVisualStyleBackColor = true;
			this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(976, 514);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.txtSurnames);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtNamesa);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtIdas);
			this.Name = "Form1";
			this.Text = "Guide Operations";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtIdas;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label txtNamesa;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.Label txtSurnames;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnGetById;
	}
}

