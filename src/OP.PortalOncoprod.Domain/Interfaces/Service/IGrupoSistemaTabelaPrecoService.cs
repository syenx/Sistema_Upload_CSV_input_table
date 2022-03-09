using OP.PortalOncoprod.Domain.DTO;
using OP.PortalOncoprod.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.PortalOncoprod.Domain.Interfaces.Service
{
    public interface IGrupoSistemaTabelaPrecoService : IDisposable
    {
        GrupoSistemaTabelaPreco Adicionar(GrupoSistemaTabelaPreco tabelaPrecoOncoprod);
        GrupoSistemaTabelaPreco ObterPorId(int id);
        void ObterPorCodigo(int id);
        GrupoSistemaTabelaPreco ObterPorDescricao(string descricao);
        Paged<GrupoSistemaTabelaPreco> ObterTodos(string nome, int pageSize, int pageNumber);
        GrupoSistemaTabelaPreco Atualizar(GrupoSistemaTabelaPreco tabelaPrecoOncoprod);
    
        void Remover(int id);
    }
}
