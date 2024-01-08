namespace Optional.GenericMath;

/// <summary>
/// Keine Compilezeitprüfung, ob T "numerisch" ist
/// </summary>
public static class DynamicMathCalculator
{
    public static T Add<T>(T a, T b)
    {
        return (dynamic)a + (dynamic)b;
    }

    public static T Subtract<T>(T a, T b)
    {
        return (dynamic)a - (dynamic)b;
    }

    public static T Multiply<T>(T a, T b)
    {
        return (dynamic)a * (dynamic)b;
    }

    public static T Divide<T>(T a, T b)
    {
        return (dynamic)a / (dynamic)b;
    }
}