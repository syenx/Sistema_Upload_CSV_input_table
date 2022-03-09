using AutoMapper;
using OP.PortalOncoprod.Application.ViewModels;
using OP.PortalOncoprod.Domain.DTO;
using OP.PortalOncoprod.Domain.Entities;

namespace OP.PortalOncoprod.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UsuarioTabelaPreco, UsuarioTabelaPrecoViewModel>();
            CreateMap<GrupoSistemaTabelaPreco, GrupoSistemaTabelaPrecoViewModel>();
            CreateMap<TabelaPrecoOncoprod, TabelaPrecoOncoprodViewModel>();
            CreateMap<Paged<TabelaPrecoOncoprod>, PagedViewModel<TabelaPrecoOncoprodViewModel>>();
            CreateMap<Paged<Usuario>, PagedViewModel<UsuarioViewModel>>();
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<PerfilAcesso, PerfilAcessoViewModel>();
        }
    }
}