using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Time
    {
        [Display(Name = "Id do Time")]
        public int IdTime { get; set; }
        [Display(Name = "Nome da sala")]
        public string? NomeSala { get; set; }
        [Display(Name = "Pagamento")] 
        public bool Pagamento { get; set; }
        [Display(Name = "Camisa")]
        public string? Camisa { get; set; }
        [Display(Name = "Curso")]
        public string? Curso { get; set; }
        [Display(Name = "Periodo")]
        public string? Periodo { get; set; }
        [Display(Name = "AptoJogo")]
        public string? AptoJogo { get; set; }
    }
}
