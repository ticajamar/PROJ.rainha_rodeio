using System;

namespace rainha_rodeio.Models
{
    public class ModeloModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Cep { get; set; }
        public string UF { get; set; }
        public int Fone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public int Idade { get; set; }
        public int IdEscolaridade { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public int IdTipoCorOlho { get; set; }
        public int IdTipoCorPele { get; set; }
        public string Manequim { get; set; }
        public int NumeroCalcado { get; set; }
        public int NumeroChapeu { get; set; }
        public int IdTipoComprimentoCabelo { get; set; }
        public int IdTipoCabelo { get; set; }
        public int IdTipoCorCabelo { get; set; }
        public int MedidaBusto { get; set; }
        public int MedidaCintura { get; set; }
        public int MedidaQuadril { get; set; }
        public string Foto { get; set; }
        public string CaminhoFoto { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}
