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
    public class TimeController : Controller
    {
        private IRepositorioGenerico<Time, int> repositorioTime = new TimeRepositorio(new EyeTeamDbContext());

        // GET: Time
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Time>, List<TimeExibicaoViewModel>>(repositorioTime.Selecionar()));
        }

        // GET: Time/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Time time = repositorioTime.SelecionarPorId(id.Value);

            if (time == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Time, TimeExibicaoViewModel>(time));
        }

        // GET: Time/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Time/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTime,Nome,IdCidade")] TimeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Time Time = Mapper.Map<TimeViewModel, Time>(viewModel);

                repositorioTime.Inserir(Time);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Time/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Time time = repositorioTime.SelecionarPorId(id.Value);

            if (time == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Time, TimeViewModel>(time));
        }

        // POST: Time/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTime,Nome,IdCidade")] TimeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Time time = Mapper.Map<TimeViewModel, Time>(viewModel);

                repositorioTime.Alterar(time);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Time/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Time time = repositorioTime.SelecionarPorId(id.Value);

            if (time == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map<Time, TimeExibicaoViewModel>(time));
        }

        // POST: Time/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioTime.ExcluirPorId(id);

            return RedirectToAction("Index");
        }        
    }
}
