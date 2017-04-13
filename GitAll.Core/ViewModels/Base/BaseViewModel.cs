using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GitAll.Core.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string property = null)
        {
            var args = new PropertyChangedEventArgs(property);
            PropertyChanged?.Invoke(this, args);
        }
        
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string property = null)
        {
            if(EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            RaisePropertyChanged(property);
            return true;
        }
    }
}
