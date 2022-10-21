using System;

namespace Jarai.CSharp.Pattern.Observer
{
    public class KursChangedEventArgs : EventArgs
    {
        public KursChangedEventArgs(string wkn, decimal letzterKurs, decimal aktuellerKurs)
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