using suati3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace suati3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa {
                    pessoaId = 1,
                    nome = "Pedro felipe",
                    twitter = "@fellypeavelino"
            };
            /*
            ViewData array
            ViewBag objeto
            View(pessoa) declarar na view o tipo dela
            */
            ViewData["pessoaId"] = pessoa.pessoaId;
            ViewData["pessoaNome"] = pessoa.nome;
            ViewData["pessoaTwitter"] = pessoa.twitter;

            ViewBag.pessoaId = pessoa.pessoaId;
            ViewBag.pessoaNome = pessoa.nome;
            ViewBag.pessoaTwitter = pessoa.twitter;
            return View(pessoa);
        }

        faculdadeEntities db = new faculdadeEntities();//procurar : DbContext
        

        public ActionResult ListaAluno()
        {
            return View(db.alunos.ToList());
        }
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)//views tipadas
        {
            /*ViewData["pessoaId"] = pessoa.pessoaId;
            ViewData["pessoaNome"] = pessoa.nome;
            ViewData["pessoaTwitter"] = pessoa.twitter;*/
            return View(pessoa);
        }

        public ActionResult ListaMultipla()
        {
            var listaPessoas = new List<Pessoa>();
            return View(listaPessoas);
        }
        /*
        public ActionResult Lista(FormCollection form)
        {
            ViewData["pessoaId"] = form["pessoaId"];
            ViewData["pessoaNome"] = form["nome"];
            ViewData["pessoaTwitter"] = form["twitter"];
            return View();
        }

        public ActionResult Lista(
            int pessoaId, 
            String nome, 
            String twitter
            )
        {
            ViewData["pessoaId"] = pessoaId;
            ViewData["pessoaNome"] = nome;
            ViewData["pessoaTwitter"] = twitter;
            return View();
        }
        */
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}