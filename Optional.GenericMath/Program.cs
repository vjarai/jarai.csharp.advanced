namespace Optional.GenericMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var unused1 = GenericMathCalculator.Add(1, 2);
           var unused2 = GenericMathCalculator.Add(1.0, 2.0);

            // Compilerfehler:  
            // var unused3 = GenericMathCalculator.Add("Hallo", "Welt");
            // var unused8 = GenericMathCalculator.Add(new Foo(1), new Foo(2));


            var unused4 = DynamicMathCalculator.Add(1, 2);
            var unused5 = DynamicMathCalculator.Add(1.0, 2.0);
            var unused6 = DynamicMathCalculator.Add("Hallo", "Welt");

            // Laufzeitfehler
            var unused7 = DynamicMathCalculator.Add(new Foo(1), new Foo(2));
        }


    }
}
