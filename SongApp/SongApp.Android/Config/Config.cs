using SQLite.Net.Interop;
using SongApp.Droid.Config;
using SQLite.Net.Platform.XamarinAndroid;
using SongApp.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(Config))]
namespace SongApp.Droid.Config
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
                    _plataforma = new SQLitePlatformAndroid();
                }
                return _plataforma;
            }
        }

        public Config()
        {

        }
    }
}