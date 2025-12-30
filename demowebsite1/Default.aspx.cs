using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        int no1 = Convert.ToInt32(TextBox1.Text);
        int no2 = Convert.ToInt32(TextBox2.Text);
        int r = no1 / no2;
        Result.Text = r.ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int no1 = Convert.ToInt32(TextBox1.Text);
        int no2 = Convert.ToInt32(TextBox2.Text);
        int r = no1 * no2;
        Result.Text = r.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int no1 = Convert.ToInt32(TextBox1.Text);
        int no2 = Convert.ToInt32(TextBox2.Text);
        int r = no1 + no2;
        Result.Text =r.ToString();
    }
    

    protected void btnSub_Click(object sender, EventArgs e)
    {
        int no1 = Convert.ToInt32(TextBox1.Text);
        int no2 = Convert.ToInt32(TextBox2.Text);
        int r = no1 - no2;
        Result.Text = r.ToString();

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        Result.Text = "";
    }
}