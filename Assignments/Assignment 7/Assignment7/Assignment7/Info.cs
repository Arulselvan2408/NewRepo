using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace Assignment7
{
    class Info
    {
        public void DisplayStudent()
        {
            var Con = App.GetConnection();
            SqlDataReader dr;
            var cmd = new SqlCommand("select * from studentDetails", Con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
        }
        public void DisplayCourse()
        {
            var Con = App.GetConnection();
            SqlDataReader dr;
            var cmd = new SqlCommand("select * from Course", Con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]+" "+dr[3]);
            }

        }
        public void DisplayEnroll()
        {
            var Con = App.GetConnection();
            SqlDataReader dr;
            var cmd = new SqlCommand("select * from Enroll", Con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] );
            }
        }
        

    }
}
