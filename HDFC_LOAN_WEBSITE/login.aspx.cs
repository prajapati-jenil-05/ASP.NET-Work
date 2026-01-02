using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text == "" || txtPassword.Text == "")
        {
            lblSignInError.Text = "Enter both email and password!";
        }
        else
        {
            Session["Email"] = txtEmail.Text; // to store the email in session variable
            Response.Redirect("HomePage.aspx"); // to move to the another page
        }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtEmail.Text = "";
        txtPassword.Text = "";
    }
}