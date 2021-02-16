using System;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class TodoListItem
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Votre tâches doit contenir au moins 2 caractères")]
        [MaxLength(200, ErrorMessage = "Votre tâches ne peut contenir plus de 200 caractères")]
        public string Title { get; set; }

        public bool IsDone { get; set; }
    }
}