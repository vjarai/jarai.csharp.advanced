using System;
using System.ComponentModel;

namespace Jarai.CSharp.Interface.NotifyPropertyChanged
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myAdress = new Adress();
            myAdress.PropertyChanged += MyAdressOnPropertyChanged;

            myAdress.Name = "Meier";
            myAdress.ZipCode = "12345";
            myAdress.Description = "Test";

            Console.ReadLine();
        }

        private static void MyAdressOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName + " was changed.");
        }
    }
}