using Negozio.Dto;
using System.Threading.Tasks;

namespace Negozio.Core
{
    public interface IFilmCore
    {
        Task<RequestFilm> PostFilm(RequestFilm requestFilm);
    }
}