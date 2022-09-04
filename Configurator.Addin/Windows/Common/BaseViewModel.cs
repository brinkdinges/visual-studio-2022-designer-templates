using System.ComponentModel;

namespace Configurator.Addin.Windows.Common
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
