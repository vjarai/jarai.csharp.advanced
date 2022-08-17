using System;

namespace Jarai.Generic.Func
{
    internal class TaxCalculator
    {
        private readonly Action<string> _loggingAction;
        private readonly Func<decimal, decimal> _taxCalculationFunc;

        public TaxCalculator(Func<decimal, decimal> taxCalculationFunc, Action<string> loggingAction)
        {
            _taxCalculationFunc = taxCalculationFunc;
            _loggingAction = loggingAction;
        }

        public decimal CalculateTax(decimal value)
        {
            _loggingAction("Tax calculated");
            return _taxCalculationFunc(value);
        }
    }
}