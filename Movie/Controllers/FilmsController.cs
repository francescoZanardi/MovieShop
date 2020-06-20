using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negozio.DataAccess.Services;
using Negozio.Dto;

namespace Movie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmService _filmService;
            public FilmsController(IFilmService filmService)
        {
            _filmService = filmService;
        }
        // GET: api/Film
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var tomap = await _filmService.GetFilms();
                var res = AnswerFilm.MappaPerLista(tomap);
                return Ok(res);
            }
            catch (Exception)
            {
                return StatusCode(500, null);
                throw;
            }
        }

        // GET: api/Film/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Film
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Film/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
