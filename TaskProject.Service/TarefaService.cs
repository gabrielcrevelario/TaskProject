using System;
using System.Collections.Generic;
using System.Text;
using TarefaProject.Domain.Services;
using TaskProject.Domain.Entities;
using TaskProject.Domain.Repositories;

namespace TaskManger.Services
{
    public class TarefaService : ITarefaService
    {
        public ITarefaRepository TarefaRepository { get; set; }

        public TarefaService(ITarefaRepository tarefaRepository)
        {
            TarefaRepository = tarefaRepository;
        }
        public void Create(Tarefa tarefa)
        {
            tarefa.DateLog = DateTime.Now;
            TarefaRepository.Create(tarefa);
        }

        public void Delete(long idTarefa)
        {
            TarefaRepository.Delete(idTarefa);
        }

        public List<Tarefa> GetAll()
        {
           return TarefaRepository.GetAll();
        }

        public void Update(long idTarefa, Tarefa tarefa)
        {
            TarefaRepository.Update(idTarefa, tarefa);
        }
    }
}
