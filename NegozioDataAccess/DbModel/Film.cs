﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class Film
    {
        [Key]
        public int FilmId { get; set; }
        public string Titolo { get; set; }
        public int NegoziooId { get; set; }
        public DateTime Anno { get; set; }
        public decimal Prezzo { get; set; }
        public virtual Negozioo Negozioo { get; set; }
        public virtual List<FilmRegista> FilmRegistas { get; set; }
        public virtual List<FilmAttore> FilmAttores { get; set; }
 
    }
}
