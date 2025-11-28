using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Partida
    {
        [Display(Name = "Código da partida")]
        public int IdPartida { get; set; }
        [Display(Name = "Placar do jogo")]
        public string? Placar { get; set; }
        [Display(Name = "Data e hora da partida")]
        public string? HorarioDia { get; set; }
        [Display(Name = "Descrição do jogo")]
        public int Descricao { get; set; }
        [Display(Name = "Aula que o jogo ocorreu")]
        public int AulaOcorrida { get; set; }
    }
}
