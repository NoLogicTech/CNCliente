using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Estadoprojeto
    {
        public Estadoprojeto()
        {
            Projetos = new HashSet<Projeto>();
        }

        public int EstadoprojetoId { get; set; }
        public string EstadoprojetoNome { get; set; }

        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}