using SongApp.Models;
using SongApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongApp.ViewModels
{
    public class DetailsSongViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Song currentSong;
        public DetailsSongViewModel(Song song) : base("Song Details")
        {
            this.currentSong = song;
        }

        public string Album
        {
            get { return currentSong.Album; }

        }

        public string Artist
        {
            get { return currentSong.Artist; }
        }

        public int BitRate
        {
            get { return currentSong.BitRate; }
        }

        public string Composer
        {
            get { return currentSong.Composer; }

        }

        public string Genre
        {
            get { return currentSong.Genre; }
        }

        public string Name
        {
            get { return currentSong.Name; }
        }

        public long TotalTime
        {
            get { return currentSong.TotalTime; }
        }

        public int TrackNumber
        {
            get { return currentSong.TrackNumber; }
        }

        public int Year
        {
            get { return currentSong.Year; }
        }
    }
}
