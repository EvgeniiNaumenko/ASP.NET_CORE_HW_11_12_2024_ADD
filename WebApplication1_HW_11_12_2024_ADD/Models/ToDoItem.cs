using System.ComponentModel.DataAnnotations;
using WebApplication1_HW_11_12_2024_ADD.Helper;

namespace WebApplication1_HW_11_12_2024_ADD.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [Required]
        public ToDoStatus Status { get; set; } = ToDoStatus.Pending;
    }
}
