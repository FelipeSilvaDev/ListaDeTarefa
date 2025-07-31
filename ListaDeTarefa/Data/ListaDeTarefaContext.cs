using ListaTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaTarefas.Data
{
    public class ListaDeTarefaContext : DbContext
    {
        public ListaDeTarefaContext(DbContextOptions<ListaDeTarefaContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}