using OP.PortalOncoprod.Application.ViewModels;

using System;
using System.Collections.Generic;

namespace OP.PortalOncoprod.Application.Interfaces
{
    public interface IUsuarioTabelaPrecoAppService : IDisposable
    {
        UsuarioTabelaPrecoViewModel ObterPorUsuarioId(string usuarioId);
    }
}
