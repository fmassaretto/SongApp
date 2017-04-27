using SQLite.Net.Interop;

namespace SongApp.Interface
{
    public interface IConfig
    {
        string Diretorio { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
