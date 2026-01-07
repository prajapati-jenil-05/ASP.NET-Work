using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class clientside : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["username"] != null)
        {
            lblUsername.Text = "Welcome: " + Request.Cookies["username"].Value;
        }
        else
        {
            lblUsername.Text = "Username not found!";
        }
    }

    protected void txtViewState_TextChanged(object sender, EventArgs e)
    {
        int count = 0;
        if (ViewState["Clicks"] != null)
        {
            count = (int)ViewState["Clicks"];
        }
        count++;
        ViewState["Clicks"] = count;
        lblViewState.Text = "Text Clicked: " + count.ToString();
    }

    protected void btnHidden_Click(object sender, EventArgs e)
    {
        HiddenField1.Value = "46";
        lblHiddenField.Text = "Hidden Field Value: " + HiddenField1.Value;
    }

    protected void btnCreateCookie_Click(object sender, EventArgs e)
    {
        //HttpCookie cookie = new HttpCookie("myCookie");
        Response.Cookies["myCookie"].Value = txtCookie.Text;
        Response.Cookies["myCookie"].Expires = DateTime.Now.AddSeconds(3);
        //Response.Cookies.Add(cookie);
        lblCookie.Text = "Cookie Created!";
    }


    protected void btnReadCookie_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["myCookie"] != null)
        {
            lblCookie.Text = "Cookie Value: " + Request.Cookies["myCookie"].Value;
        }
        else
        {
            lblCookie.Text = "Cookie not found!";
        }
    }

    protected void btnSendQueryString_Click(object sender, EventArgs e)
    {
        Response.Redirect("/clientside.aspx?data="+txtQueryString.Text);
    }
}