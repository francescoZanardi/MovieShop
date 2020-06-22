using System;
using System.Collections.Generic;
using System.Text;

namespace Negozio.Dto
{
    public class RequestFilm
    {
        public string Titolo { get; set; }
        public DateTime Anno { get; set; }
        public decimal Prezzo { get; set; }
        public string NomeNegozio { get; set; }
        public string Luogo { get; set; }
        public string NomeRegista { get; set; }
        public string CognomeRegista { get; set; }
        public string NomeAttori { get; set; }
        public string CognomeAttori { get; set; }
    }
}
