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
&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Font-Bold="True" Text="Submit" OnClick="btnSubmit_Click" Width="75px" />
    
        &nbsp;
    
        &nbsp;<asp:Button ID="btnReturn" runat="server" Font-Bold="True" Text="Return" OnClick="btnReturn_Click" Width="75px" />
    
        &nbsp;&nbsp;
        <asp:Button ID="btnExit" runat="server" Font-Bold="True" OnClick="btnExit_Click" Text="Exit" Width="75px" />
    
        <br />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
