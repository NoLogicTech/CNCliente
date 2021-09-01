using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Cae
    {
        public Cae()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int CaeId { get; set; }
        public string CaeCodigo { get; set; }
        public string CaeNome { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}