using AutoMapper;
using OP.PortalOncoprod.Application.ViewModels;
using OP.PortalOncoprod.Domain.Entities;

namespace OP.PortalOncoprod.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UsuarioTabelaPrecoViewModel,UsuarioTabelaPreco>();
            CreateMap<GrupoSistemaTabelaPrecoViewModel, GrupoSistemaTabelaPreco>();
            CreateMap<TabelaPrecoOncoprodViewModel, TabelaPrecoOncoprod>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<PerfilAcessoViewModel, PerfilAcesso>();
        }
    }
}