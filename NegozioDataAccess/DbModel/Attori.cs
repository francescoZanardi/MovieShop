using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class Attori
    {
        [Key]
        public int AttoriId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
    }
}
