﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT.UserControls
{
	public partial class ucReport : UserControl
	{
		public ucReport()
		{
			InitializeComponent();
		}

		private void UcReport_Load(object sender, EventArgs e)
		{
			HideAll();
		}
		private void InactiveButtons()
		{
			btnEquipmentReport.BackColor = Color.FromName("ControlDark");
			btnEquipmentReport.ForeColor = Color.Black;
			btnVenueReport.BackColor = Color.FromName("ControlDark");
			btnVenueReport.ForeColor = Color.Black;
			ucReportDepartment1.BackColor = Color.FromName("ControlDark");
			ucReportDepartment1.ForeColor = Color.Black;
			ucReportRequest1.BackColor = Color.FromName("ControlDark");
			ucReportRequest1.ForeColor = Color.Black;
			ucReportTutorRequest1.BackColor = Color.FromName("ControlDark");
			ucReportTutorRequest1.ForeColor = Color.Black;
			ucReportInspection1.BackColor = Color.FromName("ControlDark");
			ucReportInspection1.ForeColor = Color.Black;
			ucReportStaff1.BackColor = Color.FromName("ControlDark");
			ucReportStaff1.ForeColor = Color.Black;
		}

		private void HideAll()
		{
			ucReportEquipment1.Hide();
			ucReportVenue1.Hide();
			ucReportDepartment1.Hide();
			ucReportRequest1.Hide();
			ucReportTutorRequest1.Hide();
			ucReportInspection1.Hide();
			ucReportStaff1.Hide();
		}

		private void BtnEquipmentReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportEquipment1.Show();

			InactiveButtons();
			btnEquipmentReport.BackColor = Color.FromName("ControlDarkDark");
			btnEquipmentReport.ForeColor = Color.White;
		}

		private void BtnVenueReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportVenue1.Show();

			InactiveButtons();
			btnVenueReport.BackColor = Color.FromName("ControlDarkDark");
			btnVenueReport.ForeColor = Color.White;
		}

		private void BtnDepartmentReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportDepartment1.Show();

			InactiveButtons();
			ucReportDepartment1.BackColor = Color.FromName("ControlDarkDark");
			ucReportDepartment1.ForeColor = Color.White;
		}

		private void BtnRequestReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportRequest1.Show();

			InactiveButtons();
			ucReportRequest1.BackColor = Color.FromName("ControlDarkDark");
			ucReportRequest1.ForeColor = Color.White;
		}

		private void BtnTutorRequestsReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportTutorRequest1.Show();

			InactiveButtons();
			ucReportTutorRequest1.BackColor = Color.FromName("ControlDarkDark");
			ucReportTutorRequest1.ForeColor = Color.White;
		}

		private void BtnInspectionReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportInspection1.Show();

			InactiveButtons();
			ucReportInspection1.BackColor = Color.FromName("ControlDarkDark");
			ucReportInspection1.ForeColor = Color.White;
		}

		private void BtnStaffReport_Click(object sender, EventArgs e)
		{
			HideAll();
			ucReportStaff1.Show();

			InactiveButtons();
			ucReportStaff1.BackColor = Color.FromName("ControlDarkDark");
			ucReportStaff1.ForeColor = Color.White;
		}

		private void BtnStudentReport_Click(object sender, EventArgs e)
		{

		}
	}
}
