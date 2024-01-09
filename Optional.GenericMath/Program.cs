namespace Jarai.CSharp.GenericMath
{
    internal class Program
    {
        static void Main()
        {
            // Generic Math provides Compile-Time-Safety
           var unused1 = GenericMathCalculator.Add(1, 2);
           var unused2 = GenericMathCalculator.Add(1.0, 2.0);

            // Compiletime error:  
            // var unused3 = GenericMathCalculator.Add("Hallo", "Welt");
            // var unused4 = GenericMathCalculator.Add(new Foo(1), new Foo(2));



            // Dynamic Math provides *NO* Compile-Time-Safety
            var unused10 = DynamicMathCalculator.Add(1, 2);
            var unused11 = DynamicMathCalculator.Add(1.0, 2.0);
            var unused12 = DynamicMathCalculator.Add("Hallo", "Welt");

            // Runtime error:
            var unused13 = DynamicMathCalculator.Add(new Foo(1), new Foo(2));
        }


    }
}
