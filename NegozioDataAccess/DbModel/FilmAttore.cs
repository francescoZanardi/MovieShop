using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class FilmAttore
    {
        [Key]
        public int FilmAttoreId { get; set; }
        public int AttoreId { get; set; }
        public int FilmId { get; set; }
        public virtual Attore Attore { get; set; }
        public virtual Film Film { get; set; }
    }
}
