using System.Collections.Generic;
using Prueba.Models;

namespace Prueba.Data
{
    public interface ISongRepo
    {
        IEnumerable<Song> GetSongs(int singed_id);

    }
}