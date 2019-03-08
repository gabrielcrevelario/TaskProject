using System.Collections.Generic;
using System.Linq;
using TaskManager.Data.Context;
using TaskProject.Domain.Entities;
using TaskProject.Domain.Repositories;

namespace Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private TaskManagerContext Context { get; }

        public TarefaRepository(TaskManagerContext context)
        {
            Context = context;
        }

        public void Create(Tarefa tarefa)
        {
            Context.Tarefa.Add(tarefa);
            Context.SaveChanges();
        }

        public void Delete(long idTask)
        {
            var tarefa = Context.Tarefa.Find(idTask);
            Context.Remove(tarefa);
            Context.SaveChanges();
        }

        public List<Tarefa> GetAll()
        {
            return Context.Tarefa.Select(x => x).ToList();
        }

        public void Update(long idTask, Tarefa tarefa)
        {
            var findTarefa = Context.Tarefa.Any(x=> x.Id == idTask);
            if(findTarefa)
            {
                Context.Tarefa.Update(tarefa);
                Context.SaveChanges();
            }else
            {
                throw new System.Exception("Tarefa não encontrada");
            }
        }
    }
}
