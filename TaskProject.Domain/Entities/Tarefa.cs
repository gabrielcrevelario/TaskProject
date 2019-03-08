using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskProject.Domain.Entities
{
    public class Tarefa
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(250)]
        public string Titulo { get; set; }
        public long UsuarioId { get; set; }
        public bool Completo { get; set; }
        public DateTime DateLog { get; set; }
    }
}
