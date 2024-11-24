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
	public partial class FrmStatistics : Form
	{
		public FrmStatistics()
		{
			InitializeComponent();
		}

		EgitimKampi301EFTravelDbEntities db = new EgitimKampi301EFTravelDbEntities();
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void FrmStatistics_Load(object sender, EventArgs e)
		{
			// Total Location Numbers

			lblLocationCount.Text = db.Locations.Count().ToString();

			// Total Capacity 

			lblTotalCapacity.Text = db.Locations.Sum(x => x.Capacity).ToString();

			// Total Guide

			lblTotalGuide.Text = db.Guides.Count().ToString();

			// Average Capacity

			/* Alternative Way
			int totalCapacity = int.Parse(db.Locations.Sum(x => x.Capacity).ToString());
			int totalLocations = int.Parse(db.Locations.Count().ToString());
			lblAverageCapacity.Text =(totalCapacity / totalLocations).ToString();
			*/
			lblAverageCapacity.Text = ((int?)db.Locations.Average(x => x.Capacity)).ToString();

			// Average Price

			lblAveragePrice.Text = (Math.Round((double)db.Locations.Average(x => x.Price), 2)).ToString("F2") + " ₺";
			
			// Last Country Added

			int lastCountryId = db.Locations.Max(x => x.LocationId);

			// lblCountry.Text = db.Locations.Find(lastCountryId).Country; ALTERNATİVE
			lblCountry.Text = db.Locations.Where(x => x.LocationId == lastCountryId)
				.Select(x => x.Country).FirstOrDefault();	

			// Miami Capacity

			lblMiamiCapacity.Text = db.Locations.Where(x => x.City == "Miami")
				.Select(x => x.Capacity).FirstOrDefault().ToString();

			// Türkiye Average Capacity

			lblTurkiyeAverageCapacity.Text = db.Locations.Where(x => x.Country == "Türkiye")
				.Average(x => x.Capacity).ToString();

			// Kırşehir Guide Name

			int guideId = int.Parse(db.Locations.Where(x => x.City == "Kırşehir")
				.Select( x => x.GuideId).FirstOrDefault().ToString());

			lblKırsehirGuideName.Text = db.Guides.Where(x => x.GuideId == guideId)
				.Select(x => x.GuideName +" "+ x.GuideSurname).FirstOrDefault().ToString();

			// Country With the Highest Capacity

			var highestCapacityCountry = db.Locations.Max(x => x.Capacity);

			lblHighestCapacityCountry.Text = db.Locations.Where(x => x.Capacity == highestCapacityCountry)
				.Select(x => x.Country).FirstOrDefault().ToString();

			// Most Expensive City

			var mostExpensivePrice = db.Locations.Max(x => x.Price);

			lblMostExpensive.Text = db.Locations.Where(x => x.Price == mostExpensivePrice)
				.Select(X => X.City).FirstOrDefault().ToString();

			// Guide Location Number

			var guideIdByDusanTadic = db.Guides.Where(x => x.GuideName == "Dusan" && x.GuideSurname == "Tadic")
				.Select(x => x.GuideId)
				.FirstOrDefault();

			lblGuideLocationNumber.Text = db.Locations.Where(x => x.GuideId == guideIdByDusanTadic ).
				Count().ToString();
		}


		private void label2_Click(object sender, EventArgs e)
		{
			
		}

		private void label22_Click(object sender, EventArgs e)
		{

		}
	}

	
}
