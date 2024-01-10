

// https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/

// https://devblogs.microsoft.com/dotnet/configureawait-faq/

using System.ComponentModel;

namespace Jarai.CSharp.Async.Winforms
{
    internal class CalculationService
    {
        public event EventHandler<ProgressChangedEventArgs> ProgressChanged;

        public CalculationResult Calculate(IEnumerable<int> input, CancellationToken cancellationToken)
        {
            var result = 0;

            foreach (var i in input)
            {
                result += i;
                Thread.Sleep(3); // Simulate long running operation

                // Kooperatives Abbrechen

                cancellationToken.ThrowIfCancellationRequested(); // Abort, if canceled from UI
            }

            return new CalculationResult(result);
        }

        public async Task<CalculationResult> CalculateAsync(IEnumerable<int> input, CancellationToken cancellationToken)
        {
            var result = 0;
            var progress = 0;

            foreach (var i in input)
            {
                result += i;
                progress++;

                //if (progress % 5 == 0)
                    ProgressChanged?.Invoke(this, new ProgressChangedEventArgs( progress, null));
                
                await Task.Delay(3, cancellationToken); // Simulate long running operation
            }

            return new CalculationResult(result);
        }
    }
}