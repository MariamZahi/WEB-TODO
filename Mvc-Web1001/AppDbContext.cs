Using Microsoft.EntityFrameworkCore;
public class AppDbContext : AppDbContext
{
    public Dbset<TodoItem> TodoItems {get; set;}
}