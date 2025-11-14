using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Classificacao
    {
        [Display(Name = "Código da partida")]
        public int idPartida { get; set; }
        [Display(Name = "Cartões amarelos do jogo")]
        public string? cartaoAmarelo { get; set; }
        [Display(Name = "Cartões vermelhos do jogo")]
        public string? cartaoVermelho { get; set; }
        [Display(Name = "Gols marcados")]
        public int golsMarcados { get; set; }
        [Display(Name = "Gols sofridos")]
        public int golsSofridos { get; set; }
        [Display(Name = "Saldo da partida")]
        public int saldoGols { get; set; }
        [Display(Name = "time foi classificado")]
        public string? statusTime { get; set; }
        [Display(Name = "Quantos pontos o time fez")]
        public string? pontos { get; set; }
        [Display(Name = "Qual grupo")]
        public int grupo { get; set; }
        [Display(Name = "Código do time")]
        public int idTime { get; set; }
        [Display(Name = "Código da modalidade")]
        public int idModalidade { get; set; }
    }
}
