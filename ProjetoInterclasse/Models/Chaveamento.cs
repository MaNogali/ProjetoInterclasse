using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Chaveamento
    {
        [Display(Name = "Código da partida")]
        public int idPartida { get; set; }
        [Display(Name = "Código da fase que estamos")]
        public string? idChave { get; set; }
        [Display(Name = "Fase que será jogada")]
        public string? fase { get; set; }
        [Display(Name = "Segundo time do chavemento")]
        public int time1 { get; set; }
        [Display(Name = "Primeiro time do chavemento")]
        public int time2 { get; set; }
    }
}
