using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models;

public class Todo
{
    // The [Key] tag tells us that Id is the main way to identify each Todo item in our database.
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsComplete { get; set; }
    public DateTime DueDate { get; set; }
    public int Priority { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Todo()
    {
        IsComplete = false;
    }
}