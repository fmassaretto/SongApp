using SongApp.Models;
using SongApp.Services;
using SongApp.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SongApp.ViewModels
{
    public class ShowAllSongsViewModel : ViewModelBase
    {
        readonly SongService _songService = new SongService();

        ObservableCollection<Song> _songsLstView;
        public ObservableCollection<Song> SongsLstView
        {
            get { return _songsLstView; }
            //set
            //{
            //    _songs = value;
            //    OnPropertyChanged();
            //}
        }

        private List<Song> RefreshSongs(){
            List<Song> GetSongs = _songService.GetAll();
            var teste = GetSongs;
            return GetSongs;
        }
        public ShowAllSongsViewModel() : base("Show All Songs")
        {
            RefreshSongs();
            //_songs.Add(new Song {
            //    Name = "sdfs",
            //    Artist = "sdsd",
            //    Album = "sdsd",
            //    Composer = "sdsd",
            //    Genre = "sdsd",
            //    TotalTime = 1,
            //    TrackNumber = 2,
            //    Year = 3,
            //    BitRate = 4
            //});
        }
    }
}
