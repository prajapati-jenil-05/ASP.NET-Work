using System;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient; 
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["Email"] = null;
        }
    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
        {
            lblSignInError.Text = "Enter both email and password!";
            return; 
        }

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Window Application\\ASP.NET-Work\\HDFC_LOAN_WEBSITE\\App_Data\\HDFC_Database.mdf\";Integrated Security=True";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(1) FROM Users WHERE UserEmail = @UserEmail AND Password = @Password";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserEmail", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["Email"] = txtEmail.Text.Trim();
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    lblSignInError.Text = "Invalid Email or Password.";
                }
            }
        }
    } 

    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtEmail.Text = "";
        txtPassword.Text = "";
        lblSignInError.Text = "";
    }
}