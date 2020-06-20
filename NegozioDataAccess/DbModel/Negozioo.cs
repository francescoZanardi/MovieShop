using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class Negozioo
    {
        [Key]
        public int NegoziooId { get; set; }
        public string NomeNegozio { get; set; }
        public string Luogo { get; set; }
        public virtual Film Films { get; set; }
    }
}
