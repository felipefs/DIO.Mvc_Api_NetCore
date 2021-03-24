using System.ComponentModel.DataAnnotations;
namespace DIO.Mvc.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name= "Descrição")]
        [Required(ErrorMessage = "O Campo Descrição é obrigatório.")]
        public string Descricao { get; set; }
        [Range(0,10, ErrorMessage = "Valor fora da faixa.")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        [Display(Name= "Categoria")]
        public Categoria _categoria { get; set; }
    }
}