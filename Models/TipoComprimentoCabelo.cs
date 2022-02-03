using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class TipoComprimentoCabelo
    {
        public TipoComprimentoCabelo()
        {
            ModeloCaracteristicas = new HashSet<ModeloCaracteristica>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<ModeloCaracteristica> ModeloCaracteristicas { get; set; }
    }
}
