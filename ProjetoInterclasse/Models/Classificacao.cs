using System.ComponentModel.DataAnnotations;

namespace ProjetoInterclasse.Models
{
    public class Classificacao
    {
        [Display(Name = "Código da partida")]
        public int IdPartida { get; set; }
        [Display(Name = "Cartões amarelos do jogo")]
        public int CartaoAmarelo { get; set; }
        [Display(Name = "Cartões vermelhos do jogo")]
        public int CartaoVermelho { get; set; }
        [Display(Name = "Gols marcados")]
        public int GolsMarcados { get; set; }
        [Display(Name = "Gols sofridos")]
        public int GolsSofridos { get; set; }
        [Display(Name = "Saldo da partida")]
        public int SaldoGols { get; set; }
        [Display(Name = "time foi classificado")]
        public string? StatusTime { get; set; }
        [Display(Name = "Quantos pontos o time fez")]
        public int Pontos { get; set; }
        [Display(Name = "Qual grupo")]
        public int Grupo { get; set; }
        [Display(Name = "Código do time")]
        public int IdTime { get; set; }
        [Display(Name = "Código da modalidade")]
        public int IdModalidade { get; set; }
        [Display(Name = "Código da chave")]
        public int IdChave { get; set; }
    }
}
