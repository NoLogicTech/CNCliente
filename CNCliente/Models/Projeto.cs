using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Models
{
    public partial class Projeto
    {
        public int ProjetoId { get; set; }
        public string ProjetoNumero { get; set; }
        public string ProjetoDesignacao { get; set; }
        public decimal? ProjetoValoraprovado { get; set; }
        public decimal? ProjetoIncentivoaprovado { get; set; }
        public decimal? ProjetoValorrealizado { get; set; }
        public decimal? ProjetoIncentivorecebido { get; set; }
        public DateTime? ProjetoDatasubmissao { get; set; }
        public DateTime? ProjetoDatadecisao { get; set; }
        public DateTime? ProjetoDatacontratacao { get; set; }
        public DateTime? ProjetoDatainicio { get; set; }
        public DateTime? ProjetoDatafim { get; set; }
        public string ProjetoResponsavel { get; set; }
        public int? ClienteId { get; set; }
        public int? MedidaId { get; set; }
        public int? EstadoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Estadoprojeto Estado { get; set; }
        public virtual Medida Medida { get; set; }
    }
}