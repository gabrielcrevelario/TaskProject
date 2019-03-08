using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskProject.Domain.Enum;

namespace TaskProject.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string Nome { get; set; }
        public TypeUserEnum TypeUser { get; set; }
        [MaxLength(100)]
        [Required]
        public string Email { get; set; }
        [MaxLength(20)]
        [Required]
        public string Senha { get; set; }
    }
}
