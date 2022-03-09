﻿using OP.PortalOncoprod.Domain.DTO;
using OP.PortalOncoprod.Domain.Entities;

namespace OP.PortalOncoprod.Domain.Interfaces.Repository
{
    public interface ITabelaPrecoOncoprodRepository : IRepository<TabelaPrecoOncoprod>
    {
        TabelaPrecoOncoprod ObterPorDescricao(string descricao);
        TabelaPrecoOncoprod ObterPorNomeQuimico(string nomeQuimico);
        TabelaPrecoOncoprod ObterPorLaboratorio(string laboratorio);
        void ExcluirExcel();
        TabelaPrecoOncoprod ObterPorId(int id);
        void ObterPorCodigo(string Codigo);
        Paged<TabelaPrecoOncoprod> ObterTodos(string nome, int pageSize, int pageNumber);
        TabelaPrecoOncoprod ObterPorIdTabela(int id);
    }
}
