using System.Text;

namespace Optional.Record;

public abstract record DegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
{
    protected virtual bool PrintMembers(StringBuilder stringBuilder)
    {
        stringBuilder.Append($"BaseTemperature = {BaseTemperature}");
        return true;
    }
}