using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "You selected: " + Calendar1.SelectedDate.ToString("dd-MM-yyyy");
    }

    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {

    }

    protected void btn_next_view1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }

    protected void btn_prev_view2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }

    protected void btn_next_view2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }

    protected void btn_prev_view3_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
}