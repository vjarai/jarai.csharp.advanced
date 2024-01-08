namespace Optional.Record;

/// <summary>
/// Immutable Record, because of readonly record
/// </summary>
public readonly record struct DailyTemperature // (double HighTemp, double LowTemp)
{
    public required double HighTemp { get; init; }
    public required double LowTemp { get; init; }// init is required for readonly record

    /// <summary>
    /// Computed Property
    /// </summary>
    public double Mean
    {
        get { return (HighTemp + LowTemp) / 2.0; }
    }


}