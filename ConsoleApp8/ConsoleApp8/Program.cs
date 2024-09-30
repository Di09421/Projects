using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cn = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=Btps;Integrated Security=True;");
            cn.Open();
            Console.WriteLine("connectedddd");
            Console.ReadKey();
        }
    }
}
