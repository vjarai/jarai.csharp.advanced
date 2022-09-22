using System;

namespace Jarai.CSharp.Pattern.Observer
{
    public class Aktie
    {
        private decimal _aktuellerKurs;

        protected decimal _letzterKurs;

        public Aktie(string wkn, string name, decimal aktuellerKurs)
        {
            Wkn = wkn;
            Name = name;
            _aktuellerKurs = aktuellerKurs;
        }

        public decimal AktuellerKurs
        {
            get { return _aktuellerKurs; }

            set
            {
                if (_aktuellerKurs != value)
                {
                    _letzterKurs = _aktuellerKurs;
                    _aktuellerKurs = value;
                    OnKursChanged();
                }
            }
        }

        public string Name { get; }

        public string Wkn { get; }

        public virtual event EventHandler<KursChangedEventArg> KursChanged;

        protected virtual void OnKursChanged()
        {
            KursChanged?.Invoke(this, new KursChangedEventArg(Wkn, _letzterKurs, AktuellerKurs));
        }
    }
}