﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HelpDesk.Master" AutoEventWireup="true" CodeBehind="InspectionDetails.aspx.cs" Inherits="Info_IT.Pages.InspectionDetails" %>
<%-- Title --%>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="title">Inspection Details | Info@IT HelpDesk Web-System</asp:Content>

<%-- Head --%>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head">
	<link href="../css/Master.css" rel="stylesheet" />
	<script src="../Script/Scripts.js"></script>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" />
	         <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
	         <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</asp:Content>

<%-- Body --%>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="BodyContent">
	<div class="contentWrapperReport">
			<div>
				<!-- Side Nav -->
				<div style="position:absolute; min-height: 100%; width: 200px; left: 0px; padding-bottom: 2px; background-color: grey">
					<div onclick="openFlatButtonInspectionDetails()" class="manage_Style">
						<p class="manage" style="padding-top: 0px">Manage</p>
					</div>
                    <div id="addButtonInspectionDetails" class="manageAdd">
                        <asp:button runat="server" class="manage" style="padding-top: 0px; width: 200px;height:inherit;background-color: #696969;border:none" OnClick="btnManageAdd"  Text="Add Inspection Details"></asp:button>
                    </div>
                    <div id="updateButtonInspectionDetails" class="manageAdd_Style">
						<asp:button runat="server" class="manage" style="padding-top: 0px; width: 200px;height:inherit;background-color: #696969;border:none" OnClick="btnManageUpdate" Text="Update Inspection Details" ></asp:button>
					</div>
				</div>

				<!-- Content -->
                <div style="min-height: 100%; width:100%; padding-top:10px; padding-bottom: 2px; background-color: white">
                     <asp:ScriptManager runat="server" ID="script"></asp:ScriptManager>
			   <asp:UpdatePanel runat="server" ID="updateDG" UpdateMode="Conditional">
				   <ContentTemplate>
					<div style="position:relative; top:0; height: 50%; width:100%;">
						<label style="position:absolute; left:220px; width:150px">Inspection Code:</label>
						<label style="position:absolute; left:400px; width:150px">Equipment Code:</label>
						<label style="position:absolute; left:580px; width:150px">Staff Member:</label>
						<label style="position:absolute; left:760px; width:150px">Fault Comment:</label>
                        <label style="position:absolute; left:940px; width:150px">Status:</label>

                        <br />
                        
						<asp:DropDownList runat="server" ID="cmbInspectionCode" style="position:absolute; width:150px; height: 21px; left:220px;"/>
						<asp:DropDownList runat="server" ID="cmbEquipment" style="position:absolute; width:150px; height: 21px; left:400px;"/>
						<asp:DropDownList runat="server" ID="cmbStaffMember"  style="position:absolute; width:150px; height: 21px; left:580px;"/>
						<asp:TextBox runat="server" ID="txtFaultComment"  style="position:absolute; width:150px; height: 21px; left:760px;"/>
                        <asp:DropDownList runat="server" ID="cmbStatus" style="position:absolute; width:150px; height: 21px; left:940px;">
                            <asp:ListItem>Pending</asp:ListItem>
                            <asp:ListItem>In Progress</asp:ListItem>
                            <asp:ListItem>Completed</asp:ListItem>
                            <asp:ListItem>Cancelled</asp:ListItem>
                        </asp:DropDownList>
					</div>

                   

					<!-- DataGrid -->
					<div style="position:relative; top:80px; left: 220px; height: 50%; background-color: darkgrey">
                        <asp:DataGrid runat="server" ID="dgInspectionDetails" style="width:100%; height:50%; vertical-align:middle;" OnLoad="dgInspectionDetails_Load1" OnSelectedIndexChanged="dgInspectionDetails_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
							<AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
								<asp:ButtonColumn CommandName="Select" Text="Select"></asp:ButtonColumn>
							</Columns>
							<EditItemStyle BackColor="#999999" />
							<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
							<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
							<ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
							<PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages" />
							<SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
						</asp:DataGrid>
                    </div>
                       </ContentTemplate>
				   </asp:UpdatePanel>
			    </div>
        </div>
    </div>
</asp:Content>
