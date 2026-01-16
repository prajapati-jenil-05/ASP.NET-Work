using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class LoginPage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Window Application\\ASP.NET-Work\\6_1_2026\\App_Data\\Database.mdf\";Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select username, password from RAM where username='"+txtEmail.Text + "' and password ='" + txtPassword.Text + "'", con);
        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Session["username"] = txtEmail.Text;
            Response.Cookies["username"].Value = txtEmail.Text;
            Response.Cookies["username"].Expires = DateTime.Now.AddSeconds(3);
            Response.Redirect("clientside.aspx");
        }
        else
        {
            Response.Write("username and password doesn't match");
        }
    }
}