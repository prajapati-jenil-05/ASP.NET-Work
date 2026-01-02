<%@ Page Title="" Language="C#" MasterPageFile="~/LoanMaster.master" AutoEventWireup="true" CodeFile="UpdateAppPage.aspx.cs" Inherits="UpdateAppPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>
    <tr>
        <td>Loan No.: </td>
        <td>
            <asp:TextBox ID="txtLoanNo" runat="server"></asp:TextBox></td>
        <td>
            <asp:Button ID="btnGetLoanDetails" runat="server" Text="Get Loan Details" /></td>
    </tr>
    <tr>
        <td>Saving Account No.: </td>
        <td>
            <asp:TextBox ID="txtSavingAcctNo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Account Holder Name: </td>
        <td>
            <asp:TextBox ID="txtSavingAcctName" runat="server"></asp:TextBox>
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
    <asp:Button ID="btnSubmit" runat="server" Text="Update Application" /></center>
</asp:Content>

