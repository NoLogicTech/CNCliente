﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace CNCliente.Models
{
    public partial class concelho
    {
        public concelho()
        {
            cliente = new HashSet<cliente>();
            codpostal = new HashSet<codpostal>();
        }

        public int concelhoId { get; set; }
        public string concelhoNome { get; set; }
        public string concelhoCodigo { get; set; }
        public int concelhoNumero { get; set; }
        public int distrito_Id { get; set; }
        public int? regiao_Id { get; set; }

        public virtual distrito distrito { get; set; }
        public virtual ICollection<cliente> cliente { get; set; }
        public virtual ICollection<codpostal> codpostal { get; set; }
    }
}