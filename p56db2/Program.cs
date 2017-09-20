using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

public class Tutorial2
{
    public static void Main()
    {
        string connStr = "server=145.24.198.71;user=guest;database=prj_56_db;port=3306;password=guest;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            Console.WriteLine("Connection opened");
            //string sql = "INSERT INTO supplier (Name, City, Street, HouseNumber, KvK-Number) VALUES('testName','testCity','testStreet','1', 10938187)";
            //string sql = "INSERT INTO product(SupplierId, Specs,Stock,Price,Name,Category) VALUES(1,'testspecs',9,11,'testProduct1','testcategory')";
            //string sql = "UPDATE supplier SET KvKNumber = 83716372 WHERE SupplierId = 1";
            string sql ="SELECT * FROM supplier";
            // MySqlDataReader rdr = null;
            // string sql = "";
            // MySqlCommand cmd = new MySqlCommand(sql, conn);
            // for (int i = 1; i <= 4; i++)
            // {
            //     string num = "";
            //     Random rand = new Random();
            //     for (int j = 0; j < 8; j++)
            //     {
            //         num += rand.Next(0, 10).ToString();
            //     }
            //     sql = "UPDATE supplier SET KvKNumber = " + num + " WHERE SupplierId = " + i;
            //     cmd.CommandText = sql;
            //     rdr = cmd.ExecuteReader();
            //     Console.WriteLine("Executed query: {0}", sql);
            //     rdr.Close();
            // }


            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("Executed query: {0}", sql);
            try
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
            }
            catch{}
            rdr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        conn.Close();
        Console.WriteLine("Done.");
    }
}