using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class FaseJurado
    {
        public int IdFase { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}
