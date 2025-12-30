using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string files = FileUpload1.FileName;
        string path = Server.MapPath("~/Images/") + files;
        FileUpload1.SaveAs(path);
        Label1.Text = "File Uploaded Successfully";
    }
}