using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Medida
    {
        public Medida()
        {
            Projetos = new HashSet<Projeto>();
        }

        public int MedidaId { get; set; }
        public string MedidaNome { get; set; }
        public string MedidaPrograma { get; set; }

        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}
