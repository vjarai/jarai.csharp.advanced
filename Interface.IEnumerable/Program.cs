using System;

namespace Jarai.CSharp.Interface.IEnumerable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myPhoneBook = new Phonebook
            {
                new PhonebookEntry { Name = "Meier", PhoneNumber = "123456" },
                new PhonebookEntry { Name = "Schulz", PhoneNumber = "876543w" }
            };

            foreach (var entry in myPhoneBook)
            {
                Console.WriteLine(entry);
            }
        }
    }
}