namespace Jarai.Generic.ReturnType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new Factory();

            var myCar = factory.Create<Car>();
            var myEngine = factory.Create<Engine>();
        }
    }
}
