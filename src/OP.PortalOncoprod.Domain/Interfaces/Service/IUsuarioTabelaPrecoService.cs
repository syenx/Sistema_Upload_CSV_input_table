using OP.PortalOncoprod.Domain.DTO;
using OP.PortalOncoprod.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.PortalOncoprod.Domain.Interfaces.Service
{
    public interface IUsuarioTabelaPrecoService : IDisposable
    {

        UsuarioTabelaPreco ObterPorUsuarioId(string usuarioId);

    }
}
