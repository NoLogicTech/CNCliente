using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class Tarefa
    {
        public int TarefaId { get; set; }
        public int? TarefaParentid { get; set; }
        public int ProjetoId { get; set; }
        public string TarefaNome { get; set; }
        public DateTime TarefaDatahoraregisto { get; set; }
        public DateTime TarefaDatalimite { get; set; }
        public int TarefaPosicao { get; set; }
        public int UtilizadorIdcriador { get; set; }
        public int UtilizadorIdatribuido { get; set; }
        public bool TarefaEstado { get; set; }
        public bool TarefaTemfilho { get; set; }
    }
}