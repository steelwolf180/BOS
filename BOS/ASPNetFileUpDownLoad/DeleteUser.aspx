﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="ASPNetFileUpDownLoad.DeleteUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align ="center">
    
        <br />
<span class="auto-style1"><strong>Delete User From Below<br />
        </strong></span>
        <br />
    
        <asp:GridView ID="DGV" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" align="center">
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
        </asp:GridView>
    
       
        <br />
&nbsp;<asp:Label ID="lblID" runat="server" Text="Member ID:" align="center" style="font-weight: 700"></asp:Label>
&nbsp;<asp:TextBox ID="txtMemberID" runat="server" Width="75px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;<asp:Button ID="BtnReturn" runat="server" Font-Bold="True" OnClick="BtnReturn_Click" Text="Return" />
&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Font-Bold="True" OnClick="btnDelete_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnExit" runat="server" Font-Bold="True" OnClick="BtnExit_Click" Text="Exit" Width="70px" />
    
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="#FF3300" Text="                                                           "></asp:Label>
    
    </div>
    </form>
</body>
</html>