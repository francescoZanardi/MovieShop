using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class FilmAttori
    {
        [Key]
        public int FilmAttoriId { get; set; }
        public int AttoriId { get; set; }
        public int FilmId { get; set; }
    }
}
