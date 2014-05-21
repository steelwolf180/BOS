<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ASPNetFileUpDownLoad.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align=center>
    
        <br />
        <asp:Image ID="Image1" runat="server" 
            ImageUrl="http://www.btw.com.sg/BTWlogo.jpg" />
        <br />


    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<br />
        <asp:Label ID="lblUsername" runat="server" Text="Username:" 
            style="text-align: center"></asp:Label>
&nbsp;<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblpassword" runat="server" Text="Password:"></asp:Label>
&nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCompany" runat="server" Text="Company:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCompany" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblHP" runat="server" Text="HP:"></asp:Label>
&nbsp;<asp:TextBox ID="txtHP" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRegister" runat="server" Text="Register" 
            onclick="btnSubmit_Click" />
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReturn" runat="server" onclick="btnReturn_Click" 
            Text="Return" />
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
