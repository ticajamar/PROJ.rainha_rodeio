using System;
using System.Collections.Generic;

#nullable disable

namespace rainha_rodeio.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public long Celular { get; set; }
        public bool Ativo { get; set; }
        public string Senha { get; set; }
        public byte[] Foto { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public DateTime? DataUltimoLogin { get; set; }

        public virtual Perfil IdPerfilNavigation { get; set; }
    }
}
