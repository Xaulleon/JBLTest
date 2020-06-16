using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Data
{
    public class SqlAlbumRepo : IAlbumRepo
    {
        private readonly AlbumContext _context;

        public SqlAlbumRepo(AlbumContext context)
        {
            _context = context;
        }

        public Album GetAlbum(int id)
        {
            return _context.Albums
            .Include(p => p.Songs)
            .Include(p => p.Singer)
            .FirstOrDefault(p => p.Id == id);

        }


    }
}