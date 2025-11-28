using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Grupo
    {
        [Display(Name = "Código da modalidade")]
        public int Idmodalidade { get; set; }
        [Display(Name = "Primeiro time do grupo")]
        public string? Time1 { get; set; }
        [Display(Name = "Segundo time do grupo")]
        public string? Time2 { get; set; }
        [Display(Name = "Terceiro time do grupo")]
        public int Time3 { get; set; }
        [Display(Name = "Quarto time do grupo")]
        public int Time4 { get; set; }
        [Display(Name = "Código do grupo")]
        public int IdGrupo { get; set; }
    }
}
