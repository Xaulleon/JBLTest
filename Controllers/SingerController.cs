using Microsoft.AspNetCore.Mvc;
using Prueba.Data;
using Prueba.Models;

namespace Prueba.Controllers
{
    [Route("api/singers")]
    [ApiController]
    public class SingerController : ControllerBase
    {
        private readonly ISingerRepo _repository;

        public SingerController(ISingerRepo repository)
        {
            this._repository = repository;
        }

        [HttpGet("{id}")]
        public ActionResult<Singer> GetSingerById(int id)
        {
            var singer = this._repository.GetSinger(id);

            return Ok(singer);
        }

    }
}