<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SetUpPage.aspx.cs" Inherits="SetUpPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    
     <h1>PLEASE SELECT THE COLOR</h1>
    
    <asp:RadioButton ID="RadioButtonLight" runat="server" GroupName="color"  /> LIGHT
<p>
    <asp:RadioButton ID="RadioButtonDark" runat="server" GroupName="color"   /> DARK
</p>
    <p>
        <asp:Button ID="ButtonColor" runat="server" Text="SUBMIT" OnClick="ButtonColor_Click" />

    </p>
 

</asp:Content>

