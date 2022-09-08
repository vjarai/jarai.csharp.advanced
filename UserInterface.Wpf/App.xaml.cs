using System.Globalization;
using System.Threading;
using System.Windows;

namespace Jarai.CSharp.UserInterface.Wpf
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private App()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }
    }
}