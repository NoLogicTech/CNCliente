using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Projeto
    {
        public Projeto()
        {
            Tarefas = new HashSet<Tarefa>();
        }

        public int projetoId { get; set; }
        public string projetoNumero { get; set; }
        public string projetoDesignacao { get; set; }
        public decimal? projetoValoraprovado { get; set; }
        public decimal? projetoIncentivoaprovado { get; set; }
        public decimal? projetoValorrealizado { get; set; }
        public decimal? projetoIncentivorecebido { get; set; }
        public DateTime? projetoDatasubmissao { get; set; }
        public DateTime? projetoDatadecisao { get; set; }
        public DateTime? ProjetoDatacontratacao { get; set; }
        public DateTime? ProjetoDatainicio { get; set; }
        public DateTime? ProjetoDatafim { get; set; }
        public string ProjetoResponsavel { get; set; }
        public int? ClienteId { get; set; }
        public int? MedidaId { get; set; }
        public int? EstadoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Estadoprojeto Estadoprojeto { get; set; }
        public virtual Medida Medida { get; set; }
        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}
