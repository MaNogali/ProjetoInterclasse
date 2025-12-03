
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using ProjetoInterclasse.Models;
using ProjetoInterclasse.Data;
using ProjetoInterclasse.Models;

namespace ProjetoInterclasse.Controllers
{
    public class SistemaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // MENU PRINCIPAL
        public ActionResult Index()
        {
            return View();
        }

        // ------------------ ALUNO ------------------
        public ActionResult CadastroAluno()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroAluno(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                db.Aluno.Add(aluno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult ListaAlunos()
        {
            var alunos = db.Aluno.ToList();
            return View(alunos);
        }

        // ------------------ TIME ------------------
        public ActionResult CadastroTime()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroTime(Time time)
        {
            if (ModelState.IsValid)
            {
                db.Time.Add(time);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(time);
        }

        public ActionResult ListaTimes()
        {
            var times = db.Time.ToList();
            return View(times);
        }

        // ------------------ PARTIDA ------------------
        public ActionResult CadastroPartida()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroPartida(Partida partida)
        {
            if (ModelState.IsValid)
            {
                db.Partida.Add(partida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partida);
        }

        // ------------------ GRUPO ------------------
        public ActionResult CadastroGrupo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroGrupo(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                db.Grupo.Add(grupo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grupo);
        }

        // ------------------ CHAVEAMENTO ------------------
        public ActionResult CadastroChaveamento()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroChaveamento(Chaveamento chave)
        {
            if (ModelState.IsValid)
            {
                db.Chaveamento.Add(chave);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chave);
        }

        // ------------------ CLASSIFICACAO ------------------
        public ActionResult CadastroClassificacao()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroClassificacao(Classificacao classificacao)
        {
            if (ModelState.IsValid)
            {
                db.Classificacoes.Add(classificacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classificacao);
        }
    }
}
