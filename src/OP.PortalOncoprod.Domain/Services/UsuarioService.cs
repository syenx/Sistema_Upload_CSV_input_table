using System;
using OP.PortalOncoprod.Domain.Interfaces.Service;
using OP.PortalOncoprod.Domain.Entities;
using OP.PortalOncoprod.Domain.Interfaces.Repository;
using System.Collections.Generic;
using OP.PortalOncoprod.Domain.DTO;

namespace OP.PortalOncoprod.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public Usuario ObterPorEmail(string email)
        {
            return _usuarioRepository.ObterPorEmail(email);
        }

        public Usuario ObterPorLogin(string login, string senha)
        {
            return _usuarioRepository.ObterPorLogin(login, senha);
        }
        public void Dispose()
        {
            _usuarioRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Usuario Adicionar(Usuario usuario)
        {
         
            return _usuarioRepository.Adicionar(usuario);
        }

        public Paged<Usuario> ObterTodos()
        {
            return _usuarioRepository.ObterTodos();
        }
    }
}
