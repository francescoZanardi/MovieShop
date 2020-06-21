using System.Collections.Generic;
using System.Threading.Tasks;
using Negozio.DataAccess.DbModel;

namespace Negozio.DataAccess.Services
{
    public interface IFilmService
    {
        Task<List<Film>> GetFilms();
        Task<Film> GetFilm(int id);
        Task<Film> GetFilmTitolo(string titolo);
        Task<Negozioo> CheckNegozio(string nome, string luogo);
        Task<Regista> CheckRegista(string nome, string cognome);
        Task<int> AddFilmToDb(Film film);
        Task <bool> UpdateFilm(Film film);
    }
}