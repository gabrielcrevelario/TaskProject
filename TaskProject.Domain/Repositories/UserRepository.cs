using System;
using System.Collections.Generic;
using System.Text;
using TaskProject.Domain.Entities;

namespace UserProject.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        void Delete(long idUser);
        void Update(long idUser, Usuario usuario);
        void Create(Usuario usuario);
    }
}
