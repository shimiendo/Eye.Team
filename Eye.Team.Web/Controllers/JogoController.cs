using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Eye.Team.AcessoDadosEntity.Contexto;
using Eye.Team.Dominio;
using Eye.Team.Repositorios.Comum;
using Eye.Team.Repositorios.Entity;
using Eye.Team.Web.ViewModels;

namespace Eye.Team.Web.Controllers
{
    public class JogoController : Controller
    {
        private IRepositorioGenerico<Jogo, int> repositorioJogo = new JogoRepositorio(new EyeTeamDbContext());

        // GET: Jogo
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Jogo>, List<JogoExibicaoViewModel>>(repositorioJogo.Selecionar()));
        }

        // GET: Jogo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Jogo jogo = repositorioJogo.SelecionarPorId(id.Value);

            if (jogo == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Jogo, JogoExibicaoViewModel>(jogo));
        }

        // GET: Jogo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jogo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdJogo,DataJogo,QtdeGolTime1,QtdeGolTime2,IdTime1,IdTime2")] JogoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Jogo jogo = Mapper.Map<JogoViewModel, Jogo>(viewModel);

                repositorioJogo.Inserir(jogo);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Jogo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Jogo jogo = repositorioJogo.SelecionarPorId(id.Value);

            if (jogo == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Jogo, JogoViewModel>(jogo));
        }

        // POST: Jogo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdJogo,DataJogo,QtdeGolTime1,QtdeGolTime2,IdTime1,IdTime2")] JogoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Jogo jogo = Mapper.Map<JogoViewModel, Jogo>(viewModel);

                repositorioJogo.Alterar(jogo);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Jogo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Jogo jogo = repositorioJogo.SelecionarPorId(id.Value);

            if (jogo == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Jogo, JogoExibicaoViewModel>(jogo));
        }

        // POST: Jogo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioJogo.ExcluirPorId(id);

            return RedirectToAction("Index");
        }        
    }
}
