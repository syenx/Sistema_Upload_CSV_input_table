using AutoMapper;
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
    public class UsuarioTabelaAppService : ApplicationService, IUsuarioTabelaPrecoAppService
    {

        private readonly IUsuarioTabelaPrecoService _usuarioService;

        public UsuarioTabelaAppService(IUsuarioTabelaPrecoService usuarioService, IUnitOfWork uow)
            : base(uow)
        {
            _usuarioService = usuarioService;
        }

        public void Dispose()
        {
            _usuarioService.Dispose();
            GC.SuppressFinalize(this);
        }

        public UsuarioTabelaPrecoViewModel ObterPorUsuarioId(string usuarioId)
        {
            return Mapper.Map<UsuarioTabelaPrecoViewModel>(_usuarioService.ObterPorUsuarioId(usuarioId));
        }

    }
}
