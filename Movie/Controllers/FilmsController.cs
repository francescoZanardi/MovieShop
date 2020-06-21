using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negozio.Core;
using Negozio.DataAccess.DbModel;
using Negozio.DataAccess.Services;
using Negozio.Dto;

namespace Movie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmService _filmService;
        private readonly IFilmCore _filmCore;
            public FilmsController(IFilmService filmService, IFilmCore filmCore)
        {
            _filmService = filmService;
            _filmCore = filmCore;
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
            }
        }

        // GET: api/Film/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var toMap = await _filmService.GetFilm(id);
                if (toMap == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(AnswerFilm.MappaFilm(toMap));
                }
            }
            catch (Exception)
            {
                return StatusCode(500, null);
            }
        }

        // POST: api/Film
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestFilm value)
        {
            try
            {
                var res = await _filmCore.PostFilm(value);
                if (res != 0)
                {
                    return Ok(res);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return StatusCode(500, null);
            }
        }

        // PUT: api/Film/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Film film)
        {
            try
            {
                film.FilmId = id;
                var res = await _filmService.UpdateFilm(film);
                if (res)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return StatusCode(500, null);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var res = await _filmService.DeleteFilm(id);
                if (res)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return StatusCode(500, null);
            }
        }
    }
}
