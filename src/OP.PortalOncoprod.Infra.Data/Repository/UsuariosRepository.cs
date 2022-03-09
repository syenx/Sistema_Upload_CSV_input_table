﻿using System.Linq;
using OP.PortalOncoprod.Domain.Entities;
using OP.PortalOncoprod.Domain.Interfaces.Repository;
using OP.PortalOncoprod.Infra.Data.Context;
using Dapper;
using System.Web.Security;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using OP.PortalOncoprod.Domain.DTO;

namespace OP.PortalOncoprod.Infra.Data.Repository
{
    public class UsuariosRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuariosRepository(PortalOncoprodContext context) 
            : base(context)
        {

        }

        public Usuario ObterPorEmail(string email)
        {
            return Buscar(u => u.usuarioEmail == email).FirstOrDefault();
        }

        public Usuario ObterPorLogin(string login, string senha)
        {

            var cn = Db.Database.Connection;

            var sql = @"SELECT * FROM ksUsuario WITH (NOLOCK)" +
                      "WHERE (@Login IS NULL OR usuarioLogin = @Login)" +
                      "AND (@Senha IS NULL OR usuarioSenha = @Senha)";

            var multi = cn.QueryMultiple(sql, new { Login = login, Senha = senha });
            var usuario = multi.Read();

            Usuario usuarioResult = new Usuario();

            foreach (var item in usuario)
            {
                usuarioResult.usuarioLogin = item.usuarioLogin;
                usuarioResult.usuarioSenha = item.usuarioSenha;
            }

            return usuarioResult;

            //return Buscar(u => u.usuarioLogin.Equals(login) && u.usuarioSenha.Equals(senha)).First();
        }

        public static bool AutenticarUsuario(string login, string senha)
        {

            PortalOncoprodContext Context = new PortalOncoprodContext();

             var Query = (from u in Context.Usuarios
                          where u.usuarioLogin.Equals(login)
                          && u.usuarioSenha.Equals(senha)
                          select u).SingleOrDefault();

            if(Query == null)
            {
                return false;
            }

            FormsAuthentication.SetAuthCookie(Query.usuarioLogin, false);

            return true;
        }

        public static Usuario GetUsuarioLogado()
        {
            string _Login = HttpContext.Current.User.Identity.Name;

            if(_Login == string.Empty)
            {
                return null;
            }
            else
            {
                PortalOncoprodContext Context = new PortalOncoprodContext();

                Usuario user = (from u in Context.Usuarios
                                where u.usuarioLogin.Equals(_Login)
                                select u).SingleOrDefault();

                return user;
            }

        }

        public Paged<Usuario> ObterTodos()
        {
            var cn = Db.Database.Connection;
            cn.Open();
            var sql = @"SELECT UsuarioId,usuarioNome FROM KsUsuario  (nolock) where usuarioTipoId in ('REP', 'GER')";


            var multi = cn.QueryMultiple(sql);
            var usuarios = multi.Read<Usuario>();
            //var total = multi.Read<int>().FirstOrDefault();


            var pagedList = new Paged<Usuario>()
            {

                List = usuarios
                //Count = total
            };
            cn.Close();
            return pagedList;
        }

        public static void Deslogar()
        {
            FormsAuthentication.SignOut();
        }

       
    }
}
