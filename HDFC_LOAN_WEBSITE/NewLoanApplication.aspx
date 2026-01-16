<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewLoanApplication.aspx.cs" Inherits="NewLoadApplication" %>

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
            <asp:Label ID="lblUser" runat="server"></asp:Label>
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
            <table>
                <tr>
                    <td>Saving Account No.: </td>
                    <td>
                        <asp:TextBox ID="txtSavingAcctNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Account Holder Name: </td>
                    <td>
                        <asp:TextBox ID="txtSavingAcctName" runat="server" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Loan Category: </td>
                    <td>
                        <asp:DropDownList ID="ddlLoanCategory" runat="server">
                            <asp:ListItem>Property Loan</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Loan Type: </td>
                    <td>
                        <asp:DropDownList ID="ddlLoanType" runat="server">
                            <asp:ListItem>Education Loan</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Loan Issue Date: </td>
                    <td>
                        <asp:TextBox ID="txtLoanDate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Loan Amount: </td>
                    <td>
                        <asp:TextBox ID="txtLoanAmmount" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Current Address: </td>
                    <td>
                        <asp:TextBox ID="txtCurrAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Remarks</td>
                    <td>
                        <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <center>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit Application" /></center>
            <hr />
            <h2>Contact Us: </h2>
            <h3>HDFC Loan Systems</h3>
            <h3>Mumbai, Maharastra, India</h3>
        </div>
    </form>
</body>
</html>
