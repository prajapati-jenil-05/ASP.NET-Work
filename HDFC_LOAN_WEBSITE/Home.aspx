<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>HDFS Loans - Next Step to Dream</h1>
            </center>
            <br />
            <hr />
            Logged In:
                <asp:Label ID="lblUser" runat="server">dkanzariya172@rku.ac.in</asp:Label>
            <div style="float: right;">
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
            </div>

            <hr />
            <table>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbtnHome" runat="server" OnClick="lbtnHome_Click">Home</asp:LinkButton></td>
                    <td></td>
                    <td>
                        <asp:LinkButton ID="lbtnNewApp" runat="server" OnClick="btnNewApp_Click">New Application</asp:LinkButton>
                    </td>
                    <td></td>
                    <td>
                        <asp:LinkButton ID="lbtnUpdtApp" runat="server" OnClick="lbtnUpdtApp_Click">Update Application</asp:LinkButton>
                    </td>
                    <td></td>
                    <td>
                        <asp:LinkButton ID="lbtnRemoveApp" runat="server" OnClick="lbtnRemoveApp_Click">Remove Application</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <hr />
            <b>
                <h2>Welcome to place to fulfill your dreams for the family and social needs.</h2>
            </b>
            <hr />
            <h2>Contact Us: </h2>
            <h3>HDFC Loan Systems</h3>
            <h3>Mumbai, Maharastra, India</h3>
        </div>
    </form>
</body>
</html>
