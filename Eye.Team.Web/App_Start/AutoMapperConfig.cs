using AutoMapper;
using Eye.Team.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configurar()
        {
            // Adicionando uma perfil para se chamda na inicialização do Global.asax
            //Mapper.Add
            Mapper.AddProfile<DominioParaViewModelProfile>();
            Mapper.AddProfile<ViewModelParaDominioProfile>();
        }
    }
}