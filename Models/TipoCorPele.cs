using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class TipoCorPele
    {
        public TipoCorPele()
        {
            ModeloCaracteristicas = new HashSet<ModeloCaracteristica>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<ModeloCaracteristica> ModeloCaracteristicas { get; set; }
    }
}
