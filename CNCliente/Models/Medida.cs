﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace CNCliente.Models
{
    public partial class medida
    {
        public medida()
        {
            projeto = new HashSet<projeto>();
        }

        public int medidaId { get; set; }
        public string medidaNome { get; set; }
        public string medidaPrograma { get; set; }

        public virtual ICollection<projeto> projeto { get; set; }
    }
}