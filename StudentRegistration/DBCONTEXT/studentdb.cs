using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentRegistration.DBCONTEXT
{
    public class studentdb
    {
        public void ADDSTUDENT(student_model S)
        {
            SqlConnection con = new SqlConnection(
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Window Application\\ASP.NET-Work\\StudentRegistration\\App_Data\\Database1.mdf;Integrated Security=True"
            );

            SqlCommand cmd = new SqlCommand(
                "insert into STUDENT (studentname, studentcity) values (@sname, @scity)", con
            );

            cmd.Parameters.AddWithValue("@sname", S.Name);
            cmd.Parameters.AddWithValue("@scity", S.City);

            con.Open();
            cmd.ExecuteNonQuery(); 
            con.Close();
        }
        public void DELETESTUDENT(student_model S)
        {
            SqlConnection con = new SqlConnection(
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Window Application\\ASP.NET-Work\\StudentRegistration\\App_Data\\Database1.mdf;Integrated Security=True"
            );

            SqlCommand cmd = new SqlCommand(
                "delete from STUDENT where studentid = @id", con
            );

            cmd.Parameters.AddWithValue("@id", S.Id);
            con.Open();
            cmd.ExecuteNonQuery(); 
            con.Close();
        }

    }
}
