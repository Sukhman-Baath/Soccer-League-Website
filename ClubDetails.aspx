<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ClubDetails.aspx.cs" Inherits="ClubDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h1>CLUB DETAILS</h1>
    <asp:GridView ID="GridViewClub" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
    </asp:GridView>
    <p>
        <asp:LinkButton ID="DeleteButton"  Text="DELETE CLUB"
            CommandArgument = <%#Eval("ClubRegistrationNo") %> CommandName="DeleteClub" runat="server" OnClick="DeleteButton_Click1" />
        </p>
    

    <h1> PLAYERS IN CLUB</h1>
   
    
        
      
    <asp:DataList runat="server" id ="playerList" OnItemCommand="playerList_ItemCommand" CellPadding="4" ForeColor="#333333" >
        <AlternatingItemStyle BackColor="White" />
        <EditItemTemplate>
            Name:
            <asp:TextBox ID="nameTextBox" runat="server" Text=<%# Eval("PlayerName") %>/>
            <br />
            DateOfBirth:
            <asp:TextBox ID="dobTextBox" runat="server" Text='<% # Eval("DOB", "{0:dd/MM/yyyy}") %>'  />
                
            <br />
            JerseyNo:
            <asp:TextBox ID="jerseyTextBox" runat="server" Text=<%# Eval("JerseyNo") %> />
            <br />
            
            <asp:LinkButton ID="updateButton" runat="server" CommandArgument=<%# Eval("PlayerId") %> CommandName="UpdateItem" Text="Update Item" />
            &nbsp;or
            <asp:LinkButton ID="cancelButton" runat="server" CommandArgument=<%# Eval("PlayerId") %> CommandName="CancelEditing" Text="Cancel Editing"/>
        </EditItemTemplate>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
        <ItemTemplate>
            <asp:Literal ID="extraDetailsLiteral" runat="server" EnableViewState="False"></asp:Literal>
            Name: <strong><%# Eval("PlayerName") %> </strong><br />
            DateOfBirth: <strong><%# Eval("DOB","{0:dd/MM/yyyy}") %>    </strong> <br />
            JerseyNo: <strong><%# Eval("JerseyNo") %>
            <br />
            </strong>

           
            <asp:LinkButton ID="editButton" runat="server" 
                Text=<%# "Edit player " + Eval("PlayerName")%> 
                CommandArgument=<%# Eval("PlayerId") %>
                CommandName="EditItem"
                />
        </ItemTemplate>
       <%-- <SeparatorTemplate>
            <hr />
        </SeparatorTemplate>--%>
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>
    
   
          
            
    
   







    <asp:Label ID="ErrorLabel" Visible="false" runat="server" Text="Label"></asp:Label>
    </asp:Content>



