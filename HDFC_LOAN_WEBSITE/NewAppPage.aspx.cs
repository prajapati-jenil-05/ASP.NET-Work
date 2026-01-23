 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewAppPage : System.Web.UI.Page
{
    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Window Application\\ASP.NET-Work\\HDFC_LOAN_WEBSITE\\App_Data\\HDFC_Database.mdf\";Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Loan (AccountNo, LoanCategory, LoanType, IssueDate, Amount, CurrentAddress, LoanRemarks) VALUES (@AccountNo, @LoanCategory, @LoanType, @IssueDate, @Amount, @CurrentAddress, @LoanRemarks)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                decimal accountNo;
                decimal.TryParse(txtSavingAcctNo.Text, out accountNo);
                cmd.Parameters.AddWithValue("@AccountNo", accountNo);
                cmd.Parameters.AddWithValue("@LoanCategory", ddlLoanCategory.SelectedValue); 
                cmd.Parameters.AddWithValue("@LoanType", ddlLoanType.SelectedValue);         
                cmd.Parameters.AddWithValue("@IssueDate", txtLoanDate.Text);
                decimal amount;
                decimal.TryParse(txtLoanAmmount.Text, out amount);
                cmd.Parameters.AddWithValue("@Amount", amount);

                cmd.Parameters.AddWithValue("@CurrentAddress", txtCurrAddress.Text);
                cmd.Parameters.AddWithValue("@LoanRemarks", txtRemarks.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    protected void txtSavingAcctNo_TextChanged(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT ActHolderName FROM Account WHERE SavingActNo = @SavingActNo";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@SavingActNo", txtSavingAcctNo.Text);

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    txtSavingAcctName.Text = result.ToString();
                }
                else
                {
                    txtSavingAcctName.Text = "";
                }
            }
        }
    }
}