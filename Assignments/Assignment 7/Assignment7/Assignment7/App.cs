using System;
using System.Data.SqlClient;

namespace Assignment7
{
    class App
    {
        internal static SqlConnection con = null;
        internal static SqlConnection GetConnection()
        {
            string source = "Data Source= DESKTOP-M6M7A44\\;Initial Catalog=Casestudy;User ID=sa;Password=newuser123#";
            con = new SqlConnection(source);
            con.Open();
            return con;
        }
        static void Main()
        {
            Methods methods = new Methods();
            methods.ShowFirstScreen();
            Console.Read();
        }


    }
}
