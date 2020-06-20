using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class Regista
    {
        [Key]
        public int RegistaId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public virtual List<FilmRegista> FilmRegistas { get; set; }
    }
}
