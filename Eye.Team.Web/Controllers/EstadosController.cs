using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eye.Team.AcessoDadosEntity.Contexto;
using Eye.Team.Dominio;
using Eye.Team.Repositorios.Comum;
using Eye.Team.Repositorios.Entity;
using AutoMapper;
using Eye.Team.Web.ViewModels;

namespace Eye.Team.Web
{
    public class EstadosController : Controller    {
        
        private IRepositorioGenerico<Estado, int> repositorioEstado = new EstadoRepositorio(new EyeTeamDbContext());

        // GET: Estados
        public ActionResult Index()
        {            
            return View(Mapper.Map<List<Estado>, List<EstadoExibicaoViewModel>>(repositorioEstado.Selecionar()));
        }

        // GET: Estados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Estado estado = repositorioEstado.SelecionarPorId(id.Value);

            if (estado == null)
            {
                return HttpNotFound();
            }
            
            return View(Mapper.Map<Estado, EstadoExibicaoViewModel>(estado));
        }

        // GET: Estados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEstado,Nome,Uf")] EstadoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Estado estado = Mapper.Map<EstadoViewModel, Estado>(viewModel);

                repositorioEstado.Inserir(estado);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Estados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Estado estado = repositorioEstado.SelecionarPorId(id.Value);

            if (estado == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Estado, EstadoViewModel>(estado));
        }

        // POST: Estados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEstado,Nome,Uf")] EstadoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Estado estado = Mapper.Map<EstadoViewModel, Estado>(viewModel);

                repositorioEstado.Alterar(estado);

                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Estados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Estado estado = repositorioEstado.SelecionarPorId(id.Value);

            if (estado == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Estado, EstadoExibicaoViewModel>(estado));
        }

        // POST: Estados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioEstado.ExcluirPorId(id);

            return RedirectToAction("Index");
        }
    }
}
