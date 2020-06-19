using Negozio.DataAccess.DbModel;
using System;
using System.Collections.Generic;
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
        public static List<AnswerFilm> MappaPerLista(List<Film> films)
        {
            var res = new List<AnswerFilm>();
            foreach (var item in films)
            {
                var tmp = new AnswerFilm();
                tmp.FilmId = item.FilmId;
                tmp.Titolo = item.Titolo;
                tmp.Anno = item.Anno;
                tmp.Prezzo = item.Prezzo;
                if (tmp.NomeNegozio != null)
                {
                    tmp.NomeNegozio = item.Negozios.NomeNegozio;
                    tmp.Luogo = item.Negozios.Luogo;
                }
                tmp.Registi = new List<AnswerRegista>();
                if (item.FilmAutores.Any())
                {
                    tmp.Registi = item.FilmAutores.Select(x => new AnswerRegista {
                        RegistaId = x.Registas.RegistaId,
                        Nome = x.Registas.Nome,
                        Cognome = x.Registas.Cognome
                    }).ToList();
                }
                res.Add(tmp);
            }
            return res;
        }
    }
}
