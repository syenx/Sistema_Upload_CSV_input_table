using OP.PortalOncoprod.Domain.DTO;
using OP.PortalOncoprod.Domain.Entities;
using System;

namespace OP.PortalOncoprod.Domain.Interfaces.Service
{
    public interface ITabelaPrecoOncoprodService : IDisposable
    {
        TabelaPrecoOncoprod Adicionar(TabelaPrecoOncoprod tabelaPrecoOncoprod);
        TabelaPrecoOncoprod ObterPorId(int id);
        void ObterPorCodigo(string id);
        TabelaPrecoOncoprod ObterPorDescricao(string descricao);
        TabelaPrecoOncoprod ObterPorNomeQuimico(string nomeQuimico);
        TabelaPrecoOncoprod ObterPorLaboratorio(string laboratorio);
        Paged<TabelaPrecoOncoprod> ObterTodos(string nome, int pageSize, int pageNumber);
        TabelaPrecoOncoprod Atualizar(TabelaPrecoOncoprod tabelaPrecoOncoprod);
        void ExcluirExcel();
        void Remover(int id);
        TabelaPrecoOncoprod ObterPorIdTabela(int id);
    }
}
