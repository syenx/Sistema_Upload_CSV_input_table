using OP.PortalOncoprod.Domain.DTO;
using OP.PortalOncoprod.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.PortalOncoprod.Domain.Interfaces.Repository
{
    public interface IGrupoSistemaTabelaPrecoRepository : IRepository<GrupoSistemaTabelaPreco>
    {
        GrupoSistemaTabelaPreco ObterPorDescricao(string descricao);
        void ObterPorCodigo(int id);
        Paged<GrupoSistemaTabelaPreco> ObterTodos(string nome, int pageSize, int pageNumber);

    }
}
