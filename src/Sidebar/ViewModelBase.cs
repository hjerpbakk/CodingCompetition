using System.ComponentModel;
using System.Runtime.CompilerServices;
using NDC2015.Annotations;

namespace NDC2015
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected void Set<T>(ref T member, T value, [CallerMemberName] string propertyName = null)
        {
            member = value;
            OnPropertyChanged(propertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}