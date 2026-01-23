using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RemoveAppPage : System.Web.UI.Page
{
    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Window Application\\ASP.NET-Work\\HDFC_LOAN_WEBSITE\\App_Data\\HDFC_Database.mdf\";Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            btnSubmit.Enabled = false;
        }
    }

    protected void btnGetLoanDetails_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtLoanNo.Text))
        {
            Response.Write("<script>alert('Please enter a Loan Number');</script>");
            return;
        }

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = @"SELECT Loan.*, Account.ActHolderName 
                             FROM Loan 
                             INNER JOIN Account ON Loan.AccountNo = Account.SavingActNo 
                             WHERE Loan.LoanNo = @LoanNo";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@LoanNo", txtLoanNo.Text.Trim());

                try
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtSavingAcctNo.Text = dr["AccountNo"].ToString();
                        txtSavingAcctName.Text = dr["ActHolderName"].ToString();

                        string category = dr["LoanCategory"].ToString();
                        if (ddlLoanCategory.Items.FindByValue(category) != null)
                            ddlLoanCategory.SelectedValue = category;

                        string type = dr["LoanType"].ToString();
                        if (ddlLoanType.Items.FindByValue(type) != null)
                            ddlLoanType.SelectedValue = type;

                        txtLoanDate.Text = dr["IssueDate"].ToString();
                        txtLoanAmmount.Text = dr["Amount"].ToString();
                        txtCurrAddress.Text = dr["CurrentAddress"].ToString();
                        txtRemarks.Text = dr["LoanRemarks"].ToString();

                        btnSubmit.Enabled = true;

                        DisableFormFields();
                    }
                    else
                    {
                        Response.Write("<script>alert('Loan Number not found');</script>");
                        ClearFields();
                        btnSubmit.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Loan WHERE LoanNo = @LoanNo";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@LoanNo", txtLoanNo.Text.Trim());

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('Loan Application Deleted Successfully.');</script>");
                        ClearFields();
                        EnableFormFields();
                        btnSubmit.Enabled = false;
                    }
                    else
                    {
                        Response.Write("<script>alert('Delete Failed. Record may not exist.');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error deleting record: " + ex.Message + "');</script>");
                }
            }
        }
    }

    private void ClearFields()
    {
        txtSavingAcctNo.Text = "";
        txtSavingAcctName.Text = "";
        ddlLoanCategory.SelectedIndex = 0;
        ddlLoanType.SelectedIndex = 0;
        txtLoanDate.Text = "";
        txtLoanAmmount.Text = "";
        txtCurrAddress.Text = "";
        txtRemarks.Text = "";
    }

    private void DisableFormFields()
    {
        txtSavingAcctNo.Enabled = false;
        txtSavingAcctName.Enabled = false;
        ddlLoanCategory.Enabled = false;
        ddlLoanType.Enabled = false;
        txtLoanDate.Enabled = false;
        txtLoanAmmount.Enabled = false;
        txtCurrAddress.Enabled = false;
        txtRemarks.Enabled = false;
    }

    private void EnableFormFields()
    {
        txtSavingAcctNo.Enabled = true;
        txtSavingAcctName.Enabled = true;
        ddlLoanCategory.Enabled = true;
        ddlLoanType.Enabled = true;
        txtLoanDate.Enabled = true;
        txtLoanAmmount.Enabled = true;
        txtCurrAddress.Enabled = true;
        txtRemarks.Enabled = true;
    }
}