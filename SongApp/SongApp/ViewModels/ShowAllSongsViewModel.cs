using SongApp.Models;
using SongApp.Services;
using SongApp.ViewModels.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace SongApp.ViewModels
{
    public class ShowAllSongsViewModel : ViewModelBase, INotifyPropertyChanged
    {
        readonly SongService _songService = new SongService();

        public event PropertyChangedEventHandler PropertyChanged;

        private string _artist;
        private string _album;

        public string Album
        {
            get { return _album; }
            set
            {
                _album = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Album)));
            }
        }

        public string Artist
        {
            get { return _artist; }
            set
            {
                _artist = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Artist)));
            }
        }

        private ObservableCollection<Song> _songsLstView;
        public ObservableCollection<Song> SongsLstView
        {
            get {
                return _songsLstView;
                }
            set
            {
                _songsLstView = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SongsLstView)));
            }
        }

        private async Task RefreshSongs(){
            var GetSongs = await _songService.GetAll();
            SongsLstView = new ObservableCollection<Song>(GetSongs);
        }
        public ShowAllSongsViewModel() : base("Show All Songs")
        {
            Task.Run(async () => await RefreshSongs());
        }


    }
}
