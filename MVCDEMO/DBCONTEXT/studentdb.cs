using MVCDEMO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCDEMO.DBCONTEXT
{
    public class studentdb
    {
        public void ADDSTUDENT(student S)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Window Application\\ASP.NET-Work\\MVCDEMO\\App_Data\\Database1.mdf\";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into STUDENT (studentid, studentname, studentcity) values (@sid, @sname, @scity)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@sid",S.studentid);
            cmd.Parameters.AddWithValue("@sname", S.studentname);
            cmd.Parameters.AddWithValue("@scity", S.studentcity);
            con.Close();
        }
    }
}
