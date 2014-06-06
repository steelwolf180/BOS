<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Download.aspx.cs" Inherits="ASPNetFileUpDownLoad.Download" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #gvFiles 
{
	width: 400px;
            }

.GridViewStyle
{    
    border-right: 2px solid #A7A6AA;
    border-bottom: 2px solid #A7A6AA;
    border-left: 2px solid white;
    border-top: 2px solid white;
    padding: 4px;
}

.GridViewHeaderStyle
{
    background-color: #5D7B9D;
    font-weight: bold;
    text-align: left;
    color: White;
}

.GridViewHeaderStyle th
{
    border-left: 1px solid #EBE9ED;
    border-right: 1px solid #EBE9ED;
}

.GridViewRowStyle
{
    background-color: #F7F6F3;
    color: #333333;
}

.GridViewRowStyle td, .GridViewAlternatingRowStyle td
{
    border: 1px solid #EBE9ED;
}

.GridViewStyle a
{
    color: Blue;
}

.GridViewAlternatingRowStyle 
{
    background-color: #FFFFFF;
    color: #284775;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p style="text-align: center">                  <strong>Welcome</strong><br>

        <asp:Image ID="Image1" runat="server" 
            ImageUrl="http://www.btw.com.sg/BTWlogo.jpg" />

    </p>
        <p style="text-align: center">                  &nbsp;Please click and download your daily update of GeBiz opportunities 
    </p>
&nbsp;<div align = center>
        <asp:GridView ID="gvFiles" CssClass="GridViewStyle"
            AutoGenerateColumns="true" runat="server">
            <FooterStyle CssClass="GridViewFooterStyle" />
            <RowStyle CssClass="GridViewRowStyle" />
            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
            <PagerStyle CssClass="GridViewPagerStyle" />
            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
            <HeaderStyle CssClass="GridViewHeaderStyle" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink runat="server"
                            NavigateUrl='<%# Eval("ID", "GetFile.aspx?ID={0}") %>'
                            Text="Download"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            <br />
            <asp:Button ID="btnRenewal" runat="server" Font-Bold="True" OnClick="btnRenewal_Click" Text="Subscription Renewal" Visible="False" />
            <br />
            <br />
            <asp:Button ID="btnExit" runat="server" Font-Bold="True" 
                onclick="btnExit_Click" Text="Exit" />
        </div>
    </div>
    </form>
</body>
</html>
