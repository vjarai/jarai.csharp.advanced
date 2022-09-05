using System;
using System.Collections.Generic;

namespace Jarai.CSharp.Generic.Collections
{
    internal class Program
    {
        private static List<double> _myList;
        private static double[] _myArray;
        private static Queue<int> _myQueue;
        private static Stack<int> _myStack;
        private static Dictionary<string, string> _myDictionary;

        private static void Main(string[] args)
        {
            // Listen können zur Laufzeit erweitert werden
            _myList = new List<double> { 10, 50, 30, 20 };
            _myList.Add(999);

            // Arrays können indiziert werden (random access)
            _myArray = _myList.ToArray();
            Console.WriteLine(_myArray[2]);

            // Queues geben Elemente in gleicher Reihenfolge wieder aus (FIFO)
            _myQueue = new Queue<int>();
            _myQueue.Enqueue(10);
            _myQueue.Enqueue(50);
            Console.WriteLine(_myQueue.Dequeue());
            Console.WriteLine(_myQueue.Dequeue());

            // Stacks geben Elemente in umgekehrter Reihenfolge wieder aus (FILO)
            _myStack = new Stack<int>();
            _myStack.Push(10);
            _myStack.Push(50);
            Console.WriteLine(_myStack.Pop());
            Console.WriteLine(_myStack.Pop());

            // Ein Dictionary ermöglicht den schnellen Zugriff auf ein element über einen key
            _myDictionary = new Dictionary<string, string>
            {
                { "Gut", "Good" },
                { "Schlecht", "Bad" }
            };
            Console.WriteLine(_myDictionary["Gut"]);
        }
    }
}