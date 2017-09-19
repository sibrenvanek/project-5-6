using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;


namespace P56DB2
{
    public class testContext:DbContext
    {
        public DbSet<test> Tests{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // <- probably has to change
        {
            //optionsBuilder.UseNpgsql("Server=145.24.198.85;Database=prj_56_db;Uid=root;Pwd=HRO0917820;");
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString="Server=localhost;Database=prj_56_db;Uid=root;Pwd=HRO0917820;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                Console.WriteLine("open?"); 
                conn.Open();
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
               // MessageBox.Show(ex.Message);
            }
            
        }   

    }
    public class test
    {
        public int TestId{get;set;}
        public string Name{get;set;}

    }

}