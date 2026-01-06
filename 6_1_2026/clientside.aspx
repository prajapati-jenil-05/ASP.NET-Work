<%@ Page Language="C#" AutoEventWireup="true" CodeFile="clientside.aspx.cs" Inherits="clientside" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View State Example
            <br />
            <asp:TextBox ID="txtViewState" runat="server" OnTextChanged="txtViewState_TextChanged"></asp:TextBox>
            <asp:Label ID="lblViewState" runat="server" Text=""></asp:Label>
            <br /><br />

            Hidden Field Example
            <br />
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <asp:Button ID="btnHidden" runat="server" Text="Show Hidden Value" OnClick="btnHidden_Click" />
            <asp:Label ID="lblHiddenField" runat="server" Text=""></asp:Label>
            <br /><br />

            Cookie Example
            <br />
            <asp:TextBox ID="txtCookie" runat="server"></asp:TextBox>
            <asp:Button ID="btnCreateCookie" runat="server" Text="Create Cookie" OnClick="btnCreateCookie_Click" />
            <asp:Button ID="btnReadCookie" runat="server" Text="Read Cookie" OnClick="btnReadCookie_Click" />
            <asp:Label ID="lblCookie" runat="server" Text=""></asp:Label>
            <br /><br />

            Query Example
            <br />
            <asp:TextBox ID="txtQueryString" runat="server"></asp:TextBox>
            <asp:Button ID="btnSendQueryString" runat="server" Text="Send via Query String" OnClick="btnSendQueryString_Click" />
            <asp:Label ID="lblQuery" runat="server" Text="Query Label"></asp:Label>
        </div>
    </form>
</body>
</html>
