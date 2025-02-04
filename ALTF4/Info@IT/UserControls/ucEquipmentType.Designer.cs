﻿namespace Info_IT.UserControls
{
	partial class ucEquipmentType
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tmrManage = new System.Windows.Forms.Timer(this.components);
			this.btnManageUpdate = new System.Windows.Forms.Button();
			this.btnManageAdd = new System.Windows.Forms.Button();
			this.btnManage = new System.Windows.Forms.Button();
			this.pnlManage = new System.Windows.Forms.Panel();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCloseDetails = new Bunifu.Framework.UI.BunifuFlatButton();
			this.dgvEquipmentDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEquipmentType = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tmrView = new System.Windows.Forms.Timer(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.pnlManage.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentDetails)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tmrManage
			// 
			this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
			// 
			// btnManageUpdate
			// 
			this.btnManageUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnManageUpdate.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManageUpdate.FlatAppearance.BorderSize = 0;
			this.btnManageUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageUpdate.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnManageUpdate.Location = new System.Drawing.Point(0, 84);
			this.btnManageUpdate.Name = "btnManageUpdate";
			this.btnManageUpdate.Size = new System.Drawing.Size(200, 31);
			this.btnManageUpdate.TabIndex = 7;
			this.btnManageUpdate.Text = "Update Selected Equipment Type";
			this.btnManageUpdate.UseVisualStyleBackColor = false;
			this.btnManageUpdate.Click += new System.EventHandler(this.BtnManageUpdate_Click);
			// 
			// btnManageAdd
			// 
			this.btnManageAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnManageAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManageAdd.FlatAppearance.BorderSize = 0;
			this.btnManageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageAdd.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnManageAdd.Location = new System.Drawing.Point(0, 53);
			this.btnManageAdd.Name = "btnManageAdd";
			this.btnManageAdd.Size = new System.Drawing.Size(200, 31);
			this.btnManageAdd.TabIndex = 6;
			this.btnManageAdd.Text = "Add Equipment Type";
			this.btnManageAdd.UseVisualStyleBackColor = false;
			this.btnManageAdd.Click += new System.EventHandler(this.BtnManageAdd_Click);
			// 
			// btnManage
			// 
			this.btnManage.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManage.FlatAppearance.BorderSize = 0;
			this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnManage.Location = new System.Drawing.Point(0, 0);
			this.btnManage.MinimumSize = new System.Drawing.Size(180, 53);
			this.btnManage.Name = "btnManage";
			this.btnManage.Size = new System.Drawing.Size(200, 53);
			this.btnManage.TabIndex = 5;
			this.btnManage.Text = "Manage";
			this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnManage.UseVisualStyleBackColor = false;
			this.btnManage.Click += new System.EventHandler(this.BtnManage_Click);
			// 
			// pnlManage
			// 
			this.pnlManage.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlManage.Controls.Add(this.btnExportToExcel);
			this.pnlManage.Controls.Add(this.btnManageUpdate);
			this.pnlManage.Controls.Add(this.btnManageAdd);
			this.pnlManage.Controls.Add(this.btnManage);
			this.pnlManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlManage.Location = new System.Drawing.Point(0, 0);
			this.pnlManage.MaximumSize = new System.Drawing.Size(200, 148);
			this.pnlManage.MinimumSize = new System.Drawing.Size(200, 53);
			this.pnlManage.Name = "pnlManage";
			this.pnlManage.Size = new System.Drawing.Size(200, 53);
			this.pnlManage.TabIndex = 12;
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExportToExcel.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnExportToExcel.FlatAppearance.BorderSize = 0;
			this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnExportToExcel.Location = new System.Drawing.Point(0, 115);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(200, 31);
			this.btnExportToExcel.TabIndex = 8;
			this.btnExportToExcel.Text = "Export to Excel";
			this.btnExportToExcel.UseVisualStyleBackColor = false;
			this.btnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcel_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Controls.Add(this.pnlManage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 562);
			this.panel1.TabIndex = 21;
			// 
			// btnCloseDetails
			// 
			this.btnCloseDetails.Activecolor = System.Drawing.Color.Brown;
			this.btnCloseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCloseDetails.BackColor = System.Drawing.Color.Brown;
			this.btnCloseDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCloseDetails.BorderRadius = 0;
			this.btnCloseDetails.ButtonText = "X";
			this.btnCloseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCloseDetails.DisabledColor = System.Drawing.Color.Gray;
			this.btnCloseDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseDetails.Iconcolor = System.Drawing.Color.Transparent;
			this.btnCloseDetails.Iconimage = null;
			this.btnCloseDetails.Iconimage_right = null;
			this.btnCloseDetails.Iconimage_right_Selected = null;
			this.btnCloseDetails.Iconimage_Selected = null;
			this.btnCloseDetails.IconMarginLeft = 0;
			this.btnCloseDetails.IconMarginRight = 0;
			this.btnCloseDetails.IconRightVisible = true;
			this.btnCloseDetails.IconRightZoom = 0D;
			this.btnCloseDetails.IconVisible = true;
			this.btnCloseDetails.IconZoom = 90D;
			this.btnCloseDetails.IsTab = false;
			this.btnCloseDetails.Location = new System.Drawing.Point(1025, 0);
			this.btnCloseDetails.Margin = new System.Windows.Forms.Padding(4);
			this.btnCloseDetails.Name = "btnCloseDetails";
			this.btnCloseDetails.Normalcolor = System.Drawing.Color.Brown;
			this.btnCloseDetails.OnHovercolor = System.Drawing.Color.Red;
			this.btnCloseDetails.OnHoverTextColor = System.Drawing.Color.White;
			this.btnCloseDetails.selected = false;
			this.btnCloseDetails.Size = new System.Drawing.Size(32, 32);
			this.btnCloseDetails.TabIndex = 18;
			this.btnCloseDetails.Text = "X";
			this.btnCloseDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCloseDetails.Textcolor = System.Drawing.Color.White;
			this.btnCloseDetails.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseDetails.Click += new System.EventHandler(this.BtnCloseDetails_Click);
			// 
			// dgvEquipmentDetails
			// 
			this.dgvEquipmentDetails.AllowUserToAddRows = false;
			this.dgvEquipmentDetails.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvEquipmentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvEquipmentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEquipmentDetails.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvEquipmentDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvEquipmentDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEquipmentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvEquipmentDetails.ColumnHeadersHeight = 50;
			this.dgvEquipmentDetails.DoubleBuffered = true;
			this.dgvEquipmentDetails.EnableHeadersVisualStyles = false;
			this.dgvEquipmentDetails.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvEquipmentDetails.HeaderForeColor = System.Drawing.Color.White;
			this.dgvEquipmentDetails.Location = new System.Drawing.Point(0, 0);
			this.dgvEquipmentDetails.Name = "dgvEquipmentDetails";
			this.dgvEquipmentDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvEquipmentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEquipmentDetails.Size = new System.Drawing.Size(782, 429);
			this.dgvEquipmentDetails.TabIndex = 0;
			this.dgvEquipmentDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipmentDetails_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtEquipmentType);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(234, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(784, 71);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// txtEquipmentType
			// 
			this.txtEquipmentType.Location = new System.Drawing.Point(15, 35);
			this.txtEquipmentType.Name = "txtEquipmentType";
			this.txtEquipmentType.Size = new System.Drawing.Size(205, 23);
			this.txtEquipmentType.TabIndex = 33;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 17);
			this.label1.TabIndex = 32;
			this.label1.Text = "Equipment Type:";
			// 
			// tmrView
			// 
			this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvEquipmentDetails);
			this.panel3.Location = new System.Drawing.Point(234, 100);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 429);
			this.panel3.TabIndex = 19;
			// 
			// ucEquipmentType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCloseDetails);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel3);
			this.Name = "ucEquipmentType";
			this.Size = new System.Drawing.Size(1056, 562);
			this.Load += new System.EventHandler(this.BtnViewList_Click);
			this.pnlManage.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentDetails)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuFlatButton btnCloseDetails;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEquipmentDetails;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Timer tmrView;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEquipmentType;
		private System.Windows.Forms.Button btnExportToExcel;
	}
}
