namespace Jarai.CSharp.Generic.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Listen können zur Laufzeit erweitert werden
        var myList = new List<double> { 10, 50, 30, 20 };
        myList.Add(999);

        foreach (var item in myList) 
            Console.WriteLine(item);

        // Queues geben Elemente in gleicher Reihenfolge wieder aus (FIFO)
        var myQueue = new Queue<int>();
        myQueue.Enqueue(10);
        myQueue.Enqueue(50);
        Console.WriteLine(myQueue.Dequeue()); // 10
        Console.WriteLine(myQueue.Dequeue()); // 50

        // Stacks geben Elemente in umgekehrter Reihenfolge wieder aus (FILO)
        var myStack = new Stack<int>();
        myStack.Push(10);
        myStack.Push(50);
        Console.WriteLine(myStack.Pop()); // 50
        Console.WriteLine(myStack.Pop()); // 10

        // Ein Dictionary ermöglicht den schnellen Zugriff auf ein element über einen key
        var myDictionary = new Dictionary<string, string>
        {
            { "Gut", "Good" },
            { "Schlecht", "Bad" }
        };

        myDictionary.Add("ok", "ok");

        Console.WriteLine(myDictionary["Gut"]); // Good
    }
}