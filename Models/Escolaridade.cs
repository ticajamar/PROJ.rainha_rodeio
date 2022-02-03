using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class Escolaridade
    {
        public Escolaridade()
        {
            Modelos = new HashSet<Modelo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Modelo> Modelos { get; set; }
    }
}
