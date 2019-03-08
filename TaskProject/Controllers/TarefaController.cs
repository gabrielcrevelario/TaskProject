using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarefaProject.Domain.Services;
using TaskProject.Domain.Entities;

namespace TaskProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        public ITarefaService TarefaService { get; }
        public TarefaController(ITarefaService tarefaService)
        {
            TarefaService = tarefaService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(TarefaService.GetAll());
        }
        [HttpPost]
        public void Create([FromBody]Tarefa tarefa)
        {
            TarefaService.Create(tarefa);
        }
        [HttpPut("{idTarefa}")]
        public void Update(long idTarefa, [FromBody]Tarefa tarefa)
        {
            TarefaService.Update(idTarefa, tarefa);
        }
        [HttpDelete("{idTarefa}")]
        public void Delete(long idTarefa)
        {
            TarefaService.Delete(idTarefa);
        }
    }
}
