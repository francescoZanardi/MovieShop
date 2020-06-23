using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class Attore
    {
        [Key]
        public int AttoreId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public virtual List<FilmAttore> FilmAttores { get; set; }
    }
}
