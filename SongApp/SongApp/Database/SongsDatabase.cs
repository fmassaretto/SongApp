using SongApp.Interface;
using SongApp.Models;
using SQLite.Net;
using SQLite.Net.Async;
using System;
using System.IO;
using System.Threading;
using Xamarin.Forms;

namespace SongApp.Database
{
    public class SongsDatabase
    {
        private SQLiteAsyncConnection _connection;
        public SQLiteAsyncConnection ConnectionAsync
        {
            get
            {
                if (_connection == null)
                {
                    var config = DependencyService.Get<IConfig>();
                    //var platform = new SQLitePlatformAndroidN();
                    var cwLock = new SQLiteConnectionWithLock(config.Plataforma, new SQLiteConnectionString(Path.Combine(config.Diretorio, "SongApp.db3"), false));
                    _connection = new SQLiteAsyncConnection(() => cwLock);
                    LazyInitializer.EnsureInitialized(ref _connection);
                }
                return _connection;
            }
        }

        public void CreateTables()
        {
            try
            {
                ConnectionAsync.CreateTableAsync<Song>().Wait();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
