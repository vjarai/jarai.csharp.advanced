using System;
using System.Data.Entity;
using System.Linq;

namespace Jarai.CSharp.EF6.CodeFirst
{
    internal class Program
    {
        private static void CreateRecords()
        {

            var seminar1 = new Seminar { Name = "C#", Description = "Advanced" };
            var seminar2 = new Seminar { Name = "C#", Description = "Basic" };

            var person1 = new Person { FirstName = "Fritz", Name = "Meier", Geburtstag = new DateTime(1980, 01, 1) };
            var person2 = new Person { FirstName = "Susi", Name = "Müller", Geburtstag = new DateTime(1980, 01, 1) };

            person1.AddSeminar(seminar1);
            person1.AddSeminar(seminar2);
            person2.AddSeminar(seminar2);

            using (var datenbank = new Datenbank())  // Kurzlebige Datenbankverbindung, entspricht Transaction
            {
                datenbank.Database.Log = Log;

                datenbank.Personen.Add(person1);
                datenbank.Personen.Add(person2);

                datenbank.SaveChanges();    // SQL Commit

            }
        }

        private static void Log(string sql)
        {
            Console.WriteLine(sql);
        }

        private static void Main(string[] args)
        {
            CreateRecords();

            ShowRecords();
        }

        private static void ShowRecords()
        {
            using (var db = new Datenbank())
            {
                // Lazy Loading (erfordert virtual Navigation Properties und public Entity Klasse)
                //db.Configuration.ProxyCreationEnabled = true;     
                //db.Configuration.LazyLoadingEnabled = true;

                var personen = db.Personen.Include(x => x.Seminare).ToList(); // Eager Loading mit Include

                db.Database.Log = Log;

                foreach (var person in personen)
                {
                    Console.WriteLine(person.Name);

                    foreach (var seminar in person.Seminare)
                    {
                        Console.WriteLine(seminar.Name);
                    }
                }
            }
        }
    }
}