﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace CNCliente.Models
{
    public partial class regiao
    {
        public regiao()
        {
            cliente = new HashSet<cliente>();
        }

        public int regiaoId { get; set; }
        public string regiaoNome { get; set; }

        public virtual ICollection<cliente> cliente { get; set; }
    }
}