using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_produtos_mvc.Models
{
    public class Produto
    {

        public int Id { get; set; }
        [Display(Name = "NomeProduto")]
        [Required(ErrorMessage = "O campo descricao e obrigatorio")]
        public String Descricao { get; set; }

        [Range(1, 10, ErrorMessage = "A quantidade deve estar entre 1 e 10")]
        public int Quantidade { get; set; }

        [Range(1, 10, ErrorMessage = "o id deve estar entre 1 e 100")]
        public int IdCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}
