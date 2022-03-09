using System;
using System.Collections.Generic;
using OP.PortalOncoprod.Application.AutoMapper;
using OP.PortalOncoprod.Application.ViewModels;

namespace OP.PortalOncoprod.Application.Interfaces
{
    public interface IUsuarioAppService : IDisposable
    {
        UsuarioViewModel Adicionar(UsuarioViewModel usuarioViewModel);
        UsuarioViewModel ObterPorLogin(string login, string senha);
        UsuarioViewModel ObterPorEmail(string email);
        PagedViewModel<UsuarioViewModel> ObterTodos();
    }
}
