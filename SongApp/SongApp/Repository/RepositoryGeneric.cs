using SongApp.Database;
using SQLite.Net.Async;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SongApp.Repository
{
    public class RepositoryGeneric<T> where T : class
    {
        private SQLiteAsyncConnection _connection;
        private SongsDatabase _database;
        private static RepositoryGeneric<T> _instance;

        public RepositoryGeneric()
        {
            _database = new SongsDatabase();
            _connection = _database.ConnectionAsync;
        }

        public static RepositoryGeneric<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositoryGeneric<T>();
                }
                return _instance;
            }
        }

        public async Task<List<T>> GetAll()
        {
            try
            {

                return await _connection.Table<T>().ToListAsync();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                return await _connection.FindAsync<T>(id);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<T> Post(T obj)
        {
            try
            {
                await _connection.InsertAsync(obj);
                return obj;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<List<T>> PostAll(List<T> obj)
        {
            try
            {
                await _connection.InsertAllAsync(obj);
                return obj;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<T> Put(T obj)
        {
            try
            {
                await _connection.UpdateAsync(obj);
                return obj;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<List<T>> PutAll(List<T> obj)
        {
            try
            {
                await _connection.UpdateAllAsync(obj);
                return obj;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task Delete(T obj)
        {
            try
            {
                await _connection.DeleteAsync(obj);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task DeleteAll(List<T> obj)
        {
            try
            {
                await _connection.DeleteAsync(obj);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
