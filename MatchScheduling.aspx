<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MatchScheduling.aspx.cs" Inherits="MatchScheduling" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <h1 style="background-color: #C0C0C0; font-family: Georgia">SCHEDULE YOUR MATCHES</h1>
    <p style="font-family: Georgia; background-color: #C0C0C0" >
        SELECT HOST CLUB
        <asp:DropDownList ID="DropDownList1" runat="server" Width="174px"></asp:DropDownList>

    </p>
    <p style="font-family: Georgia; background-color: #C0C0C0">
        SELECT GUEST CLUB
        <asp:DropDownList ID="DropDownList2" runat="server" Width="159px"></asp:DropDownList>

    </p>

    <p style="font-family: Georgia; background-color: #C0C0C0">
        <asp:Label ID="DateLabel" runat="server" Text="SELECT DATE"></asp:Label>

        <asp:TextBox ID="DateTextBox" runat="server" ForeColor="#999999" Width="241px"></asp:TextBox>
        <asp:ImageButton ID="ImageButtonCalender" runat="server" Height="31px" ImageUrl="~/calendar.png"
            OnClick="ImageButtonCalenderClick" style="margin-top: 0px" Width="59px" />
            
    </p>
    
     <p>
        <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#3366CC" 
            BorderWidth="1px" CellPadding="1" Font-Names="Verdana" 
            Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="Calendar2_SelectionChanged" Width="220px" OnDayRender="Calendar2_DayRender">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
            
            </p>
    <p>
        <asp:Button ID="MatchButton" runat="server" Text="Schedule Match" OnClick="MatchButton_Click" ForeColor="#000099" Width="429px" />
           
   
    </p>
    
   <h1 style="font-family: Georgia; background-color: #C0C0C0">
       SCHEDULED MATCHES
   </h1> 
    <p>
        <asp:GridView ID="GridViewMatch"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
           <Columns>
          
           <asp:boundfield HeaderText="MatchId" datafield="MatchId"/>
                <asp:boundfield HeaderText="HostClub" datafield="HostClub" />
                <asp:boundfield HeaderText="GuestClub" datafield="GuestClub"  />
                <asp:boundfield HeaderText="MatchDate" datafield="MatchDate" dataformatstring="{0:MM/dd/yyyy}" />
               </Columns>
            
        </asp:GridView>
    
           
        
    </p>
   

    <asp:Label ID="Label11" runat="server" Visible="false" Text="Label"></asp:Label>

</asp:Content>

