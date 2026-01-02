<%@ Page Title="" Language="C#" MasterPageFile="~/LoanMaster.master" AutoEventWireup="true" CodeFile="NewAppPage.aspx.cs" Inherits="NewAppPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td>Saving Account No.: </td>
            <td>
                <asp:TextBox ID="txtSavingAcctNo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Account No. Required" ControlToValidate="txtSavingAcctNo" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Account Holder Name: </td>
            <td>
                <asp:TextBox ID="txtSavingAcctName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Account Name Required" ControlToValidate="txtSavingAcctName" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Loan Category: </td>
            <td>
                <asp:DropDownList ID="ddlLoanCategory" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Home Loan</asp:ListItem>
                    <asp:ListItem>Property Loan</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Loan Category Required" ControlToValidate="ddlLoanCategory" ForeColor="Red" InitialValue="Select" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Loan Type: </td>
            <td>
                <asp:DropDownList ID="ddlLoanType" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Education Loan</asp:ListItem>
                    <asp:ListItem>Home Loan</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="ddlLoanType" ForeColor="Red" InitialValue="Select" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Loan Issue Date: </td>
            <td>
                <asp:TextBox ID="txtLoanDate" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Issue Date Required" ControlToValidate="txtLoanDate" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Loan Amount: </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtLoanAmmount" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Amount must be 50000 to 200000" ControlToValidate="txtLoanAmmount" ForeColor="Red" SetFocusOnError="True"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>Current Address: </td>
            <td>
                <asp:TextBox ID="txtCurrAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Address Required" ControlToValidate="txtCurrAddress" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Remarks</td>
            <td>
                <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Remarks Required" ControlToValidate="txtRemarks" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <center>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit Application" /></center>
</asp:Content>

