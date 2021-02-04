﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_produtos_mvc.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "NomeCategoria")]
        [Required(ErrorMessage = "O campo descricao e obrigatorio")]

        public String Descricao { get; set; }

        public List<Produto> Produtos { get; set; }



    }
}
