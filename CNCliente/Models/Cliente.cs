using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Projetos = new HashSet<Projeto>();
        }

        public int ClienteId { get; set; }
        public string ClienteErpid { get; set; }
        public string ClienteNipc { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteEmail { get; set; }
        public string ClienteTelefone { get; set; }
        public int? DimensaoId { get; set; }
        public int? RegiaoId { get; set; }
        public int? SetorId { get; set; }
        public int? CaeId { get; set; }
        public int? CodpostalId { get; set; }
        public int? DistritoId { get; set; }
        public int? ConcelhoId { get; set; }

        public virtual Cae Cae { get; set; }
        public virtual Codpostal Codpostal { get; set; }
        public virtual Concelho Concelho { get; set; }
        public virtual Dimensao Dimensao { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual Regiao Regiao { get; set; }
        public virtual Setor Setor { get; set; }
        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}
