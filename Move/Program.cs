using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Ventus
{
    internal class Program
    {
        private static void Main()
        {
            Test1A();
            Test1B();
            Test2A();
        }

        //NO
        private static void Test1A()
        {
            SqlCommand cmd;
            SqlConnection cn;
            cn = new SqlConnection("connectionstring");
            cn.Open();
            cmd = new SqlCommand("EntrySave", cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@Field1", 1);
            cmd.Parameters.AddWithValue("@Field2", 2);
            cmd.Parameters.AddWithValue("@Field3", 3);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private static void Test1B()
        {
            var cn = new SqlConnection("connectionstring");
            cn.Open();
            var cmd = new SqlCommand("EntrySave", cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@Field1", 1);
            cmd.Parameters.AddWithValue("@Field2", 2);
            cmd.Parameters.AddWithValue("@Field3", 3);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //NO
        private static void Test2A()
        {
            var x = 123;
            int y;
            if ((x & 1) > 0)
            {
                y = 100;
                Console.WriteLine(y);
            }
            else {
                y = 200;
                Console.WriteLine(y);
            }

            var a = new int[10];
            var n = 10;
            var s = a.Where(o => (o & 1) != 0).Sum();
            Console.WriteLine(s);

        }
    }
}