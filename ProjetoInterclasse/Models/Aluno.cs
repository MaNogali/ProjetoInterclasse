using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Aluno
    {
        [Display(Name = "RM do aluno")]
        public int RM { get; set; }
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
        [Display(Name = "Período")]
        public string? Periodo{ get; set; }
        [Display(Name = "Idade")]
        public int Idade { get; set; }
        [Display(Name = "Numero da camiseta")]
        public int NumeroCamiseta { get; set; }
    }
}
