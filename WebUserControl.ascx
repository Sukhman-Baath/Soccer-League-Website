<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>

<p>
    <asp:Label ID="Label1" runat="server" Text="CLUB NAME"></asp:Label>
<asp:TextBox ID="NameTextBox" runat="server" style="margin-left: 151px" Width="354px" BackColor="#CCFFFF" Text='<%# Bind("clubName") %>'></asp:TextBox>

<asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" ErrorMessage="ENTER NAME" ControlToValidate="NameTextBox"></asp:RequiredFieldValidator>
</p>

<asp:Label ID="Label2" runat="server" Text="CLUB CITY"></asp:Label>
<asp:TextBox ID="CityTextBox" runat="server" style="margin-left: 162px" Width="353px" BackColor="#CCFFFF" Text='<%# Bind("clubCity") %>'></asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidatorCity" runat="server" ErrorMessage="PLEASE ENTER CITY" ControlToValidate="CityTextBox"></asp:RequiredFieldValidator>




            