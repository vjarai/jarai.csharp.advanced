namespace Jarai.CSharp.Interface5.DefaultImplementation;

internal interface IExampleInterface
{
    /// <summary>
    ///    Interface Methoden konnten vor C# 8.0 keine Implementierung enthalten.
    /// </summary>
    void MethodWithoutDefaultImplementation();

    /// <summary>
    ///     Seit C# 8 ist es möglich, Default-Implementierungen für Interface Methoden zu definieren.
    ///
    ///     Dies ist sinnvoll, wenn ein Interface um eine Methode erweitert werden soll,
    ///     aber die bestehenden Implementierungen nicht angepasst werden sollen.
    ///     Eine Klasse kann mehrere Interfaces implementieren, auch solche die die gleiche Methode mit Default-Implementierung enthalten.
    /// 
    ///     Die Default Implementioerung kann ggf. in Klassen, die das Interface implementieren, überschrieben werden.
    /// </summary>
    void MethodWithDefaultImplemantation()
    {
        Console.WriteLine("Default implementation of MethodWithDefaultImplemantation");
    }
}