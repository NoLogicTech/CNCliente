using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Regiao
    {
        public Regiao()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int RegiaoId { get; set; }
        public string RegiaoNome { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
