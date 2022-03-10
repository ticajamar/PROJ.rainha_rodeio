using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class VwModelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public long? Celular { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string EnderecoNumero { get; set; }
        public string Bairro { get; set; }
        public int? Cep { get; set; }
        public int? IdCidade { get; set; }
        public string NomeCidade { get; set; }
        public int? IdEscolaridade { get; set; }
        public string NomeEscolaridade { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public string Observacao { get; set; }
        public byte[] Foto { get; set; }
        public int? IdTipoCabelo { get; set; }
        public string NomeTipoCabelo { get; set; }
        public int? IdTipoComprimentoCabelo { get; set; }
        public string NomeTipoComprimentoCabelo { get; set; }
        public int? IdTipoCorCabelo { get; set; }
        public string NomeTipoCorCabelo { get; set; }
        public int? IdTipoCorPele { get; set; }
        public string NomeTipoCorPele { get; set; }
        public int? IdTipoCorOlho { get; set; }
        public string NomeTipoCorOlho { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Peso { get; set; }
        public int? Manequim { get; set; }
        public int? NumeroCalcado { get; set; }
        public int? NumeroChapeu { get; set; }
        public decimal? MedidaBusto { get; set; }
        public decimal? MedidaCintura { get; set; }
        public decimal? MedidaQuadril { get; set; }
        public string CaminhoFoto { get; set; }
    }
}
