<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Results" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

     <h1 style="background-color: #C0C0C0; font-family: Georgia">VIEW YOUR RESULTS</h1>
    <p style="font-family: Georgia; background-color: #C0C0C0" >
        SELECT TEAM TO VIEW RESULT
        <asp:DropDownList ID="DropDownListTeam" runat="server" Width="174px"></asp:DropDownList>

    </p>

    <p>
        <asp:Button ID="Button1" runat="server" Text="VIEW RESULTS" OnClick="Button1_Click" />

    </p>


   <p> <asp:GridView ID="GridViewResult" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
       <AlternatingRowStyle BackColor="White" />
       <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
       <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
       <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
       <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
       <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
       <SortedAscendingCellStyle BackColor="#FDF5AC" />
       <SortedAscendingHeaderStyle BackColor="#4D0000" />
       <SortedDescendingCellStyle BackColor="#FCF6C0" />
       <SortedDescendingHeaderStyle BackColor="#820000" />
        <Columns>
          
           <asp:boundfield HeaderText="ResultId" datafield="ResultId"/>
                <asp:boundfield HeaderText="WinnerTeam" datafield="WinnerTeam" />
                <asp:boundfield HeaderText="LooserTeam" datafield="LooserTeam"  />
                <asp:boundfield HeaderText="DateOfMatch" datafield="DateOfMatch" dataformatstring="{0:MM/dd/yyyy}" />
               </Columns>
       </asp:GridView>
</p>
    <p>
        UPDATE THE RESULTS
    </p>
    <p  style="font-family: Georgia; background-color: #C0C0C0">
        WINNER TEAM
        <asp:DropDownList ID="DropDownList2" runat="server" Width="159px"></asp:DropDownList>>
        


    </p>
    
        
         <p style="font-family: Georgia; background-color: #C0C0C0">
        LOOSER TEAM
        <asp:DropDownList ID="DropDownList3" runat="server" Width="159px"></asp:DropDownList>

    

    </p>
     <p style="font-family: Georgia; background-color: #C0C0C0">
        <asp:Label ID="DateLabel" runat="server" Text="SELECT DATE"></asp:Label>

        <asp:TextBox ID="DateTextBox" runat="server" ForeColor="#999999" Width="241px"></asp:TextBox>
        <asp:ImageButton ID="ImageButtonCalender" runat="server" Height="31px" ImageUrl="~/calendar.png"
            OnClick="ImageButtonCalenderClick" style="margin-top: 0px" Width="59px" />
            
    </p>
     <p>
         
         <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px"  OnSelectionChanged="Calendar1_SelectionChanged" ShowGridLines="True" Width="220px">
             <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
             <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
             <OtherMonthDayStyle ForeColor="#CC9966" />
             <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
             <SelectorStyle BackColor="#FFCC66" />
             <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
             <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
         </asp:Calendar>
        
            
        
            
            <asp:Button ID="Button2" runat="server" Text="UPDATE RESULT" Width="151px" OnClick="Button2_Click" />
        
            
        
            
            </p>





</asp:Content>