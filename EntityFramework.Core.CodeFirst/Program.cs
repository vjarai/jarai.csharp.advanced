namespace Jarai.CSharp.EntityFrameworkCore.CodeFirst
{
    internal class Program
    {
        private static void WriteLog(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void Main(string[] args)
        {
            // Start DB Transaction
            using (var db = new DatabaseContext())
            {
               // Create record
                var newContact = new Contact { Name = "Meier" };
                db.Contacts.Add(newContact);
                db.SaveChanges(); // Sonst Änderung nicht sichtbar!

                // Read record
                var firstContact = db.Contacts.ToList().First();

                // Delete record
                db.Contacts.Remove(firstContact);

                // Update record
                newContact.Modified = DateTime.Now;

                // Commit Transaction
                int changedRecords = db.SaveChanges();

                Console.WriteLine($"{changedRecords} records changed.");
            } // Rollback, if db.SaveChanges not called
        }
    }
}
