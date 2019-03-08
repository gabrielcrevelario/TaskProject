using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Data.Context;
using TaskProject.Domain.Entities;
using UserProject.Domain.Repositories;

namespace Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private TaskManagerContext Context { get; }

        public UsuarioRepository(TaskManagerContext context)
        {
            Context = context;
        }
        public void Create(Usuario usuario)
        {
            Context.Usuario.Add(usuario);
            Context.SaveChanges();
        }

        public void Delete(long idUser)
        {
            var usuario = Context.Usuario.Find(idUser);
            Context.Remove(usuario);
            Context.SaveChanges();
        }

        public List<Usuario> GetAll()
        {
            return Context.Usuario.ToList();
        }

        public void Update(long idUser, Usuario usuario)
        {
            Context.Usuario.Update(usuario);
            Context.SaveChanges();
        }
    }
}
