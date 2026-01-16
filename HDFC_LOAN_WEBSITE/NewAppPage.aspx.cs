using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewAppPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Window Application\\ASP.NET-Work\\HDFC_LOAN_WEBSITE\\App_Data\\HDFC_Database.mdf\";Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        string query = "INSERT INTO Loan (AccountNo, LoanCategory, LoanType, IssueDate, Amount, CurrentAddress, LoanRemarks) VALUES (@AccountNo, @LoanCategory, @LoanType, @IssueDate, @Amount, @CurrentAddress, @LoanRemarks)";
        SqlCommand cmd = new SqlCommand(query,con);
        cmd.Parameters.AddWithValue("@AccountNo",txtSavingAcctNo);
        cmd.Parameters.AddWithValue("@LoanCategory",ddlLoanCategory);
        cmd.Parameters.AddWithValue("@LoanType",ddlLoanType);
        cmd.Parameters.AddWithValue("@IssueDate",txtLoanDate);
        cmd.Parameters.AddWithValue("@Amount",txtLoanAmmount);
        cmd.Parameters.AddWithValue("@CurrentAddress",txtCurrAddress);
        cmd.Parameters.AddWithValue("@LoanRemarks",txtRemarks);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    protected void txtSavingAcctNo_TextChanged(object sender, EventArgs e)
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Window Application\\ASP.NET-Work\\HDFC_LOAN_WEBSITE\\App_Data\\HDFC_Database.mdf\";Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        string query = "SELECT * FROM Account WHERE SavingActNo = @SavingActNo";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@SavingActNo", txtSavingAcctNo.Text);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read()) { 
            txtSavingAcctName.Text = dr["ActHolderName"].ToString();
        }
        con.Close();
    }
}