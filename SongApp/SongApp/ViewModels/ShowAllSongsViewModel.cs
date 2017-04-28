using SongApp.Models;
using SongApp.Services;
using SongApp.ViewModels.Base;
using System.Collections.ObjectModel;

namespace SongApp.ViewModels
{
    public class ShowAllSongsViewModel : ViewModelBase
    {
        ObservableCollection<Song> _songs;
        readonly SongService _songService = new SongService(); 
        public ObservableCollection<Song> Songs
        {
            get { return _songs; }
            set
            {
                _songs = value;
                OnPropertyChanged();
            }
        }
        public ShowAllSongsViewModel() : base("Show All Songs")
        {

        }
    }
}
