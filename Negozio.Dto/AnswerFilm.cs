using Negozio.DataAccess.DbModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Negozio.Dto
{
    public class AnswerFilm
    {
        public int FilmId { get; set; }
        public string Titolo { get; set; }
        public DateTime Anno { get; set; }
        public decimal Prezzo { get; set; }
        public string NomeNegozio { get; set; }
        public string Luogo { get; set; }
        public List<AnswerRegista> Registi { get; set; }
        public static List<AnswerFilm> MappaPerLista(List<Film> Films)
        {
            var res = new List<AnswerFilm>();
            foreach (var item in Films)
            {
                var tmp = new AnswerFilm();
                tmp.FilmId = item.FilmId;
                tmp.Titolo = item.Titolo;
                tmp.Anno = item.Anno;
                tmp.Prezzo = item.Prezzo;
                if (tmp.NomeNegozio != null)
                {
                    tmp.NomeNegozio = item.Negozioo.NomeNegozio;
                    tmp.Luogo = item.Negozioo.Luogo;
                }
                tmp.Registi = new List<AnswerRegista>();
                if (item.FilmRegistas.Any())
                {
                    tmp.Registi = item.FilmRegistas.Select(x => new AnswerRegista
                    {
                        RegistaId = x.Regista.RegistaId,
                        Nome = x.Regista.Nome,
                        Cognome = x.Regista.Cognome
                    }).ToList();
                }
                res.Add(tmp);
            }
            return res;
        }
        public static AnswerFilm MappaFilm(Film film)
        {
            var tmp = new AnswerFilm();
            tmp.FilmId = film.FilmId;
            tmp.Titolo = film.Titolo;
            tmp.Anno = film.Anno;
            tmp.Prezzo = film.Prezzo;
            if (tmp.NomeNegozio != null)
            {
                tmp.NomeNegozio = film.Negozioo.NomeNegozio;
                tmp.Luogo = film.Negozioo.Luogo;
            }
            tmp.Registi = new List<AnswerRegista>();
            if (film.FilmRegistas.Any())
            {
                tmp.Registi = film.FilmRegistas.Select(x => new AnswerRegista
                {
                    RegistaId = x.Regista.RegistaId,
                    Nome = x.Regista.Nome,
                    Cognome = x.Regista.Cognome
                }).ToList();
            }
            return tmp;
        }
    }
}
