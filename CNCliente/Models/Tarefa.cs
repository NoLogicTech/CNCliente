using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Tarefa
    {
        public int tarefaId { get; set; }
        public int? tarefaParentid { get; set; }
        public int projetoId { get; set; }
        public string tarefaNome { get; set; }
        public DateTime tarefaDatahoraregisto { get; set; }
        public DateTime tarefaDatalimite { get; set; }
        public int tarefaPosicao { get; set; }
        public int utilizadorIdcriador { get; set; }
        public int utilizadorIdatribuido { get; set; }
        public bool tarefaEstado { get; set; }
        public bool tarefaTemfilho { get; set; }
    }
}