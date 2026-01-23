using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateAppPage : System.Web.UI.Page
{
    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Window Application\\ASP.NET-Work\\HDFC_LOAN_WEBSITE\\App_Data\\HDFC_Database.mdf\";Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {

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
                }
                else
                {
                    Response.Write("<script>alert('Loan Number not found');</script>");
                    ClearFields();
                }
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                string updateLoanQuery = @"UPDATE Loan 
                                           SET AccountNo = @AccountNo, 
                                               LoanCategory = @LoanCategory, 
                                               LoanType = @LoanType, 
                                               IssueDate = @IssueDate, 
                                               Amount = @Amount, 
                                               CurrentAddress = @CurrentAddress, 
                                               LoanRemarks = @LoanRemarks 
                                           WHERE LoanNo = @LoanNo";

                SqlCommand cmdLoan = new SqlCommand(updateLoanQuery, con, transaction);

                cmdLoan.Parameters.AddWithValue("@LoanNo", txtLoanNo.Text.Trim());

                decimal accountNo;
                decimal.TryParse(txtSavingAcctNo.Text, out accountNo);
                cmdLoan.Parameters.AddWithValue("@AccountNo", accountNo);

                cmdLoan.Parameters.AddWithValue("@LoanCategory", ddlLoanCategory.SelectedValue);
                cmdLoan.Parameters.AddWithValue("@LoanType", ddlLoanType.SelectedValue);
                cmdLoan.Parameters.AddWithValue("@IssueDate", txtLoanDate.Text);

                decimal amount;
                decimal.TryParse(txtLoanAmmount.Text, out amount);
                cmdLoan.Parameters.AddWithValue("@Amount", amount);

                cmdLoan.Parameters.AddWithValue("@CurrentAddress", txtCurrAddress.Text);
                cmdLoan.Parameters.AddWithValue("@LoanRemarks", txtRemarks.Text);

                cmdLoan.ExecuteNonQuery();

                string updateAccountQuery = @"UPDATE Account 
                                              SET ActHolderName = @ActHolderName 
                                              WHERE SavingActNo = @SavingActNo";

                SqlCommand cmdAccount = new SqlCommand(updateAccountQuery, con, transaction);
                cmdAccount.Parameters.AddWithValue("@ActHolderName", txtSavingAcctName.Text.Trim());
                cmdAccount.Parameters.AddWithValue("@SavingActNo", accountNo);

                cmdAccount.ExecuteNonQuery();

                transaction.Commit();
                Response.Write("<script>alert('Record Updated Successfully!');</script>");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Response.Write("<script>alert('Update Failed: " + ex.Message + "');</script>");
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
}