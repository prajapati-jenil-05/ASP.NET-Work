<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <br /><br />
        <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                this is view 1<br /><asp:Button ID="btn_next_view1" runat="server" Text="Next" OnClick="btn_next_view1_Click" />
            </asp:View>
            <asp:View ID="Vie2" runat="server">
                this is view 2<br />
                <asp:Button ID="btn_prev_view2" runat="server" Text="Previous" OnClick="btn_prev_view2_Click" />&nbsp
                <asp:Button ID="btn_next_view2" runat="server" Text="Next" OnClick="btn_next_view2_Click" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                this is view 3<br /><asp:Button ID="btn_prev_view3" runat="server" Text="Previous" OnClick="btn_prev_view3_Click" />
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
