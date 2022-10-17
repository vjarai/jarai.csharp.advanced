namespace Jarai.CSharp.Interface.Enumerable
{
    internal class PhonebookEntry
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return Name + " : " + PhoneNumber;
        }
    }
}