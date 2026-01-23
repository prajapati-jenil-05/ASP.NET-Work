using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoanMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Email"] == null)
        {
            Response.Redirect("login.aspx");
        }
        string email = Session["Email"].ToString();
        lblUser.Text = email;
    }
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        if (Session["Email"] == null)
        {
            Response.Redirect("login.aspx");
        }
        Session["Email"] = null;
        Response.Redirect("login.aspx");
    }

    protected void btnNewApp_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewAppPage.aspx");
    }

    protected void lbtnUpdtApp_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateAppPage.aspx");
    }

    protected void lbtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void lbtnRemoveApp_Click(object sender, EventArgs e)
    {
        Response.Redirect("RemoveAppPage.aspx");
    }

    protected void lbtnViewAll_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewAll.aspx");
    }
}
