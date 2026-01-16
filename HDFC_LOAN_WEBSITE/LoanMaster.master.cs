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
            Response.Redirect("login.aspx"); // to move to the another page
        }
        string email = Session["Email"].ToString(); // to retrieve the email from session variable
        lblUser.Text = email; // to display the welcome message
    }
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        if (Session["Email"] == null)
        {
            Response.Redirect("login.aspx"); // to move to the another page
        }
        Session["Email"] = null;
        Response.Redirect("login.aspx"); // to move to the another page
    }

    protected void btnNewApp_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewAppPage.aspx"); // to move to the another page
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
