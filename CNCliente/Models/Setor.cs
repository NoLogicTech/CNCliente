using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Setor
    {
        public Setor()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int SetorId { get; set; }
        public string SetorNome { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}