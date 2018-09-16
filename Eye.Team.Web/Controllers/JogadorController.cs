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
    public class JogadorController : Controller
    {
        private IRepositorioGenerico<Jogador, int> repositorioJogador = new JogadoreRepositorios(new EyeTeamDbContext());

        // GET: Jogador
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Jogador>, List<JogadorExibicaoViewModel>>(repositorioJogador.Selecionar()));
        }

        // GET: Jogador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Jogador jogador = repositorioJogador.SelecionarPorId(id.Value);

            if (jogador == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Jogador, JogadorExibicaoViewModel>(jogador));
        }

        // GET: Jogador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jogador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdJogador,Nome,Idade,IdTime")] JogadorViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Jogador jogador = Mapper.Map<JogadorViewModel, Jogador>(viewModel);

                repositorioJogador.Inserir(jogador);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Jogador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Jogador jogador = repositorioJogador.SelecionarPorId(id.Value);

            if (jogador == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Jogador, JogadorViewModel>(jogador));
        }

        // POST: Jogador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdJogador,Nome,Idade,IdTime")] JogadorViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Jogador jogador = Mapper.Map<JogadorViewModel, Jogador>(viewModel);

                repositorioJogador.Alterar(jogador);

                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Jogador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Jogador jogador = repositorioJogador.SelecionarPorId(id.Value);

            if (jogador == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Jogador, JogadorExibicaoViewModel>(jogador));
        }

        // POST: Jogador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioJogador.ExcluirPorId(id);

            return RedirectToAction("Index");
        }
    }
}
