using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskProject.Domain.Entities;

namespace TaskProject.Domain.Repositories
{
    public interface ITarefaRepository
    {
        List<Tarefa> GetAll();
        void Delete(long idTask);
        void Update(long idTask, Tarefa tarefa);
        void Create(Tarefa tarefa);
    }
}
