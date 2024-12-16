using Microsoft.EntityFrameworkCore;
using WebApplication1_HW_11_12_2024_ADD.Models;

namespace WebApplication1_HW_11_12_2024_ADD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
