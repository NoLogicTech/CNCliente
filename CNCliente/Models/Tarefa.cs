using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Tarefa
    {
        public Tarefa()
        {
            InverseTarefaParent = new HashSet<Tarefa>();
        }

        public int tarefaId { get; set; }
        public int? tarefaParentid { get; set; }
        public int projetoId { get; set; }
        public string tarefaNome { get; set; }
        public DateTime tarefaDatahoraregisto { get; set; }
        public DateTime? tarefaDatalimite { get; set; }
        public int? tarefaPosicao { get; set; }
        public int utilizadorId { get; set; }
        public bool tarefaEstado { get; set; }
        public bool tarefaTemfilho { get; set; }

        public virtual Projeto projeto { get; set; }
        public virtual Tarefa TarefaParent { get; set; }
        public virtual Utilizador Utilizador { get; set; }
        public virtual ICollection<Tarefa> InverseTarefaParent { get; set; }
    }
}
