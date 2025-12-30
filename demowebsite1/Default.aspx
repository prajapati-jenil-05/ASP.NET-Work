<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Ans" runat="server" Text="Ans"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Result" runat="server" Text="Result"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="Button1_Click" Width="58px" />
            &nbsp
            <asp:Button ID="btnSub" runat="server" Text="Sub" OnClick="btnSub_Click" />
            &nbsp
            <asp:Button ID="btnmul" runat="server" Text="mul" OnClick="Button3_Click" />
            &nbsp
            <asp:Button ID="btndiv" runat="server" Text="div" OnClick="Button4_Click" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Reset" />
        </p>
    </form>
    <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile2.xml" />
    <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/XMLFile2.xml" />
    <asp:AdRotator ID="AdRotator3" runat="server" AdvertisementFile="~/XMLFile2.xml" />
    <asp:AdRotator ID="AdRotator4" runat="server" AdvertisementFile="~/XMLFile2.xml" />
    <asp:AdRotator ID="AdRotator5" runat="server" AdvertisementFile="~/XMLFile2.xml" />
    <asp:AdRotator ID="AdRotator6" runat="server" AdvertisementFile="~/XMLFile2.xml" />

    <asp:AdRotator ID="AdRotator7" runat="server" AdvertisementFile="~/XMLFile2.xml" />

    <asp:AdRotator ID="AdRotator8" runat="server" AdvertisementFile="~/XMLFile2.xml" />

    <asp:AdRotator ID="AdRotator9" runat="server" AdvertisementFile="~/XMLFile2.xml" />

    <asp:AdRotator ID="AdRotator10" runat="server" AdvertisementFile="~/XMLFile2.xml" />

    <asp:AdRotator ID="AdRotator11" runat="server" AdvertisementFile="~/XMLFile2.xml" />

    <asp:AdRotator ID="AdRotator12" runat="server" AdvertisementFile="~/XMLFile2.xml" />

</body>
</html>
