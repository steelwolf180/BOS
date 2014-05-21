<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="ASPNetFileUpDownLoad.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.Net Up & Download Files</title>
    <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="frmDefault" enctype="multipart/form-data" runat="server">
<div style="width: 1058px" align='center'>
    <div style="margin-top: 5px; clear: both; width: 810px; margin-left: 168px;">
        <strong>User</strong>:
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <input type="file" name="fileInput" style="margin-left: 0px" />
        <asp:Button ID="btnUpload" Text="Upload File" runat="server" 
            onclick="btnUpload_Click" Height="23px" Width="86px" />
        &nbsp;<asp:GridView ID="gvFiles" CssClass="GridViewStyle" runat="server" 
            Width="811px" CellPadding="4" ForeColor="#333333" 
            GridLines="None" >
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle CssClass="GridViewFooterStyle" BackColor="#507CD1" 
                Font-Bold="True" ForeColor="White" />
            <RowStyle CssClass="GridViewRowStyle" BackColor="#EFF3FB" />    
            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" BackColor="#D1DDF1" 
                Font-Bold="True" ForeColor="#333333" />
            <PagerStyle CssClass="GridViewPagerStyle" BackColor="#2461BF" ForeColor="White" 
                HorizontalAlign="Center" />
            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" BackColor="White" />
            <HeaderStyle CssClass="GridViewHeaderStyle" BackColor="#507CD1" 
                Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink runat="server"
                            NavigateUrl='<%# Eval("ID", "GetFile.aspx?ID={0}") %>'
                            Text="Download"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
        <asp:Button ID="DeleteUser" runat="server" Font-Bold="True" OnClick="DeleteUser_Click" Text="Delete User" />
&nbsp;<asp:Button ID="btnExit" runat="server" Font-Bold="True" 
            onclick="btnExit_Click" Text="Exit" Width="81px" />
    </div>
</div>
</form>
</body>
</html>
