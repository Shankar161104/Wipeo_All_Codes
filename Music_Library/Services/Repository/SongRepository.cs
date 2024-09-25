using DAL.EntityFrameWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class SongRepository : ISongRepository
    {
        private readonly ApplicationDbContext dbContext;
        public SongRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public int CreateSong(Song song)
        {
            dbContext.Songs.Add(song);
            return dbContext.SaveChanges();
        }

       

        public IEnumerable<Song> GetSongs()
        {
            return dbContext.Songs.ToList();
        }

        public int UpdateSong(Song song)
        {
            if (song == null)
            {
                throw new ArgumentException("Entity is missing");
            }
            dbContext.Songs.Update(song);
            return dbContext.SaveChanges();

        }

       public int DeleteSong(int id)
        {
            var delete = dbContext.Songs.Find(id);
            if (delete == null)
            {
                throw new ArgumentException("Entity is missing");
            }
            dbContext.Songs.Remove(delete);
            return dbContext.SaveChanges();
        }
    }
}
