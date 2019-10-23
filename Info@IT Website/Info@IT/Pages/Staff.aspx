﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Info_IT.Pages.Staff" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Staff | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
	<script src="../Script/Scripts.js"></script>
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	<div class="contentWrapperReport">
			<div>
				<!-- Side Nav -->
				<div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey">
					<div onclick="openFlatButtonStaff()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div onclick="btnManageAdd" id="addButtonStaff" class="manageAdd" >
						<p class="manage" style="padding-top: 0px">Add Staff</p>
					</div>
                    <div id="updateButtonStaff" class="manageAdd_Style">
						
						<p class="manage" style="padding-top: 0px">Update Staff</p>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px;">
                    <div style="position:relative; top:0; height: 50%; width:100%;">
						<label style="position:absolute; left:220px; top:0;">Staff Number:</label>
						<label style="position:absolute; left:370px;">First Name:</label>
						<label style="position:absolute; left:520px;">Last Name:</label>
						<label style="position:absolute; left:670px;">Email Address:</label>
						<label style="position:absolute; left:820px;">Contact Number:</label>
                        
                        
                        <br />

						<asp:TextBox runat="server" ID="txtStaffNo" style="position:absolute; left:220px;"/>
						<asp:TextBox runat="server" ID="txtFirstName"  style="position:absolute; left:370px; height: 22px;"/>
						<asp:TextBox runat="server" ID="txtLastName"  style="position:absolute; left:520px;"/>
						<asp:TextBox runat="server" ID="txtEmail"  style="position:absolute; left:670px;" />
						<asp:TextBox runat="server" ID="txtContactNumber"  style="position:absolute; left:820px;"/>

                        <br />
                        <label style="position:absolute; left:220px;">Staff Type:</label>
                        <label style="position:absolute; left:370px;">Department Code:</label>
                        <label style="position:absolute; left:520px; ">Username:</label>
                        <label style="position:absolute; left:670px; ">Password:</label>
                        <label style="position:absolute; left:820px; ">Active Status:</label>
                        <br />
                        <asp:DropDownList runat="server" ID="cmbStaffType" style="position:absolute;left:220px;width:110px;height:22px"/>
                        <asp:DropDownList  runat="server" ID="cmbDepartmentCode" style="position:absolute;left:370px;width:110px;height:22px"/>
                        <asp:textbox runat="server" ID="txtUsername" style="position:absolute; left:520px;"/>
                        <asp:textbox runat="server" ID="txtPassword" style="position:absolute; left:670px;"/>
                        <asp:dropdownList runat="server" ID="cmbActiveStatus" style="position:absolute; left:820px;width:110px;height:22px"/>
					</div>
					
					<!-- DataGrid -->
					<div style="position:relative; top:50px; left: 220px; height: 50%; background-color: darkgrey">
						<asp:DataGrid runat="server" ID="dgStaff" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgStaff_Load1" OnSelectedIndexChanged="dgStaff_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
							<AlternatingItemStyle BackColor="White" ForeColor="#284775" />
							<EditItemStyle BackColor="#999999" />
							<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
							<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
							<ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
							<PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages" />
							<SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
						</asp:DataGrid>
                </div>
			</div>
    </div>
</asp:Content>