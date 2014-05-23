<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Subscription.aspx.cs" Inherits="ASPNetFileUpDownLoad.Subscription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<div align="center">
     <p>&nbsp;</p>
     <p><strong>Please Select The Plans You Want To Subscribe</strong></p>
            <asp:RadioButtonList ID="RBLPlans" runat="server" Font-Bold="True" align="Center">
                <asp:ListItem Value="1">BOS Classic For 6 Months</asp:ListItem>
                <asp:ListItem Value="2">BOS Classic For 12 Months</asp:ListItem>
                <asp:ListItem Value="3">BOS Premium For 6 Months</asp:ListItem>
                <asp:ListItem Value="4">BOS Premium For 12 Months</asp:ListItem>
            </asp:RadioButtonList>
            <br />
&nbsp;<asp:Button ID="btnSubmit" runat="server" Font-Bold="True" OnClick="btnSubmit_Click1" Text="Submit" Width="75px" />
     &nbsp;&nbsp;
     <asp:Button ID="btnReturn" runat="server" Font-Bold="True" OnClick="btnReturn_Click" Text="Return" Width="75px" />
     &nbsp;&nbsp;
     <asp:Button ID="btnExit" runat="server" Font-Bold="True" Text="Exit" Width="75px" />
     <br />
     <br />
     <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </div>
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
