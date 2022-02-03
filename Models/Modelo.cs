using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class Modelo
    {
        public Modelo()
        {
            ModeloCaracteristicas = new HashSet<ModeloCaracteristica>();
        }

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

        public virtual Cidade IdCidadeNavigation { get; set; }
        public virtual Escolaridade IdEscolaridadeNavigation { get; set; }
        public virtual ICollection<ModeloCaracteristica> ModeloCaracteristicas { get; set; }
    }
}
