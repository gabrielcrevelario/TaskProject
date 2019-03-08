using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManger.Services;
using TaskProject.Domain.Entities;
using TaskProject.Domain.Services;

namespace TaskProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public IUsuarioService UsuarioService { get; }
        public UsuarioController(IUsuarioService usuarioService)
        {
            UsuarioService = usuarioService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(UsuarioService.GetAll());
        }
        [HttpPost]
        public void Create([FromBody]Usuario usuario)
        {
            UsuarioService.Create(usuario);
        }
        [HttpPut("{idUsuario}")]
        public void Update(long idUsuario, [FromBody]Usuario usuario)
        {
           UsuarioService.Update(idUsuario, usuario);
        }
        [HttpDelete("{idUsuario}")]
        public void Delete(long idUsuario)
        {
            UsuarioService.Delete(idUsuario);
        }
    }
}