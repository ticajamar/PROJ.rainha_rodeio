using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class TipoArquivo
    {
        public TipoArquivo()
        {
            ModeloArquivos = new HashSet<ModeloArquivo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<ModeloArquivo> ModeloArquivos { get; set; }
    }
}
