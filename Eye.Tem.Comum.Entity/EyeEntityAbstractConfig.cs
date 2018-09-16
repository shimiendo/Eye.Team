using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.Comum.Entity
{
    public abstract class EyeEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public EyeEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChaveEstrangeira();
        }

        protected abstract void ConfigurarChaveEstrangeira();
        protected abstract void ConfigurarChavePrimaria();
        protected abstract void ConfigurarCamposTabela();
        protected abstract void ConfigurarNomeTabela();
    }
}
