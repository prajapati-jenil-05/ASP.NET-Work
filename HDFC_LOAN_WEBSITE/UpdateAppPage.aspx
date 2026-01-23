<%@ Page Title="" Language="C#" MasterPageFile="~/LoanMaster.master" AutoEventWireup="true" CodeFile="UpdateAppPage.aspx.cs" Inherits="UpdateAppPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .error-text { color: red; font-size: 0.9em; }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:ValidationSummary ID="valSummary" runat="server" ValidationGroup="UpdateGroup" ForeColor="Red" HeaderText="Please fix the following errors:" />

    <table>
        <tr>
            <td>Loan No.: </td>
            <td>
                <asp:TextBox ID="txtLoanNo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLoanNo" runat="server" 
                    ControlToValidate="txtLoanNo" 
                    ErrorMessage="Loan Number is required." 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="SearchGroup">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Button ID="btnGetLoanDetails" runat="server" Text="Get Loan Details" 
                    OnClick="btnGetLoanDetails_Click" 
                    ValidationGroup="SearchGroup" CausesValidation="true" />
            </td>
        </tr>
        <tr>
            <td>Saving Account No.: </td>
            <td>
                <asp:TextBox ID="txtSavingAcctNo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvAcctNo" runat="server" 
                    ControlToValidate="txtSavingAcctNo" 
                    ErrorMessage="Account No is required" 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="UpdateGroup">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revAcctNo" runat="server" 
                    ControlToValidate="txtSavingAcctNo" 
                    ErrorMessage="Invalid Account No" 
                    ValidationExpression="^\d+$" 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="UpdateGroup">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Account Holder Name: </td>
            <td>
                <asp:TextBox ID="txtSavingAcctName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                    ControlToValidate="txtSavingAcctName" 
                    ErrorMessage="Name is required" 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="UpdateGroup">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Loan Category: </td>
            <td>
                <asp:DropDownList ID="ddlLoanCategory" runat="server">
                    <asp:ListItem Value="">-- Select --</asp:ListItem>
                    <asp:ListItem>Property Loan</asp:ListItem>
                    <asp:ListItem>Gold Loan</asp:ListItem>
                    <asp:ListItem>Personal Loan</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvCategory" runat="server" 
                    ControlToValidate="ddlLoanCategory" 
                    InitialValue="" 
                    ErrorMessage="Select a Category" 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="UpdateGroup">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Loan Type: </td>
            <td>
                <asp:DropDownList ID="ddlLoanType" runat="server">
                    <asp:ListItem Value="">-- Select --</asp:ListItem>
                    <asp:ListItem>Education Loan</asp:ListItem>
                    <asp:ListItem>Home Loan</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvType" runat="server" 
                    ControlToValidate="ddlLoanType" 
                    InitialValue="" 
                    ErrorMessage="Select a Type" 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="UpdateGroup">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Loan Issue Date: </td>
            <td>
                <asp:TextBox ID="txtLoanDate" runat="server" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDate" runat="server" 
                    ControlToValidate="txtLoanDate" 
                    ErrorMessage="Date is required" 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="UpdateGroup">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Loan Amount: </td>
            <td>
                <asp:TextBox ID="txtLoanAmmount" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvAmount" runat="server" 
                    ControlToValidate="txtLoanAmmount" 
                    ErrorMessage="Amount is required" 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="UpdateGroup">*</asp:RequiredFieldValidator>
                 <asp:CompareValidator ID="cvAmount" runat="server" 
                    ControlToValidate="txtLoanAmmount" 
                    Type="Currency" Operator="DataTypeCheck" 
                    ErrorMessage="Amount must be a number" 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="UpdateGroup">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>Current Address: </td>
            <td>
                <asp:TextBox ID="txtCurrAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvAddress" runat="server" 
                    ControlToValidate="txtCurrAddress" 
                    ErrorMessage="Address is required" 
                    ForeColor="Red" Display="Dynamic" 
                    ValidationGroup="UpdateGroup">*</asp:RequiredFieldValidator>
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
        <asp:Button ID="btnSubmit" runat="server" Text="Update Application" 
            OnClick="btnSubmit_Click" 
            ValidationGroup="UpdateGroup" CausesValidation="true" />
    </center>
</asp:Content>