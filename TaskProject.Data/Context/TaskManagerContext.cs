

using Microsoft.EntityFrameworkCore;
using TaskManger.Domain.Entities;

namespace TaskManager.Data.Context
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext>
            options) : base(options)
        {

        }
        public DbSet<Tarefa> Tarefa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
