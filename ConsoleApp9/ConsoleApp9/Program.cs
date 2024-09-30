using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name,address and city");
            string nm = Console.ReadLine();
            string ad = Console.ReadLine();
            string ct = Console.ReadLine();

            string q = "insert into table_1 values('"+nm+"','"+ad+"','"+ct+"')";
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=kanpur;Integrated Security=True;");
            cn.Open();
            SqlCommand cmd = new SqlCommand(q,cn);
            int i = cmd.ExecuteNonQuery();
            if (i >= 0)
                Console.WriteLine("insertedddd");
            else
                Console.WriteLine("not inserteddd");
        }
    }
}
