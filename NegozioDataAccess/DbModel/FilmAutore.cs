using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class FilmAutore
    {
        [Key]
        public int FilmAutoreId { get; set; }
        public int FilmId { get; set; }
        public int RegistaId { get; set; }
        public virtual Film Films  { get; set; }
        public virtual Regista Registas  { get; set; }

    }
}
