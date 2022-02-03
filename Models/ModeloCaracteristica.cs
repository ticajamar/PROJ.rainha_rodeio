using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class ModeloCaracteristica
    {
        public int Id { get; set; }
        public int IdModelo { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Peso { get; set; }
        public int? IdTipoCorOlho { get; set; }
        public int? IdTipoCorPele { get; set; }
        public int? Manequim { get; set; }
        public int? NumeroCalcado { get; set; }
        public int? NumeroChapeu { get; set; }
        public int? IdTipoCabelo { get; set; }
        public int? IdTipoComprimentoCabelo { get; set; }
        public int? IdTipoCorCabelo { get; set; }
        public decimal? MedidaBusto { get; set; }
        public decimal? MedidaCintura { get; set; }
        public decimal? MedidaQuadril { get; set; }

        public virtual Modelo IdModeloNavigation { get; set; }
        public virtual TipoCabelo IdTipoCabeloNavigation { get; set; }
        public virtual TipoComprimentoCabelo IdTipoComprimentoCabeloNavigation { get; set; }
        public virtual TipoCorCabelo IdTipoCorCabeloNavigation { get; set; }
        public virtual TipoCorOlho IdTipoCorOlhoNavigation { get; set; }
        public virtual TipoCorPele IdTipoCorPeleNavigation { get; set; }
    }
}
