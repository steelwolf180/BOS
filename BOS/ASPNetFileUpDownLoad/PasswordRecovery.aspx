<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordRecovery.aspx.cs" Inherits="ASPNetFileUpDownLoad.PasswordRecovery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Image ID="Image1" runat="server" 
            ImageUrl="http://www.btw.com.sg/BTWlogo.jpg" />
        <br />
    
        Please enter your username or email so we could send the email to you.<br />
        <br />
        <asp:Label ID="lblName" runat="server" Text="User:"></asp:Label>
&nbsp;<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;Or<br />
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSend" runat="server" onclick="btnSend_Click" Text="Send" 
            Font-Bold="True" />
&nbsp;&nbsp;
        <asp:Button ID="btnReturn" runat="server" onclick="btnReturn_Click" 
            Text="Return" Font-Bold="True" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label>
    
    </div>
    </form>
</body>
</html>
