using System;
using System.Collections.Generic;
using OP.PortalOncoprod.Domain.DTO;
using OP.PortalOncoprod.Domain.Entities;

namespace OP.PortalOncoprod.Domain.Interfaces.Service
{
    public interface IUsuarioService : IDisposable
    {
        Usuario Adicionar(Usuario usuario);
        Usuario ObterPorLogin(string login, string senha);
        Usuario ObterPorEmail(string email);
        Paged<Usuario> ObterTodos();
    }
}
