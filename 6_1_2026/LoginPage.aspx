<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <h1>User Login</h1>
            <div>
                <table>
                    <tr>
                        <td>Email: </td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>Password: </td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <div style="color: red">
                                <asp:Label ID="lblSignInError" runat="server" Text=""></asp:Label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnSignIn" runat="server" Text="Sign in" OnClick="btnSignIn_Click" />
                            &nbsp;   
                <asp:Button ID="btnReset" runat="server" Text="Reset" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: right;">
                            <asp:LinkButton ID="btnRegister" runat="server">Register</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </div>
        </center>
    </form>
</body>
</html>
