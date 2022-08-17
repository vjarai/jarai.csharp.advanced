using System;

namespace Jarai.Patterns.Observer
{
    public class KursChangedEventArg : EventArgs
    {
        public KursChangedEventArg(string wkn, decimal letzterKurs, decimal aktuellerKurs)
        {
            Wkn = wkn;
            LetzterKurs = letzterKurs;
            AktuellerKurs = aktuellerKurs;
        }

        public decimal AktuellerKurs { get; }

        public decimal LetzterKurs { get; }

        public string Wkn { get; set; }
    }
}