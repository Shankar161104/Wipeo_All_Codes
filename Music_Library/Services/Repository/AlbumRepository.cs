using DAL.EntityFrameWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly ApplicationDbContext dbContext;
        public AlbumRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public int CreateAlbum(Album album)
        {
            dbContext.Albums.Add(album);
            return dbContext.SaveChanges();
        }

        public int DeleteAlbum(int id)
        {
            var delete = dbContext.Albums.Find(id);
            if (delete==null)
            {
                throw new ArgumentException("Entity is missing");
            }
            dbContext.Albums.Remove(delete);
            return dbContext.SaveChanges();
        }

        public IEnumerable<Album> GetAlbums()
        {
            return dbContext.Albums.ToList();
        }

        public int UpdateAlbum(Album album)
        {
            dbContext.Albums.Update(album);
            return dbContext.SaveChanges();
        }
    }
}
