using OP.PortalOncoprod.Application.Interfaces;
using OP.PortalOncoprod.Application.ViewModels;
using OP.PortalOncoprod.Domain.Interfaces.Service;
using OP.PortalOncoprod.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP.PortalOncoprod.Application
{
    public class GrupoSistemaTabelaPrecoAppService : ApplicationService, IGrupoSistemaTabelaPrecoAppService
    {
        private readonly IGrupoSistemaTabelaPrecoService _grupoTabelaService;

        public GrupoSistemaTabelaPrecoAppService(IGrupoSistemaTabelaPrecoService grupoTabelaService, IUnitOfWork uow)
            : base(uow)
        {
            _grupoTabelaService = grupoTabelaService;
        }

        public GrupoSistemaTabelaPrecoViewModel Adicionar(GrupoSistemaTabelaPrecoViewModel grupoSistemaTabela)
        {
            throw new NotImplementedException();
        }

        public GrupoSistemaTabelaPrecoViewModel Atualizar(GrupoSistemaTabelaPrecoViewModel grupoSistemaTabela)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _grupoTabelaService.Dispose();
            GC.SuppressFinalize(this);
        }

        public void ObterPorCodigo(int id)
        {
            throw new NotImplementedException();
        }

        public GrupoSistemaTabelaPrecoViewModel ObterPorDescricao(string descricao)
        {
            throw new NotImplementedException();
        }

        public GrupoSistemaTabelaPrecoViewModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public PagedViewModel<GrupoSistemaTabelaPrecoViewModel> ObterTodos(string descricao, int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
