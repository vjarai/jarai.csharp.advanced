using System.Collections.Generic;

namespace Jarai.Patterns.Observer
{
    /// <summary>
    ///     Obsolete: Eventhandling using delegate
    /// </summary>
    public class AktieWithCallbackDelegate : Aktie
    {
        /// <summary>
        ///     Define Signatur of the Callback
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public delegate void KursChangedCallback(object sender, KursChangedEventArg eventArgs);

        public AktieWithCallbackDelegate(string wkn, string name, decimal aktuellerKurs)
            : base(wkn, name, aktuellerKurs)
        {
        }

        /// <summary>
        ///     List with the callbacks from all subscribed observers
        /// </summary>
        public List<KursChangedCallback> Callbacks { get; } = new List<KursChangedCallback>();

        protected override void OnKursChanged()
        {
            foreach (var callback in Callbacks)
            {
                callback.Invoke(this, new KursChangedEventArg(Wkn, _letzterKurs, AktuellerKurs));
            }
        }
    }
}