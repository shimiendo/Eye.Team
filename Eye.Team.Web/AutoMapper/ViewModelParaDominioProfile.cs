using AutoMapper;
using Eye.Team.Dominio;
using Eye.Team.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<EstadoExibicaoViewModel, Estado>();
            Mapper.CreateMap<EstadoViewModel, Estado>();


            Mapper.CreateMap<CidadeExibicaoViewModel, Cidade>();
            Mapper.CreateMap<CidadeViewModel,Estado>();

            Mapper.CreateMap<TimeExibicaoViewModel,Time>();
            Mapper.CreateMap<TimeViewModel, Time>();

            Mapper.CreateMap<JogadorExibicaoViewModel, Jogador>();
            Mapper.CreateMap<JogadorViewModel, Jogador>();

            Mapper.CreateMap<JogoExibicaoViewModel, Jogo>();
            Mapper.CreateMap<JogoViewModel, Jogo>();
        }
    }
}