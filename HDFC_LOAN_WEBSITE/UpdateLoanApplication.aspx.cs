using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateLoanApplication : System.Web.UI.Page
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
        Session["Email"] = null;
        Response.Redirect("login.aspx"); // to move to the another page/
    }
    protected void btnNewApp_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewLoanApplication.aspx"); // to move to the another page
    }

    protected void lbtnUpdtApp_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateLoanApplication.aspx");
    }
    protected void lbtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void lbtnRemoveApp_Click(object sender, EventArgs e)
    {
        Response.Redirect("RemoveLoanApplication.aspx");
    }
}