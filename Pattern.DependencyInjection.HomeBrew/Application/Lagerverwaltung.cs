namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Application
{
    public class Lagerverwaltung
    {
        public Lagerverwaltung(Bestellservice bestellservice, Versandservice versandservice)
        {
            Bestellservice = bestellservice;
            Versandservice = versandservice;
        }

        public Bestellservice Bestellservice { get; set; }

        public Versandservice Versandservice { get; set; }
    }
}