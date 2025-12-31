<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h3>Validation Control Demo</h3>
                <table style="text-align: left">
                    <tr>
                        <td>
                            <asp:Label ID="lblName" runat="server" Text="Name: " />
                        </td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter you name!" ControlToValidate="txtName" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblAge" runat="server" Text="Age: " />
                        </td>
                        <td>
                            <asp:TextBox ID="txtAge" runat="server" />
                        </td>
                        <td>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age must be greater than 18!" ControlToValidate="txtAge" ForeColor="Red" MaximumValue="40" MinimumValue="18" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblEmail" runat="server" Text="Email: " />
                        </td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" />
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter valid email address!" ControlToValidate="txtEmail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblPasswd" runat="server" Text="Password: " />
                        </td>
                        <td>
                            <asp:TextBox ID="txtPasswd" runat="server" TextMode="Password" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter the password!" ControlToValidate="txtPasswd" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblConfPasswd" runat="server" Text="Confirm Password: " />
                        </td>
                        <td>
                            <asp:TextBox ID="txtConfPasswd" runat="server" TextMode="Password" />
                        </td>
                        <td>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password does not match!" ControlToCompare="txtPasswd" ControlToValidate="txtConfPasswd" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Button" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblNumber" runat="server" Text="Number: " />
                        </td>
                        <td>
                            <asp:TextBox ID="txtNumber" runat="server" />
                        </td>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>
</html>
