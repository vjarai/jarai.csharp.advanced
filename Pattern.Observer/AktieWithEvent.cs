using System;

namespace Jarai.Patterns.Observer
{
    public class AktieWithEvent : Aktie
    {
        public AktieWithEvent(string wkn, string name, decimal aktuellerKurs)
            : base(wkn, name, aktuellerKurs)
        {
        }

        public event EventHandler<KursChangedEventArg> KursChanged;

        protected override void OnKursChanged()
        {
            KursChanged?.Invoke(this, new KursChangedEventArg(Wkn, _letzterKurs, AktuellerKurs));
        }
    }
}