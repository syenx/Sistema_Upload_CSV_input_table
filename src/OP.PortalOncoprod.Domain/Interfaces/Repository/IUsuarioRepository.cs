using OP.PortalOncoprod.Domain.DTO;
using OP.PortalOncoprod.Domain.Entities;
using System.Collections.Generic;

namespace OP.PortalOncoprod.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario ObterPorLogin(string login, string senha);
        Usuario ObterPorEmail(string email);
        Paged<Usuario> ObterTodos();
    }
}
