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
	public partial class FrmLocation : Form
	{
		public FrmLocation()
		{
			InitializeComponent();
		}

		EgitimKampi301EFTravelDbEntities db = new EgitimKampi301EFTravelDbEntities();
		private void btnList_Click(object sender, EventArgs e)
		{
			var values = db.Locations.ToList();
			dataGridView1.DataSource = values;
		}

		private void FrmLocation_Load(object sender, EventArgs e)
		{
			var values = db.Guides.Select(x=> new
			{
				FullName = x.GuideName + " " + x.GuideSurname,
				x.GuideId
			}).ToList();
			cmbGuide.DisplayMember = "FullName";
			cmbGuide.ValueMember = "GuideId";
			cmbGuide.DataSource = values;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Location location = new Location();
			
			location.City = txtCity.Text;
			location.Country = txtCountry.Text;
			location.Capacity = byte.Parse(nudCapacity.Value.ToString());
			location.Price = decimal.Parse(txtPrice.Text);
			location.DayNight = txtDayNight.Text;
			location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());

			db.Locations.Add(location);
			db.SaveChanges();
			MessageBox.Show("Successfully added.");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int	id = int.Parse(txtId.Text);
			var deletedValue = db.Locations.Find(id);

			db.Locations.Remove(deletedValue);
			db.SaveChanges();
			MessageBox.Show("Successfully deleted.");

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var updatedValue = db.Locations.Find(id);

			updatedValue.City = txtCity.Text;
			updatedValue.Country = txtCountry.Text;
			updatedValue.DayNight = txtDayNight.Text;
			updatedValue.Price = decimal.Parse(txtPrice.Text.ToString());
			updatedValue.Capacity = byte.Parse(nudCapacity.Text.ToString());
			updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());

			db.SaveChanges();
			MessageBox.Show("Successfully updated.");
		}
	}
}
