using System;

namespace Jarai.Interface.Simple
{
    internal class Auto : IFahrbar, ILackierbar
    {
        private string _farbe;

        #region ILackierbar Member

        public string Farbe
        {
            get { return _farbe; }
            set
            {
                _farbe = value;
                Console.WriteLine("Das Auto ist jetzt " + _farbe);
            }
        }

        #endregion

        public void Fahren()
        {
            Console.WriteLine("Das Auto fährt.");
        }
    }
}