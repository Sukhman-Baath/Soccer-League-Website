<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Clubs.aspx.cs" Inherits="AddClub" %>

<%@ Register Src="~/WebUserControl.ascx" TagPrefix="uc1" TagName="WebUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <a href="AddClub.aspx">ADD COMPLETE CLUB</a>
   
    
    <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
        <uc1:WebUserControl ID="WebUserControl2" runat="server" 
        Name ='<%#Eval("ClubName") %>' 
         City ='<%#Eval("ClubCity") %>' />
    </ItemTemplate>
    
    </asp:Repeater>
    <asp:DataList ID="NameCityDataList" OnItemCommand="NameCity_ItemCommand" runat="server">
        <ItemTemplate>
        <uc1:WebUserControl ID="WebUserControl2" runat="server" 
        Name ='<%#Eval("ClubName") %>' 
         City ='<%#Eval("ClubCity") %>' />

            <asp:LinkButton ID="ViewDetails"  Text="VIEW CLUB DETAILS"
            CommandArgument = <%#Eval("ClubRegistrationNo") %> CommandName="ViewDetails" runat="server" />
    </ItemTemplate>
    
    </asp:DataList>
</asp:Content>


