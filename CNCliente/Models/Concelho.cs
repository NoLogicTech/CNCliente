using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Concelho
    {
        public Concelho()
        {
            Clientes = new HashSet<Cliente>();
            Codpostals = new HashSet<Codpostal>();
        }

        public int ConcelhoId { get; set; }
        public string ConcelhoNome { get; set; }
        public string ConcelhoCodigo { get; set; }
        public int ConcelhoNumero { get; set; }
        public int DistritoId { get; set; }
        public int? RegiaoId { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Codpostal> Codpostals { get; set; }
    }
}