<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPNetFileUpDownLoad.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align=center>
    
        <asp:Image ID="Image1" runat="server" 
            ImageUrl="http://www.btw.com.sg/BTWlogo.jpg" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblName" runat="server" Text="Name: " Font-Bold="True" 
            ForeColor="Black"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password: " Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" 
            Text="Login" Font-Bold="True" Width="69px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRegister" runat="server" Font-Bold="True" 
            onclick="btnRegister_Click" Text="Register" />
        <br />
        <br />
&nbsp;
        <asp:Button ID="btnRecovery" runat="server" onclick="btnRecovery_Click" 
            Text="Password Recovery" Font-Bold="True" Height="30px" 
            style="margin-top: 0px" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label>
    
    </div>
    </form>
</body>
</html>
