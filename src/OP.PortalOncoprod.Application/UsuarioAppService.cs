using OP.PortalOncoprod.Application;
using System;
using OP.PortalOncoprod.Application.Interfaces;
using OP.PortalOncoprod.Application.ViewModels;
using OP.PortalOncoprod.Domain.Interfaces.Service;
using OP.PortalOncoprod.Infra.Data.Interfaces;
using AutoMapper;
using OP.PortalOncoprod.Domain.Entities;
using System.Collections.Generic;

namespace OP.PortalOncoprod.Application
{
    public class UsuarioAppService : ApplicationService, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService, IUnitOfWork uow)
            : base(uow)
        {
            _usuarioService = usuarioService;
        }
        public UsuarioViewModel Adicionar(UsuarioViewModel usuarioViewModel)
        {
            var usuario = Mapper.Map<Usuario>(usuarioViewModel);

            BeginTransaction();

            var usuarioReturn = _usuarioService.Adicionar(usuario);
            usuarioViewModel = Mapper.Map<UsuarioViewModel>(usuarioReturn);

            Commit();

            return usuarioViewModel;
        }

        public UsuarioViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<UsuarioViewModel>(_usuarioService.ObterPorEmail(email));
        }

        public UsuarioViewModel ObterPorLogin(string login, string senha)
        {
            return Mapper.Map<UsuarioViewModel>(_usuarioService.ObterPorLogin(login, senha));
        }

        public void Dispose()
        {
            _usuarioService.Dispose();
            GC.SuppressFinalize(this);
        }

        public PagedViewModel<UsuarioViewModel> ObterTodos()
        {
            return Mapper.Map<PagedViewModel<UsuarioViewModel>>(_usuarioService.ObterTodos());
        }

        //public List<UsuarioViewModel> ObterTodos()
        //{
        //    return Mapper.Map<UsuarioViewModel>(_usuarioService.ObterTodos());
        //}
    }
}
