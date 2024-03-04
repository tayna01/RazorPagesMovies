using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Modelo
{
    public class Filme
    {
        public int ID { get; set; }

        [Display(Name = "Título")]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Digite o Titulo do filme")]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name ="Data de lançamento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Digite a Data de Lançamento do filme")]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Genêro")]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage="Digite o genêro do filme")]
        public string Genero { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Digite o Preço do filme")]
        public decimal Preco { get; set; }

        [Display(Name = "Pontos")]
        [Required(ErrorMessage = "Digite os Pontos do filme")]
        [Range(0, 5)]
        public int Pontos { get; set; } = 0;
    
    }
}
