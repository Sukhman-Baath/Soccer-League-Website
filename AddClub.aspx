<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddClub.aspx.cs" Inherits="AddClubs" %>

<%@ Register src="WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <uc1:WebUserControl ID="WebUserControl1" runat="server" />
    <p>
   
    <p>
    <asp:Label ID="Label1" runat="server" Text="REGISTRATION NUMBER"></asp:Label>
    <asp:TextBox ID="RegistrationTextBox" runat="server" BackColor="#CCFFFF" Text='<%# Bind("clubRegistrationNumber") %>'   
         Width="358px"></asp:TextBox>
     
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="PLEASE ENTER REGISTRATION NUMBER" ControlToValidate="RegistrationTextBox"></asp:RequiredFieldValidator>
        
        
    
    </p>

    <p>
    <asp:Label ID="Label2" runat="server" Text="ADDRESS"></asp:Label>

    <asp:TextBox ID="AddressTextBox" runat="server" BackColor="#CCFFFF" Text='<%# Bind("clubAddress") %>' style="margin-left: 171px" Width="361px"></asp:TextBox>
    </p>

    <asp:Label ID="Label6" runat="server" Visible=false   Text="Label"></asp:Label>

    <p>
    <asp:Button ID="SaveClubButton" runat="server" Text="SAVE CLUB" OnClick="SaveClubButton_Click" />
        <asp:Button ID="CancelButton" runat="server" OnClick="CancelButton_Click" style="margin-left: 276px" Text="CANCEL" Width="140px" />
</p>
    <p>
        <asp:Button ID="AddPlayerButton" runat="server" Text="ADD PLAYER" Visible="false" style="margin-left: 386px" Width="359px" OnClick="AddPlayerButton_Click" BackColor="#CCCCCC" BorderColor="Black" ForeColor="Black" />
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="PLAYER NAME" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxPlayerName" runat="server" Visible="false" style="margin-left: 68px" Width="254px" BackColor="#CCFFFF"></asp:TextBox>
       
        
     </p>
        <p>
            &nbsp;<asp:Label ID="Label4" runat="server" Text="DATE OF BIRTH" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxDOB" runat="server" Visible="false" style="margin-left: 65px" Width="248px" BackColor="#CCFFFF"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButtonCalender" runat="server" Height="31px" ImageUrl="~/calendar.png" Visible="false" OnClick="ImageButtonCalender_Click" style="margin-top: 0px" Width="34px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
    <p>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged" Width="220px">
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
        <asp:Label ID="Label5" runat="server" Text="JERSEY NUMBER" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxJersey" runat="server" Visible="false" style="margin-left: 50px" Width="261px" BackColor="#CCFFFF"></asp:TextBox>
       
     
    <asp:RangeValidator ID="RangeValidatorJerseyNumber" runat="server" ErrorMessage="JERSEY NUMBER MUST BE BETWEEN 0 & 99" ControlToValidate="TextBoxJersey" MinimumValue="0" MaximumValue="99" Type="Integer"></asp:RangeValidator>
      </p>
    
    <p>
        <asp:Button ID="SubmitPlayerButton" runat="server" Text="SAVE PLAYER" Visible="false" BackColor="#999999" OnClick="SubmitPlayerButton_Click" Width="280px" />

        <asp:Button ID="CancelPlayerButton" runat="server" Text="CANCEL" Visible="false" BackColor="#999999" OnClick="CancelPlayerButton_Click" style="margin-left: 481px" Width="290px" />

    </p>

    

</asp:Content>

