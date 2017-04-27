using SongApp.Interface;
using SongApp.Repository;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using System;

[assembly: Xamarin.Forms.Dependency(typeof(Config))]
namespace SongApp.Repository
{
    public class Config : IConfig
    {
        private string _diretorio;
        public string Diretorio
        {
            get
            {
                if (string.IsNullOrEmpty(_diretorio))
                {
                    _diretorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return _diretorio;
            }
        }

        private ISQLitePlatform _plataforma;
        public ISQLitePlatform Plataforma
        {
            get
            {
                if (_plataforma == null)
                {
                    _plataforma = new SQLitePlatformAndroidN();
                }
                return _plataforma;
            }
        }

        public Config()
        {

        }
    }
}
