using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Chaveamento
    {
        [Display(Name = "Código da partida")]
        public int IdPartida { get; set; }
        [Display(Name = "Código da fase que estamos")]
        public int IdChave { get; set; }
        [Display(Name = "Fase que será jogada")]
        public string? Fase { get; set; }
        [Display(Name = "Segundo time do chavemento")]
        public int Time1 { get; set; }
        [Display(Name = "Primeiro time do chavemento")]
        public int Time2 { get; set; }
    }
}
