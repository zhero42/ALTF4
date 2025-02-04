﻿using BLL;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Info_IT
{
	public partial class Home : Form
	{
		public bool isLoggedIn;
		public string role;
		public string First;
		public string Last;
		public bool firstUser;
		public bool firstPass;

		BusinessLogicLayer bll = new BusinessLogicLayer();

        public Home()
        {
            //Thread t = new Thread(new ThreadStart(Loading));
            //t.Start();
            InitializeComponent();
            //for (int i = 0; i <= 1000; i++)
            //{
            //    Thread.Sleep(10);
            //}
            //t.Abort();
        }
        //void Loading()
        //{
        //    SplashScreen splash = new SplashScreen();
        //    Application.Run(splash);
        //}

        private void Template_Load(object sender, EventArgs e)
		{
			this.TopMost = true;

			HideAll();
			LoginPanel();

			//Focus label instead of txtUsername
			this.ActiveControl = label2;

			//Hidden when first launching
			pnlNavigation.Hide();
			pnlLogin.Hide();
			btnNavHelp.Hide();
			lblDisplayName.Hide();
			lblLoginError.Hide();
			lblLoginErrorExtra.Hide();

			ucHome1.Visible = false;
			btnNavUser.Hide();
			this.TopMost = false;

		}

		public void LoginPanel()
		{
			pnlLoginFields.Visible = true;
			pnlLoginFields.Focus();

			this.Text = "Login";
			lblLocation.Text = "Login";

			//This is like an If Else statement for isLoggedIn
			switch (isLoggedIn)
			{
				case true:
					lblLoginText.Text = "Log out";
					isLoggedIn = false;
					pnlLogin.Show();
					break;

				case false:
					lblLoginText.Text = "Log In";
					pnlLogin.Show();
					lblDisplayName.Hide();
					break;
			}

			//This is like an If Else statement for getting the Role
			switch (role)
			{
				case "Admin":
					lblLoginText.Text = "Log out";
					////What can Admin see
					ShowAll();

					break;

				case "ICT HelpDesk":
					lblLoginText.Text = "Log In";
					////What can Staff see
					ShowAll();

					//btnNavHome.Hide();
					//btnNavEquipment.Hide();
					//btnNavVenue.Hide();
					//btnNavDepartment.Hide();
					//btnNavRequest.Hide();
					//btnNavTutorRequest.Hide();
					//btnNavInspection.Hide();
					//btnNavTaskType.Hide();
					//btnNavStudent.Hide();
					//btnNavStaff.Hide();
					//btnNavUser.Hide();

					break;
				case "Info@IT":
					////What can Info@It Staff see
					ShowAll();

					//btnNavHome.Hide();
					//btnNavEquipment.Hide();
					btnNavVenue.Hide();
					btnNavDepartment.Hide();
					//btnNavRequest.Hide();
					//btnNavTutorRequest.Hide();
					//btnNavInspection.Hide();
					//btnNavTaskType.Hide();
					//btnNavStudent.Hide();
					btnNavStaff.Hide();
					btnNavUser.Hide();

					break;

				case "Student Assistant":
					////What can SI see
					ShowAll();

					//btnNavHome.Hide();
					//btnNavEquipment.Hide();
					btnNavVenue.Hide();
					btnNavDepartment.Hide();
					//btnNavRequest.Hide();
					//btnNavTutorRequest.Hide();
					//btnNavInspection.Hide();
					btnNavTaskType.Hide();
					btnNavStudent.Hide();
					btnNavStaff.Hide();
					btnNavUser.Hide();

					break;
				default:
					////What can everyone else see

					btnNavHome.Hide();
					btnNavEquipment.Hide();
					btnNavVenue.Hide();
					btnNavDepartment.Hide();
					btnNavDepartment.Hide();
					btnNavRequest.Hide();
					btnNavTutorRequest.Hide();
					btnNavInspection.Hide();
					btnNavTaskType.Hide();
					btnNavStudent.Hide();
					btnNavStaff.Hide();
					btnNavUser.Hide();
					btnReports.Hide();
					btnNavHelp.Hide();

					break;

			}

		}


		private void BtnLogIn_Click(object sender, EventArgs e)
		{
			DAL.LoginClass login = new DAL.LoginClass(txtUsername.Text, txtPassword.Text);

			//DataGridView x = new DataGridView();

			var x = bll.GetLogin(login);

			if (x.Rows.Count == 0)
			{
				lblLoginError.Show();
				//MessageBox.Show("Incorrect Username and Password");
			}
			else
			{
				isLoggedIn = true;
				try
				{
					var a = x.Rows[0].Table.Rows[0].ItemArray;
					role = a[6].ToString();
					lblDisplayName.Text = a[3].ToString() + ", " + a[2].ToString() + "(" + a[6].ToString() + ")";
					lblDisplayName.Show();

					ucHome1.lblWelcome.Text = "Welcome " + a[2].ToString() + " " + a[3].ToString();
					ucHome1.lblRole.Text = "You are currently role: " + a[6].ToString() + "!";
				}
				catch
				{
					int i = x.Rows.Count;

					lblLoginErrorExtra.Text = i.ToString();
					//MessageBox.Show(i.ToString());
				}
				LoginPanel();
				HideAll();
				ucHome1.Show();
				ucHome1.Visible = true;

				this.Text = "Info@IT";
				lblLocation.Text = "Home";

				pnlNavigation.Show();

				txtUsername.Text = "";
				txtPassword.Text = "";
			}



			//isLoggedIn = true;
			//LoginPanel();
			//HideAll();
			//ucHome1.Show();

			//this.Text = "Info@IT";
			//lblLocation.Text = "Home";

			//pnlNavigation.Show();
			//btnNavHelp.Show();

		}

		private void InactiveButtons()
		{
			btnNavDepartment.BackColor = Color.FromArgb(0, 80, 200);
			btnNavEquipment.BackColor = Color.FromArgb(0, 80, 200);
			btnNavHome.BackColor = Color.FromArgb(0, 80, 200);
			btnNavInspection.BackColor = Color.FromArgb(0, 80, 200);
			btnNavRequest.BackColor = Color.FromArgb(0, 80, 200);
			btnNavTaskType.BackColor = Color.FromArgb(0, 80, 200);
			btnNavTutorRequest.BackColor = Color.FromArgb(0, 80, 200);
			btnNavVenue.BackColor = Color.FromArgb(0, 80, 200);
			btnNavStudent.BackColor = Color.FromArgb(0, 80, 200);
			btnNavStaff.BackColor = Color.FromArgb(0, 80, 200);
			btnNavUser.BackColor = Color.FromArgb(0, 80, 200);
			btnNavHelp.BackColor = Color.FromArgb(0, 80, 200);
			btnReports.BackColor = Color.FromArgb(0, 80, 200);
		}

		private void HideAll()
		{
			//Panels
			ucEquipment1.Hide();
			ucHome1.Hide();
			ucVenue1.Hide();
			ucDepartment1.Hide();
			ucRequest1.Hide();
			ucTutorRequest1.Hide();
			ucNavInspection1.Hide();
			ucTaskType1.Hide();
			ucHelp1.Hide();
			ucStudent1.Hide();
			ucStaff1.Hide();
			ucUser1.Hide();
			ucReport1.Hide();

			//Errors
			ucErrorFailedToAdd1.Hide();
			ucErrorStaffNotFound1.Hide();
			ucErrorStudentNotFound1.Hide();
			ucErrorUserNotFound1.Hide();
			ucErrorVenueNotFound1.Hide();

			//Misc
			pnlLoginFields.Hide();
		}

		private void ShowAll()
		{
			//Buttons
			btnNavHome.Show();
			btnNavEquipment.Show();
			btnNavVenue.Show();
			btnNavDepartment.Show();
			btnNavDepartment.Show();
			btnNavRequest.Show();
			btnNavTutorRequest.Show();
			btnNavInspection.Show();
			btnNavTaskType.Show();
			btnNavStudent.Show();
			btnNavStaff.Show();
			btnReports.Show();
			btnNavHelp.Show();
		}

		//Login bar
		private void Login_Click(object sender, EventArgs e)
		{
			LoginPanel();

			//Hidden when first launching
			btnNavHelp.Hide();
			pnlNavigation.Hide();
			pnlLogin.Hide();
		}


		//Menu button (Navigation)
		private void BtnNavigation_Click(object sender, EventArgs e)
		{
			tmrNavigation.Start();
			if (!(pnlNavigation.Height == pnlNavigation.MinimumSize.Height))
			{
				pnlNavigation.Height = pnlNavigation.MinimumSize.Height;
				tmrNavigation.Enabled = false;
			}
		}
		private void TmrNavigation_Tick(object sender, EventArgs e)
		{
			pnlNavigation.Height = pnlNavigation.MaximumSize.Height;

			tmrNavigation.Stop();
		}

		private void BtnNavigation_MouseEnter(object sender, EventArgs e)
		{
			btnNavigation.FlatAppearance.BorderColor = Color.FromArgb(128, 200, 255);
			btnNavigation.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 200, 255);
		}

		private void BtnNavigation_MouseLeave(object sender, EventArgs e)
		{
			btnNavigation.FlatAppearance.BorderColor = Color.DarkTurquoise;
			btnNavigation.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
		}

		private void PnlLogin_MouseEnter(object sender, EventArgs e)
		{
			pnlLogin.BackColor = Color.FromArgb(0, 150, 250);
		}

		private void PnlLogin_MouseLeave(object sender, EventArgs e)
		{
			pnlLogin.BackColor = Color.FromArgb(0, 100, 200);

		}
		private void LblLoginText_MouseEnter(object sender, EventArgs e)
		{
			pnlLogin.BackColor = Color.FromArgb(0, 150, 250);

		}

		private void LblLoginText_MouseLeave(object sender, EventArgs e)
		{
			pnlLogin.BackColor = Color.FromArgb(0, 100, 200);

		}

		private void BtnNavHome_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavHome.BackColor = Color.FromArgb(0, 150, 250);

			ucHome1.Show();
			this.Text = "Info@IT";
			lblLocation.Text = "Home";
			ucHome1.Visible = true;
		}

		private void BtnNavEquipment_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavEquipment.BackColor = Color.FromArgb(0, 150, 250);

			ucEquipment1.Show();
			this.Text = "Equipment";
			lblLocation.Text = "Equipment";

		}

		private void BtnNavVenue_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavVenue.BackColor = Color.FromArgb(0, 150, 250);

			ucVenue1.Show();
			this.Text = "Venue";
			lblLocation.Text = "Venue";

		}

		private void BtnNavDepartment_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavDepartment.BackColor = Color.FromArgb(0, 150, 250);

			ucDepartment1.Show();
			this.Text = "Department";
			lblLocation.Text = "Department";

		}

		private void BtnNavRequest_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavRequest.BackColor = Color.FromArgb(0, 150, 250);

			ucRequest1.Show();
			this.Text = "Request";
			lblLocation.Text = "Request";
		}

		private void BtnNavTutorRequest_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavTutorRequest.BackColor = Color.FromArgb(0, 150, 250);

			ucTutorRequest1.Show();
			this.Text = "Tutor Requests";
			lblLocation.Text = "Tutor Request";
		}

		private void BtnNavInspection_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavInspection.BackColor = Color.FromArgb(0, 150, 250);

			ucNavInspection1.Show();
			this.Text = "Inspections";
			lblLocation.Text = "Inspections";
		}

		private void BtnNavTaskType_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavTaskType.BackColor = Color.FromArgb(0, 150, 250);

			ucTaskType1.Show();
			this.Text = "Task Type";
			lblLocation.Text = "Task Type";
		}

		private void BtnHelp_Click(object sender, EventArgs e)
		{
			//Making sure you cannot click it during log on
			if (pnlLoginFields.Visible == false)
			{
				HideAll();
				InactiveButtons();
				btnNavHelp.BackColor = Color.FromArgb(0, 150, 250);

				ucHelp1.Show();
				this.Text = "Help";
				lblLocation.Text = "Help";
			}
		}

		private void BtnStudent_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavStudent.BackColor = Color.FromArgb(0, 150, 250);

			ucStudent1.Show();
			this.Text = "Student";
			lblLocation.Text = "Student";
		}

		private void BtnStaff_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavStaff.BackColor = Color.FromArgb(0, 150, 250);

			ucStaff1.Show();
			this.Text = "Staff";
			lblLocation.Text = "Staff";
		}
		private void BtnNavUser_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnNavUser.BackColor = Color.FromArgb(0, 150, 250);

			ucUser1.Show();
			this.Text = "User";
			lblLocation.Text = "User";
		}

		private void BtnReports_Click(object sender, EventArgs e)
		{
			HideAll();
			InactiveButtons();
			btnReports.BackColor = Color.FromArgb(0, 150, 250);

			ucReport1.Show();
			this.Text = "Reports";
			lblLocation.Text = "Reports";
		}

		private void Logo_Click(object sender, EventArgs e)
		{
			//Making sure you cannot click it during log on
			//if (!isLoggedIn) 
			if (pnlLoginFields.Visible == false)
			{
				HideAll();
				InactiveButtons();
				btnNavHome.BackColor = Color.FromArgb(0, 150, 250);

				ucHome1.Show();
				this.Text = "Info@IT";
				lblLocation.Text = "Home";
			}
		}

		private void txtUsername_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnLogIn_Click(this, new EventArgs());
				e.Handled = e.SuppressKeyPress = true;
			}
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnLogIn_Click(this, new EventArgs());
				e.Handled = e.SuppressKeyPress = true;
			}
		}
	}
}