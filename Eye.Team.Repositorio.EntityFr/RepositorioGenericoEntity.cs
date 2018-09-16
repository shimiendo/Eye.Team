using Eye.Team.Repositorios.Comum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;

namespace Eye.Team.Repositorio.EntityFr
{
    public class RepositorioGenericoEntity<TEntidade, TChave> : IRepositorioGenerico<TEntidade, TChave>
            where TEntidade : class
    {
        protected DbContext _contexto;

        public RepositorioGenericoEntity(DbContext contexto)
        {
            _contexto = contexto;
        }
        public virtual List<TEntidade> Selecionar()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public virtual TEntidade SelecionarPorId(TChave id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }

        public void Inserir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Add(entidade);

            _contexto.SaveChanges();
        }

        public void Alterar(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;

            _contexto.SaveChanges();
        }

        public void Excluir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Deleted;

            _contexto.SaveChanges();
        }

        public void ExcluirPorId(TChave id)
        {
            TEntidade entidade = SelecionarPorId(id);

            Excluir(entidade);
        }
    }
}