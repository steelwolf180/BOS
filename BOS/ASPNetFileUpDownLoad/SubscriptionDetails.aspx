<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubscriptionDetails.aspx.cs" Inherits="ASPNetFileUpDownLoad.SubscriptionDetails" %>

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
    <div align="center">
    
        <br />
        <span class="auto-style1"><strong>Please Enter Your Keywords Below<br />
        </strong></span>
        <br />
        <asp:Label ID="lblKeyword1" runat="server" Font-Bold="True" Text="Keyword 1:"></asp:Label>
        <asp:TextBox ID="tbKW1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword2" runat="server" Font-Bold="True" Text="Keyword 2:"></asp:Label>
        <asp:TextBox ID="tbKW2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword3" runat="server" Font-Bold="True" Text="Keyword 3:"></asp:Label>
        <asp:TextBox ID="tbKW3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnReturn" runat="server" Font-Bold="True" Text="Return" OnClick="btnReturn_Click" />
&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Font-Bold="True" Text="Submit" OnClick="btnSubmit_Click" />
    
    </div>
    </form>
</body>
</html>
