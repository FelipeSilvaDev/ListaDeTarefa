using System;
using System.ComponentModel.DataAnnotations;

namespace ListaTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Criação")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
