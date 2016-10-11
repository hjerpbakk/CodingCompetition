using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sidebar
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected void Set<T>(ref T member, T value, [CallerMemberName] string propertyName = null)
        {
            member = value;
            OnPropertyChanged(propertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}