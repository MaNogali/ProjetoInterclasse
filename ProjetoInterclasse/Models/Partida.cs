using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Partida
    {
        [Display(Name = "Código da partida")]
        public int idPartida { get; set; }
        [Display(Name = "Placar do jogo")]
        public string? placar { get; set; }
        [Display(Name = "Data e hora da partida")]
        public string? horarioDia { get; set; }
        [Display(Name = "Descrição do jogo")]
        public int descricao { get; set; }
        [Display(Name = "Aula que o jogo ocorreu")]
        public int aulaOcorrida { get; set; }
    }
}
