using System;
using System.Collections.Generic;
using System.Text;
using TaskProject.Domain.Entities;

namespace TarefaProject.Domain.Services
{
    public interface ITarefaService
    {
        List<Tarefa> GetAll();
        void Delete(long idTarefa);
        void Update(long idTarefa, Tarefa Tarefa);
        void Create(Tarefa Tarefa);
    }
}
