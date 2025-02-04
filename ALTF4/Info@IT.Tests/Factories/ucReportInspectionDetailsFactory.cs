using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Info_IT.UserControls.Reports;
// <copyright file="ucReportInspectionDetailsFactory.cs" company="ALT + F4">Copyright ©Info@IT  2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Info_IT.UserControls.Reports
{
	/// <summary>A factory for Info_IT.UserControls.Reports.ucReportInspectionDetails instances</summary>
	public static partial class ucReportInspectionDetailsFactory
	{
		/// <summary>A factory for Info_IT.UserControls.Reports.ucReportInspectionDetails instances</summary>
		[PexFactoryMethod(typeof(ucReportInspectionDetails))]
		public static ucReportInspectionDetails Create(
			AutoValidate value_i,
			BorderStyle value_i1_,
			Control value_control,
			Point value_point,
			ISite value_iSite,
			int value_i2_
		)
		{
			ucReportInspectionDetails ucReportInspectionDetails
			   = new ucReportInspectionDetails();
			((UserControl)ucReportInspectionDetails).AutoValidate = value_i;
			((UserControl)ucReportInspectionDetails).BorderStyle = value_i1_;
			((ContainerControl)ucReportInspectionDetails).ActiveControl = value_control;
			((ScrollableControl)ucReportInspectionDetails).AutoScrollPosition = value_point;
			((Control)ucReportInspectionDetails).Site = value_iSite;
			((Control)ucReportInspectionDetails).TabIndex = value_i2_;
			return ucReportInspectionDetails;

			// TODO: Edit factory method of ucReportInspectionDetails
			// This method should be able to configure the object in all possible ways.
			// Add as many parameters as needed,
			// and assign their values to each field by using the API.
		}
	}
}
