using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negozio.DataAccess.DbModel
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
    }
}
