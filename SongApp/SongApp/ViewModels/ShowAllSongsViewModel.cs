using SongApp.Models;
using SongApp.Services;
using SongApp.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SongApp.ViewModels
{
    public class ShowAllSongsViewModel : ViewModelBase
    {
        readonly SongService _songService = new SongService(); 

        ObservableCollection<Song> _songs;
        public ObservableCollection<Song> Songs
        {
            get { return _songs; }
            //set
            //{
            //    _songs = value;
            //    OnPropertyChanged();
            //}
        }
        public ShowAllSongsViewModel() : base("Show All Songs")
        {
            _songs.Add(new Song {
                Name = "sdfs",
                Artist = "sdsd",
                Album = "sdsd",
                Composer = "sdsd",
                Genre = "sdsd",
                TotalTime = 1,
                TrackNumber = 2,
                Year = 3,
                BitRate = 4
            });
        }
    }
}
