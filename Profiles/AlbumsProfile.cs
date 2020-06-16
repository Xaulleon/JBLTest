using AutoMapper;
using Prueba.Dtos;
using Prueba.Models;

namespace Prueba.Profiles
{
    public class AlbumsProfile : Profile
    {
        public AlbumsProfile()
        {
            CreateMap<Album, AlbumReadDto>();
        }
    }
}