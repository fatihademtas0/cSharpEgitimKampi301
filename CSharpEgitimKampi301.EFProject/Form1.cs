using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		EgitimKampi301EFTravelDbEntities db = new EgitimKampi301EFTravelDbEntities();
		private void btnList_Click(object sender, EventArgs e)
		{
			
			
			var values = db.Guides.ToList();

			dataGridView1.DataSource = values;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Guide guide = new Guide();

			guide.GuideId = int.Parse(txtId.Text);
			guide.GuideName = txtName.Text;
			guide.GuideSurname = txtSurname.Text;

			db.Guides.Add(guide);

			db.SaveChanges();

			MessageBox.Show("Guide added successfully!");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);

			var removeValue = db.Guides.Find(id); 

			db.Guides.Remove(removeValue);
			db.SaveChanges();

			MessageBox.Show("Guide deleted successfully!");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			Guide guide = new Guide();
			int id = int.Parse(txtId.Text);

			var updateValue = db.Guides.Find(id);

			updateValue.GuideName = txtName.Text;
			updateValue.GuideSurname= txtSurname.Text;

			db.SaveChanges();
			MessageBox.Show("Guide updated successfully!",
				"Warning",MessageBoxButtons.OK,MessageBoxIcon.Information );
			btnList_Click(sender, e); // when we update we get all guides
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			Guide guide = new Guide();
			int id = int.Parse(txtId.Text);

			var value = db.Guides.Where(x=> x.GuideId==id).ToList();

			dataGridView1.DataSource = value;

		}
	}
}
