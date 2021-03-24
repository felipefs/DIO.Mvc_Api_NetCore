using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DIO.Mvc.Models
{
    public partial class Categoria
    {
        public int Id { get; set; }
        [Display(Name= "Descrição")]
        [Required(ErrorMessage = "O Campo Descrição é obrigatório.")]
        public string Descricao { get; set; }
        [Display(Name= "Produtos")]
        public List<Produto> _produtos { get; set; }
    }
}
