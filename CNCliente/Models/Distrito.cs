using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Clientes = new HashSet<Cliente>();
            Codpostals = new HashSet<Codpostal>();
            Concelhos = new HashSet<Concelho>();
        }

        public int DistritoId { get; set; }
        public string DistritoNome { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Codpostal> Codpostals { get; set; }
        public virtual ICollection<Concelho> Concelhos { get; set; }
    }
}
