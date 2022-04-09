using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Filmes
    {
        public int Id { get; set; } 

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name ="Data de Lançamento")]
        
        public DateTime DataLancamento { get; set; }
       
        [Required(ErrorMessage = "Este campo é obrigatório"), StringLength(10), RegularExpression(@"^[A-Z]+[a-za-Z/s]*$")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }  = string.Empty ;
        
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display (Name ="Preço")]
        [DataType (DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preço { get; set; }
        
        [Range(0,5)]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public int? pontos { get; set; }



    }
}
