using System.Collections.Generic;
using TaskProject.Domain.Entities;

namespace TaskProject.Domain.Services
{
    public interface IUsuarioService
    {
        List<Usuario> GetAll();
        void Delete(long idUser);
        void Update(long idUser, Usuario user);
        void Create(Usuario user);
    }
}
