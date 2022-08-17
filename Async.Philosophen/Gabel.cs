namespace Jarai.Async.Lock
{
    internal class Gabel
    {
        public Gabel(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Philosoph Philosoph { get; set; }

        public void Grab()
        {
        }

        public void Put()
        {
        }
    }
}