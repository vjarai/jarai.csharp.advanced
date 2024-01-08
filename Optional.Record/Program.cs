namespace Optional.Record
{
    // https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/records

    internal class Program
    {
        private static DailyTemperature[] data = {
            new DailyTemperature{HighTemp =  57, LowTemp =  30},
            new DailyTemperature{HighTemp =  60, LowTemp =  35},
            new DailyTemperature{HighTemp =  63, LowTemp =  33},
            new DailyTemperature{HighTemp =  68, LowTemp =  29},
            new DailyTemperature{HighTemp =  72, LowTemp =  47},
            new DailyTemperature{HighTemp =  75, LowTemp =  55},
            new DailyTemperature{HighTemp =  77, LowTemp =  55},
            new DailyTemperature{HighTemp =  72, LowTemp =  58},
            new DailyTemperature{HighTemp =  70, LowTemp =  47},
            new DailyTemperature{HighTemp =  77, LowTemp =  59},
            new DailyTemperature{HighTemp =  85, LowTemp =  65},
            new DailyTemperature{HighTemp =  87, LowTemp =  65},
            new DailyTemperature{HighTemp =  85, LowTemp =  72},
            new DailyTemperature{HighTemp =  83, LowTemp =  68},
            new DailyTemperature{HighTemp =  77, LowTemp =  65},
            new DailyTemperature{HighTemp =  73, LowTemp =  58},
            new DailyTemperature{HighTemp =  77, LowTemp =  55},
            new DailyTemperature{HighTemp =  76, LowTemp =  53},
            new DailyTemperature{HighTemp =  80, LowTemp =  60},
            new DailyTemperature{HighTemp =  85, LowTemp =  66}
        };

        static void Main(string[] args)
        {
            foreach (var item in data)
                Console.WriteLine(item);

            var heatingDegreeDays = new HeatingDegreeDays(65, data);
            Console.WriteLine(heatingDegreeDays);

            var coolingDegreeDays = new CoolingDegreeDays(65, data);
            Console.WriteLine(coolingDegreeDays);
        }
    }
}
