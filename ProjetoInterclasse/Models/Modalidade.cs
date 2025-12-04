using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Modalidade
    {
        [Display(Name = "Codigo da Modalidade")]
        public int IdModalidade { get; set; }
        [Display(Name = "Nome")]
        public string? NomeModalidade { get; set; }
        
    }
}
