using System;

using database_test.Models;

namespace database_test
{
    class Program
    {
        static void Main(string[] args)
        {
            inputTest("Sibren2");
            Console.WriteLine("Done");
        }
        static void inputTest(string name)
        {
            using (var db = new testContext())
            {
                Test t = new Test { Name = name };
                db.Add(t);
                db.SaveChanges();
            }
        }
    }
}
