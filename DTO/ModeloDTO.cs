using System;

namespace rainha_rodeio.DTO
{
    public class ModeloDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime? DataNascimento { get; set; }
        public long? Celular { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string EnderecoNumero { get; set; }
        public string Bairro { get; set; }
        public int? Cep { get; set; }
        public int? IdCidade { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public bool Ativo { get; set; }
        public byte[] Foto { get; set; }
        public string Observacao { get; set; }
        public int? IdEscolaridade { get; set; }
        public string CaminhoFoto { get; set; }


        public int Peso { get; set; }
        public int IdTipoCorOlho { get; set; }
        public int IdTipoCorPele { get; set; }
        public int Manequim { get; set; }
        public int NumeroCalcado { get; set; }
        public int NumeroChapeu { get; set; }
        public int IdTipoComprimentoCabelo { get; set; }
        public int IdTipoCorCabelo { get; set; }
        public int MedidaBusto { get; set; }
        public int MedidaCintura { get; set; }
        public int MedidaQuadril { get; set; }
    }
}
