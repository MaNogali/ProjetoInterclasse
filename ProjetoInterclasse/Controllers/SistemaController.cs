
using Microsoft.AspNetCore.Mvc;
using ProjetoInterclasse.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoInterclasse.Controllers
{
    public class SistemaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SistemaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // MENU PRINCIPAL
        public IActionResult Index()
        {
            return View();
        }

        // ------------------ ALUNO ------------------
        public IActionResult CadastroAluno()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroAluno(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Alunos.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        public async Task<IActionResult> ListaAlunos()
        {
            var alunos = await _context.Alunos.ToListAsync();
            return View(alunos);
        }

        // ------------------ TIME ------------------
        public IActionResult CadastroTime()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroTime(Time time)
        {
            if (ModelState.IsValid)
            {
                _context.Times.Add(time);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(time);
        }

        public async Task<IActionResult> ListaTimes()
        {
            var times = await _context.Times.ToListAsync();
            return View(times);
        }

        // ------------------ PARTIDA ------------------
        public IActionResult CadastroPartida()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroPartida(Partida partida)
        {
            if (ModelState.IsValid)
            {
                _context.Partidas.Add(partida);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partida);
        }

        // ------------------ GRUPO ------------------
        public IActionResult CadastroGrupo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroGrupo(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                _context.Grupos.Add(grupo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grupo);
        }

        // ------------------ CHAVEAMENTO ------------------
        public IActionResult CadastroChaveamento()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroChaveamento(Chaveamento chave)
        {
            if (ModelState.IsValid)
            {
                _context.Chaveamentos.Add(chave);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chave);
        }

        // ------------------ CLASSIFICACAO ------------------
        public IActionResult CadastroClassificacao()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroClassificacao(Classificacao classificacao)
        {
            if (ModelState.IsValid)
            {
                _context.Classificacoes.Add(classificacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classificacao);
        }
    }
}