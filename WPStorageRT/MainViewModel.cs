using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPStorageRT
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<User> Users { get; set; }

        public MainViewModel()
        {
            Users = new ObservableCollection<User>();
        }


        #region Interface Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaiseNotification(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
