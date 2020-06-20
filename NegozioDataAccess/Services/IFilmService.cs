using System.Collections.Generic;
using System.Threading.Tasks;
using Negozio.DataAccess.DbModel;

namespace Negozio.DataAccess.Services
{
    public interface IFilmService
    {
        Task<List<Film>> GetFilms();
        Task<Film> GetFilm(int id);
    }
}