using SongApp.Models;
using SongApp.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SongApp.Services
{
    public class SongService
    {
        private readonly RepositoryGeneric<Song> _repository; 
        public async Task<List<Song>> GetAll()
        {
            try
            {
                return await RepositoryGeneric<Song>.Instance.GetAll();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<Song> Post(Song songs)
        {
            try
            {
                await RepositoryGeneric<Song>.Instance.Post(songs);
                return songs;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public async Task<List<Song>> PostAll(List<Song> songs)
        //{
        //    try
        //    {
        //        await base.PostAll(songs);
        //        return songs;
        //    }
        //    catch (Exception exception)
        //    {
        //        throw new Exception(exception.Message);
        //    }
        //}
    }
}
