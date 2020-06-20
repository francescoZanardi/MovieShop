using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class FilmRegista
    {
        //autore = regista
        [Key]
        public int FilmRegistaId { get; set; }
        public int FilmId { get; set; }
        public int RegistaId { get; set; }
        public virtual Film Film  { get; set; }
        public virtual Regista Regista  { get; set; }

    }
}
