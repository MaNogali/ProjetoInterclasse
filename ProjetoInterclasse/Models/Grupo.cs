using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Grupo
    {
        [Display(Name = "Código da modalidade")]
        public int idmodalidade { get; set; }
        [Display(Name = "Primeiro time do grupo")]
        public string? time1 { get; set; }
        [Display(Name = "Segundo time do grupo")]
        public string? time2 { get; set; }
        [Display(Name = "Terceiro time do grupo")]
        public int time3 { get; set; }
        [Display(Name = "Quarto time do grupo")]
        public int time4 { get; set; }
        [Display(Name = "Código do grupo")]
        public int idGrupo { get; set; }
    }
}
