using System;

namespace Jarai.Async.Winforms
{
    internal class CalculationResult
    {
        public CalculationResult(int value)
        {
            Value = new Random().Next(value);
        }

        public int Value { get; set; }
    }
}