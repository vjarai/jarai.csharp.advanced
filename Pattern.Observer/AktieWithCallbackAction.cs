using System;
using System.Collections.Generic;

namespace Jarai.CSharp.Pattern.Observer
{
    public class AktieWithCallbackAction : Aktie
    {
        public AktieWithCallbackAction(string wkn, string name, decimal aktuellerKurs)
            : base(wkn, name, aktuellerKurs)
        {
        }

        public List<Action<object, KursChangedEventArg>> Callbacks { get; } = new List<Action<object, KursChangedEventArg>>();

        protected override void OnKursChanged()
        {
            foreach (var callback in Callbacks)
            {
                callback.Invoke(this, new KursChangedEventArg(Wkn, _letzterKurs, AktuellerKurs));
            }
        }
    }
}