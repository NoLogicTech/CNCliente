using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Codpostal
    {
        public Codpostal()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int CodpostalId { get; set; }
        public int DistritoId { get; set; }
        public int ConcelhoNumero { get; set; }
        public string ConcelhoCodigo { get; set; }
        public int ConcelhoId { get; set; }

        public virtual Concelho Concelho { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}