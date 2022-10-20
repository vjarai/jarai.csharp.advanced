namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Application
{
    public class ViewModel
    {
        public ViewModel(Lagerverwaltung lagerverwaltung, Buchhaltung buchhaltung)
        {
            Lagerverwaltung = lagerverwaltung;
            Buchhaltung = buchhaltung;
        }

        public Buchhaltung Buchhaltung { get; set; }

        public Lagerverwaltung Lagerverwaltung { get; set; }
    }
}