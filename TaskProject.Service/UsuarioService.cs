using System;
using System.Collections.Generic;
using System.Text;
using TaskProject.Domain.Entities;
using TaskProject.Domain.Services;
using UserProject.Domain.Repositories;

namespace TaskManger.Services
{
    public class UsuarioService : IUsuarioService
    {
        public IUsuarioRepository UsuarioRepository { get; }

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            UsuarioRepository = usuarioRepository;
        }
        public void Create(Usuario user)
        {
            UsuarioRepository.Create(user);
        }

        public void Delete(long idUser)
        {
            UsuarioRepository.Delete(idUser);
        }

        public List<Usuario> GetAll()
        {
           return UsuarioRepository.GetAll();
        }

        public void Update(long idUser, Usuario user)
        {
            UsuarioRepository.Update(idUser, user);
        }
    }
}
