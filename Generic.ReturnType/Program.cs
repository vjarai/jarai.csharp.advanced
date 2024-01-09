namespace Jarai.CSharp.Generic.ReturnType
{
    internal class Program
    {
        static void Main()
        {
            var factory = new Factory();

            var myCar = factory.Create<Car>();
            var myEngine = factory.Create<Engine>();
        }
    }
}
