using AutoMapper;
using Eye.Team.Dominio;
using Eye.Team.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Estado, EstadoExibicaoViewModel>();
            Mapper.CreateMap<Estado, EstadoViewModel>();

            Mapper.CreateMap<Cidade, CidadeExibicaoViewModel>();
            Mapper.CreateMap<Estado, CidadeViewModel>();

            Mapper.CreateMap<Time, TimeExibicaoViewModel>();
            Mapper.CreateMap<Time, TimeViewModel>();

            Mapper.CreateMap<Jogador, JogadorExibicaoViewModel>();
            Mapper.CreateMap<Jogador, JogadorViewModel>();

            Mapper.CreateMap<Jogo, JogoExibicaoViewModel>();
            Mapper.CreateMap<Jogo, JogoViewModel>();
        }
    }
}