using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Dimensao
    {
        public Dimensao()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int DimensaoId { get; set; }
        public string DimensaoNome { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
