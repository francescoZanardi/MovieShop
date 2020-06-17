using Microsoft.EntityFrameworkCore;
using Negozio.DataAccess.DbModel;
using NegozioDataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.DataAccess.Services
{
    public class FilmService : IFilmService
    {
        private readonly NegozioContext _negozioContext;
        public FilmService(NegozioContext negozioContext)
        {
            _negozioContext = negozioContext;
        }
        public async Task<List<Film>> GetFilms()
        {
            try
            {
                var result = await _negozioContext.Film
                    .Include(x => x.FilmId)
                    .Include(x => x.FilmAutores)
                    .ThenInclude(x => x.Registas).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }
    }
}
