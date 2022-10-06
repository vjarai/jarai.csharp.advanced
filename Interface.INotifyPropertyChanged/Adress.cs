using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Jarai.CSharp.Interface.NotifyPropertyChanged
{
    internal class Adress : INotifyPropertyChanged
    {
        private string _description;
        private string _name;
        private string _zipCode;

        public string Description
        {
            get { return _description; }
            set
            {
                if (value == _description) return;
                _description = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (value == _zipCode) return;
                _zipCode = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}