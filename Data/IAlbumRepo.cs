using Prueba.Models;

namespace Prueba.Data
{
    public interface IAlbumRepo
    {
        public Album GetAlbum(int id);
    }
}