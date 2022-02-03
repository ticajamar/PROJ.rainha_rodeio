using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class ModeloFase
    {
        public int IdModelo { get; set; }
        public int IdFase { get; set; }
        public int IdModeloStatus { get; set; }
        public DateTime DataInclusado { get; set; }
        public int NumeroModelo { get; set; }

        public virtual Fase IdFaseNavigation { get; set; }
        public virtual Modelo IdModeloNavigation { get; set; }
        public virtual ModeloStatus IdModeloStatusNavigation { get; set; }
    }
}
