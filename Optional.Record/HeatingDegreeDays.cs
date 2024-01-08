namespace Optional.Record;

public sealed record HeatingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
    : DegreeDays(BaseTemperature, TempRecords)
{
    public double DegreeDays
    {
        get { return TempRecords.Where(s => s.Mean < BaseTemperature).Sum(s => BaseTemperature - s.Mean); }
    }
}