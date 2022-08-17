using System;

namespace Jarai.Interface.Simple
{
    internal class Wand : ILackierbar
    {
        private string _farbe;

        #region ILackierbar Member

        public string Farbe
        {
            get { return _farbe; }
            set
            {
                _farbe = value;
                Console.WriteLine("Die Wand ist jetzt " + _farbe);
            }
        }

        #endregion
    }
}