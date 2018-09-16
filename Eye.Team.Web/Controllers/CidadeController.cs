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
    public class CidadeController : Controller
    {
        private IRepositorioGenerico<Cidade, int> repositorioCidade = new CidadeRepositorio(new EyeTeamDbContext());

        // GET: Cidade
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Cidade>, List<CidadeExibicaoViewModel>>(repositorioCidade.Selecionar()));
        }

        // GET: Cidade/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidade cidade = repositorioCidade.SelecionarPorId(id.Value);

            if (cidade == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Cidade, CidadeExibicaoViewModel>(cidade));
        }

        // POST: Cidade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCidade,Nome,IdEstado")] CidadeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Cidade cidade = Mapper.Map<CidadeViewModel, Cidade>(viewModel);

                repositorioCidade.Inserir(cidade);

                return RedirectToAction("Index");
            }

            //ViewBag.IdEstado = new SelectList(db.Estados, "IdEstado", "Nome", cidade.IdEstado);
            return View(viewModel);
        }

        // GET: Cidade/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidade cidade = repositorioCidade.SelecionarPorId(id.Value);

            if (cidade == null)
            {
                return HttpNotFound();
            }
            //ViewBag.IdEstado = new SelectList(db.Estados, "IdEstado", "Nome", cidade.IdEstado);

            return View(Mapper.Map<Cidade, CidadeViewModel>(cidade));
        }

        // POST: Cidade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCidade,Nome,IdEstado")] CidadeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Cidade cidade = Mapper.Map<CidadeViewModel, Cidade>(viewModel);

                repositorioCidade.Alterar(cidade);

                return RedirectToAction("Index");
            }
            //ViewBag.IdEstado = new SelectList(db.Estados, "IdEstado", "Nome", cidade.IdEstado);

            return View(viewModel);
        }

        // GET: Cidade/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidade cidade = repositorioCidade.SelecionarPorId(id.Value);

            if (cidade == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Cidade, CidadeExibicaoViewModel>(cidade));
        }

        // POST: Cidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioCidade.ExcluirPorId(id);

            return RedirectToAction("Index");
        }
    }
}
