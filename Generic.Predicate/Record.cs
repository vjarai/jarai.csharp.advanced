namespace Jarai.CSharp.Generic.Predicate
{
    public class Record
    {
        public int Id { get; set; }

        public int Value { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Value={Value}";
        }
    }
}