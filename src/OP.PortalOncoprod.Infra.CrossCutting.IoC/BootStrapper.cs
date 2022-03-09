using OP.PortalOncoprod.Application;
using OP.PortalOncoprod.Application.Interfaces;
using OP.PortalOncoprod.Domain.Interfaces.Repository;
using OP.PortalOncoprod.Domain.Interfaces.Service;
using OP.PortalOncoprod.Domain.Services;
using OP.PortalOncoprod.Infra.CrossCutting.Logging.Data;
using OP.PortalOncoprod.Infra.CrossCutting.Logging.Helpers;
using OP.PortalOncoprod.Infra.Data.Context;
using OP.PortalOncoprod.Infra.Data.Interfaces;
using OP.PortalOncoprod.Infra.Data.Repository;
using OP.PortalOncoprod.Infra.Data.UoW;
using SimpleInjector;

namespace OP.PortalOncoprod.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App
            
            container.Register<ITabelaPrecoOncoprodAppService, TabelaPrecoOncoprodAppService>(Lifestyle.Scoped);
            container.Register<IUsuarioTabelaPrecoAppService, UsuarioTabelaAppService>(Lifestyle.Scoped);
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
            container.Register<IGrupoSistemaTabelaPrecoAppService, GrupoSistemaTabelaPrecoAppService>(Lifestyle.Scoped);



            // Domain
            container.Register<IUsuarioTabelaPrecoService, UsuarioTabelaPrecoService>(Lifestyle.Scoped);

            container.Register<ITabelaPrecoOncoprodService, TabelaPrecoOncoprodService>(Lifestyle.Scoped);
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
            container.Register<IGrupoSistemaTabelaPrecoService, GrupoSistemaTabelaPrecoService>(Lifestyle.Scoped);
            


            // Infra Dados

            container.Register<ITabelaPrecoOncoprodRepository, TabelaPrecoOncoprodRepository>(Lifestyle.Scoped);
            container.Register<IUsuarioTabelaPrecoRepository, UsuarioTabelaPrecoRepository>(Lifestyle.Scoped);
            container.Register<IGrupoSistemaTabelaPrecoRepository, GrupoSistemaTabelaPrecoRepository>(Lifestyle.Scoped);
            container.Register<IUsuarioRepository, UsuariosRepository>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<PortalOncoprodContext>(Lifestyle.Scoped);

            
            
            //container.Register(typeof (IRepository<>), typeof (Repository<>));

            // Logging
            container.Register<ILogAuditoria, LogAuditoriaHelper>(Lifestyle.Scoped);
            container.Register<LogginContext>(Lifestyle.Scoped);
        }
    }
}