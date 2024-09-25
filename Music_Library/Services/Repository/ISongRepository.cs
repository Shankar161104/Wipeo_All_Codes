using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface ISongRepository
    {
        IEnumerable<Song> GetSongs();
        int CreateSong(Song song);
        int UpdateSong(Song song);
        int DeleteSong(int id);

    }
}
