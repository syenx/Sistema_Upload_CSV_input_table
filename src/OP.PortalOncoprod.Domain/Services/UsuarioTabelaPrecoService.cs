using OP.PortalOncoprod.Domain.DTO;
using OP.PortalOncoprod.Domain.Entities;
using OP.PortalOncoprod.Domain.Interfaces.Repository;
using OP.PortalOncoprod.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace OP.PortalOncoprod.Domain.Services
{
    public class UsuarioTabelaPrecoService : IUsuarioTabelaPrecoService
    {
        private readonly IUsuarioTabelaPrecoRepository _usuario;

        public UsuarioTabelaPrecoService(IUsuarioTabelaPrecoRepository usuario)
        {
            _usuario = usuario;
        }

        public void Dispose()
        {
            _usuario.Dispose();
            GC.SuppressFinalize(this);
        }

        public UsuarioTabelaPreco ObterPorUsuarioId(string usuarioId)
        {
            UsuarioTabelaPreco users = new UsuarioTabelaPreco();
            users.listaUsuarioTabela = _usuario.ObterPorUsuarioId(usuarioId);
            return users;
        }

    }
}

