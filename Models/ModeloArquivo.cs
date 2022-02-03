using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class ModeloArquivo
    {
        public int Id { get; set; }
        public int IdModelo { get; set; }
        public int IdTipoArquivo { get; set; }
        public DateTime DataInclusao { get; set; }

        public virtual TipoArquivo IdTipoArquivoNavigation { get; set; }
    }
}
