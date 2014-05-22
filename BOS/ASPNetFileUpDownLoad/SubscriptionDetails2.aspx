<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubscriptionDetails2.aspx.cs" Inherits="ASPNetFileUpDownLoad.SubscriptionDetails" %>

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
        <asp:TextBox ID="tbKeyword1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword2" runat="server" Font-Bold="True" Text="Keyword 2:"></asp:Label>
        <asp:TextBox ID="tbKeyword2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword3" runat="server" Font-Bold="True" Text="Keyword 3:"></asp:Label>
        <asp:TextBox ID="tbKeyword3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword4" runat="server" Font-Bold="True" Text="Keyword 4:"></asp:Label>
        <asp:TextBox ID="tbKeyword4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword5" runat="server" Font-Bold="True" Text="Keyword 5:"></asp:Label>
        <asp:TextBox ID="tbKeyword5" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword6" runat="server" Font-Bold="True" Text="Keyword 6:"></asp:Label>
        <asp:TextBox ID="tbKeyword6" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword7" runat="server" Font-Bold="True" Text="Keyword 7:"></asp:Label>
        <asp:TextBox ID="tbKeyword7" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword8" runat="server" Font-Bold="True" Text="Keyword 8:"></asp:Label>
        <asp:TextBox ID="tbKeyword8" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword9" runat="server" Font-Bold="True" Text="Keyword 9:"></asp:Label>
        <asp:TextBox ID="tbKeyword9" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblKeyword10" runat="server" Font-Bold="True" Text="Keyword 10:"></asp:Label>
        <asp:TextBox ID="tbKeyword10" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnReturn" runat="server" Font-Bold="True" Text="Return" OnClick="btnReturn_Click" />
&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Font-Bold="True" Text="Submit" OnClick="btnSubmit_Click" />
    
    </div>
    </form>
</body>
</html>
