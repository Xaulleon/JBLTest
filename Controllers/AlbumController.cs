using AutoMapper;
using CoreNLogText;
using Microsoft.AspNetCore.Mvc;
using Prueba.Data;
using Prueba.Dtos;
using Prueba.Models;

namespace Prueba.Controllers
{
    [Route("api/albums")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumRepo _repository;
        private readonly IMapper _mapper;
        private ILog _logger;

        public AlbumController(IAlbumRepo repository, IMapper mapper, ILog logger)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<AlbumReadDto> GetalbumById(int id)
        {
            _logger.Information("AlbumController-Album has been called on id: " + id + " is logged");

            var album = this._repository.GetAlbum(id);
            if (album != null)
            {
                return Ok(_mapper.Map<AlbumReadDto>(album));
            }
            else
            {
                _logger.Error("AlbumController-id: " + id + "has not been found");
                return NotFound();
            }

        }

    }
}