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

        private Task<List<Song>> _songsLstView;
        public Task<List<Song>> SongsLstView
        {
            get {
               var GetSongs = _songService.GetAll();
                var teste = GetSongs;
                return GetSongs;
                }
            //set
            //{
            //    _songs = value;
            //    OnPropertyChanged();
            //}
        }

        private async Task<ObservableCollection<Song>> RefreshSongs(){
            List<Song> GetSongs = await _songService.GetAll();
            var teste = GetSongs;
            return new ObservableCollection<Song>(GetSongs);
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
