using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAlbums();
        int CreateAlbum(Album album);
        int UpdateAlbum(Album album);
        int DeleteAlbum(int id);
    }
}
