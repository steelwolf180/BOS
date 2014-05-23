<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubscriptionDetails2.aspx.cs" Inherits="ASPNetFileUpDownLoad.SubscriptionDetails2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
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
        <asp:Label ID="lblKeyword4" runat="server" Font-Bold="True" Text="Keyword 4:"></asp:Label>
        <asp:TextBox ID="tbKW4" runat="server"></asp:TextBox>
         <br />
        <asp:Label ID="lblKeyword5" runat="server" Font-Bold="True" Text="Keyword 5:"></asp:Label>
        <asp:TextBox ID="tbKW5" runat="server"></asp:TextBox>
         <br />
        <asp:Label ID="lblKeyword6" runat="server" Font-Bold="True" Text="Keyword 6:"></asp:Label>
        <asp:TextBox ID="tbKW6" runat="server"></asp:TextBox>
         <br />
        <asp:Label ID="lblKeyword7" runat="server" Font-Bold="True" Text="Keyword 7:"></asp:Label>
        <asp:TextBox ID="tbKW7" runat="server"></asp:TextBox>
         <br />
        <asp:Label ID="lblKeyword8" runat="server" Font-Bold="True" Text="Keyword 8:"></asp:Label>
        <asp:TextBox ID="tbKW8" runat="server"></asp:TextBox>
         <br />
        <asp:Label ID="lblKeyword9" runat="server" Font-Bold="True" Text="Keyword 9:"></asp:Label>
        <asp:TextBox ID="tbKW9" runat="server"></asp:TextBox>
         <br />
        <asp:Label ID="lblKeyword10" runat="server" Font-Bold="True" Text="Keyword 10:"></asp:Label>
        <asp:TextBox ID="tbKW10" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Font-Bold="True" Text="Submit" OnClick="btnSubmit_Click" Width="75px" />
    
        &nbsp;
    
        &nbsp;<asp:Button ID="btnReturn" runat="server" Font-Bold="True" Text="Return" OnClick="btnReturn_Click" Width="75px" />
    
        &nbsp;
         <asp:Button ID="btnExit" runat="server" Font-Bold="True" OnClick="btnExit_Click" Text="Exit" Width="75px" />
    
        <br />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
