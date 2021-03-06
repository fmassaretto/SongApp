﻿using SongApp.Models;
using SongApp.Services;
using SongApp.ViewModels.Base;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SongApp.ViewModels
{
    public class AddNewSongViewModel : ViewModelBase, INotifyPropertyChanged
    {
        readonly SongService _songService = new SongService();
        private INavigation _navigation;

        private string _album;

        private string _artist;

        private int _bitRate;

        private string _composer;

        private string _genre;

        private string _name;

        private int _totalTime;

        private int _trackNumber;

        private int _year;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public AddNewSongViewModel(INavigation navigation) : base("Adding Song")
        {
            _navigation = navigation;
        }

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

        public int BitRate
        {
            get { return _bitRate; }
            set
            {
                _bitRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BitRate)));
            }
        }

        public string Composer
        {
            get { return _composer; }
            set
            {
                _composer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Composer)));
            }
        }

        public string Genre
        {
            get { return _genre; }
            set
            {
                _genre = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Genre)));
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public int TotalTime
        {
            get { return _totalTime; }
            set
            {
                _totalTime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TotalTime)));
            }
        }

        public int TrackNumber
        {
            get { return _trackNumber; }
            set
            {
                _trackNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TrackNumber)));
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Year)));
            }
        }

        public async Task<Song> AddSong()
        {
            var song = new Song()
            {
                Name = Name,
                Artist = Artist,
                Album = Album,
                Composer = Composer,
                Genre = Genre,
                TotalTime = TotalTime,
                TrackNumber = TrackNumber,
                Year = Year,
                BitRate = BitRate
            };

            if (song != null)
            {
                var retorno = await _songService.Post(song);
                if (retorno != null)
                {
                    await _navigation.PopAsync();
                }
            }
            return song;
        }

        private ICommand _addSongCommand;
        public ICommand AddSongCommand {
            get { return _addSongCommand ?? (_addSongCommand = new Command(async () => await AddSong())); }
        }
    }
}
