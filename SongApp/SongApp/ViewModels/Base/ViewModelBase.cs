using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SongApp.ViewModels.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public string title;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Title {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }
        public ViewModelBase(string title)
        {
            this.Title = title;
        }
    }
}
