using System.ComponentModel;

namespace UWP.Auxiliar
{
    public class NotifyBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotificarCambio(string sNameAtributo)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(sNameAtributo));
            }
        }
    }
}

