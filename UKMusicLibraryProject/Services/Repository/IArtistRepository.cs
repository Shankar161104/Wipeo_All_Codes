using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetArtist();
        Artist GetArtist(long id);
        int InsertArtist(Artist artist);
        int UpdateArtist(Artist artist);
        void DeleteArtist(long id);
    }
}
