using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Utilizador
    {
        public Utilizador()
        {
            Tarefas = new HashSet<Tarefa>();
        }

        public int UtilizadorId { get; set; }
        public string UtilizadorNome { get; set; }
        public string UtilizadorEmail { get; set; }
        public string UtilizadorIniciais { get; set; }

        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}
