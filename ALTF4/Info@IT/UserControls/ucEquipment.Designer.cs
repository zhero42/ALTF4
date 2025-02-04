﻿namespace Info_IT.UserControls
{
	partial class UcEquipment
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvEquipment = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlView = new System.Windows.Forms.Panel();
			this.btnViewEquipmentTypes = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.pnlManage = new System.Windows.Forms.Panel();
			this.btnManageDelete = new System.Windows.Forms.Button();
			this.btnManageUpdate = new System.Windows.Forms.Button();
			this.btnManageAdd = new System.Windows.Forms.Button();
			this.btnManage = new System.Windows.Forms.Button();
			this.tmrManage = new System.Windows.Forms.Timer(this.components);
			this.tmrView = new System.Windows.Forms.Timer(this.components);
			this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.cmbEquipTypeCode = new System.Windows.Forms.ComboBox();
			this.cmbVenue = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ucEquipmentType1 = new Info_IT.UserControls.ucEquipmentType();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnlView.SuspendLayout();
			this.pnlManage.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvEquipment);
			this.panel3.Location = new System.Drawing.Point(234, 100);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(782, 429);
			this.panel3.TabIndex = 8;
			// 
			// dgvEquipment
			// 
			this.dgvEquipment.AllowUserToAddRows = false;
			this.dgvEquipment.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvEquipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEquipment.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvEquipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvEquipment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvEquipment.ColumnHeadersHeight = 50;
			this.dgvEquipment.DoubleBuffered = true;
			this.dgvEquipment.EnableHeadersVisualStyles = false;
			this.dgvEquipment.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.dgvEquipment.HeaderForeColor = System.Drawing.Color.White;
			this.dgvEquipment.Location = new System.Drawing.Point(0, 0);
			this.dgvEquipment.Name = "dgvEquipment";
			this.dgvEquipment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEquipment.Size = new System.Drawing.Size(782, 429);
			this.dgvEquipment.TabIndex = 0;
			this.dgvEquipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipment_CellClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Controls.Add(this.pnlView);
			this.panel1.Controls.Add(this.pnlManage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 562);
			this.panel1.TabIndex = 9;
			// 
			// pnlView
			// 
			this.pnlView.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlView.Controls.Add(this.btnViewEquipmentTypes);
			this.pnlView.Controls.Add(this.btnView);
			this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlView.Location = new System.Drawing.Point(0, 53);
			this.pnlView.MaximumSize = new System.Drawing.Size(200, 115);
			this.pnlView.MinimumSize = new System.Drawing.Size(200, 53);
			this.pnlView.Name = "pnlView";
			this.pnlView.Size = new System.Drawing.Size(200, 53);
			this.pnlView.TabIndex = 13;
			// 
			// btnViewEquipmentTypes
			// 
			this.btnViewEquipmentTypes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnViewEquipmentTypes.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnViewEquipmentTypes.FlatAppearance.BorderSize = 0;
			this.btnViewEquipmentTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnViewEquipmentTypes.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnViewEquipmentTypes.Location = new System.Drawing.Point(0, 53);
			this.btnViewEquipmentTypes.Name = "btnViewEquipmentTypes";
			this.btnViewEquipmentTypes.Size = new System.Drawing.Size(200, 31);
			this.btnViewEquipmentTypes.TabIndex = 7;
			this.btnViewEquipmentTypes.Text = "View Equipment Types";
			this.btnViewEquipmentTypes.UseVisualStyleBackColor = false;
			this.btnViewEquipmentTypes.Click += new System.EventHandler(this.BtnViewEquipmentTypes_Click);
			// 
			// btnView
			// 
			this.btnView.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnView.FlatAppearance.BorderSize = 0;
			this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnView.Location = new System.Drawing.Point(0, 0);
			this.btnView.MinimumSize = new System.Drawing.Size(180, 53);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(200, 53);
			this.btnView.TabIndex = 5;
			this.btnView.Text = "View";
			this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnView.UseVisualStyleBackColor = false;
			this.btnView.Click += new System.EventHandler(this.BtnView_Click);
			// 
			// pnlManage
			// 
			this.pnlManage.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlManage.Controls.Add(this.btnExportToExcel);
			this.pnlManage.Controls.Add(this.btnManageDelete);
			this.pnlManage.Controls.Add(this.btnManageUpdate);
			this.pnlManage.Controls.Add(this.btnManageAdd);
			this.pnlManage.Controls.Add(this.btnManage);
			this.pnlManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlManage.Location = new System.Drawing.Point(0, 0);
			this.pnlManage.MaximumSize = new System.Drawing.Size(200, 179);
			this.pnlManage.MinimumSize = new System.Drawing.Size(200, 53);
			this.pnlManage.Name = "pnlManage";
			this.pnlManage.Size = new System.Drawing.Size(200, 53);
			this.pnlManage.TabIndex = 12;
			// 
			// btnManageDelete
			// 
			this.btnManageDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnManageDelete.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManageDelete.FlatAppearance.BorderSize = 0;
			this.btnManageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageDelete.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnManageDelete.Location = new System.Drawing.Point(0, 115);
			this.btnManageDelete.Name = "btnManageDelete";
			this.btnManageDelete.Size = new System.Drawing.Size(200, 31);
			this.btnManageDelete.TabIndex = 8;
			this.btnManageDelete.Text = "Delete Selected Equipment";
			this.btnManageDelete.UseVisualStyleBackColor = false;
			this.btnManageDelete.Click += new System.EventHandler(this.BtnManageDelete_Click);
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
			this.btnManageUpdate.Text = "Update Selected Equipment";
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
			this.btnManageAdd.Text = "Add Equipment";
			this.btnManageAdd.UseVisualStyleBackColor = false;
			this.btnManageAdd.Click += new System.EventHandler(this.BtnManageAdd_Click);
			// 
			// btnManage
			// 
			this.btnManage.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnManage.FlatAppearance.BorderSize = 0;
			this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			// tmrManage
			// 
			this.tmrManage.Tick += new System.EventHandler(this.TmrManage_Tick);
			// 
			// tmrView
			// 
			this.tmrView.Tick += new System.EventHandler(this.TmrView_Tick);
			// 
			// bunifuFormFadeTransition1
			// 
			this.bunifuFormFadeTransition1.Delay = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Description:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label3.Location = new System.Drawing.Point(205, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Venue:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(15, 35);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(187, 23);
			this.txtDescription.TabIndex = 3;
			// 
			// cmbEquipTypeCode
			// 
			this.cmbEquipTypeCode.FormattingEnabled = true;
			this.cmbEquipTypeCode.Location = new System.Drawing.Point(401, 35);
			this.cmbEquipTypeCode.Name = "cmbEquipTypeCode";
			this.cmbEquipTypeCode.Size = new System.Drawing.Size(187, 23);
			this.cmbEquipTypeCode.TabIndex = 4;
			this.cmbEquipTypeCode.SelectedIndexChanged += new System.EventHandler(this.CmbEquipTypeCode_SelectedIndexChanged);
			// 
			// cmbVenue
			// 
			this.cmbVenue.FormattingEnabled = true;
			this.cmbVenue.Location = new System.Drawing.Point(208, 35);
			this.cmbVenue.Name = "cmbVenue";
			this.cmbVenue.Size = new System.Drawing.Size(187, 23);
			this.cmbVenue.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
			this.label4.Location = new System.Drawing.Point(398, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Equipment Type:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbVenue);
			this.groupBox1.Controls.Add(this.cmbEquipTypeCode);
			this.groupBox1.Controls.Add(this.txtDescription);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
			this.groupBox1.Location = new System.Drawing.Point(234, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(784, 71);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// ucEquipmentType1
			// 
			this.ucEquipmentType1.Location = new System.Drawing.Point(0, 0);
			this.ucEquipmentType1.Name = "ucEquipmentType1";
			this.ucEquipmentType1.Size = new System.Drawing.Size(1056, 562);
			this.ucEquipmentType1.TabIndex = 1;
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExportToExcel.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnExportToExcel.FlatAppearance.BorderSize = 0;
			this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 8.75F);
			this.btnExportToExcel.Location = new System.Drawing.Point(0, 146);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(200, 31);
			this.btnExportToExcel.TabIndex = 9;
			this.btnExportToExcel.Text = "Export to Excel";
			this.btnExportToExcel.UseVisualStyleBackColor = false;
			this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
			// 
			// UcEquipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ucEquipmentType1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.Name = "UcEquipment";
			this.Size = new System.Drawing.Size(1056, 562);
			this.Load += new System.EventHandler(this.UcEquipment_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
			this.panel1.ResumeLayout(false);
			this.pnlView.ResumeLayout(false);
			this.pnlManage.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlView;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Panel pnlManage;
		private System.Windows.Forms.Button btnManageUpdate;
		private System.Windows.Forms.Button btnManageAdd;
		private System.Windows.Forms.Button btnManage;
		private System.Windows.Forms.Timer tmrManage;
		private System.Windows.Forms.Timer tmrView;
		private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.ComboBox cmbEquipTypeCode;
		private System.Windows.Forms.ComboBox cmbVenue;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEquipment;
		private System.Windows.Forms.Button btnViewEquipmentTypes;
		private ucEquipmentType ucEquipmentType1;
		private System.Windows.Forms.Button btnManageDelete;
		private System.Windows.Forms.Button btnExportToExcel;
	}
}
