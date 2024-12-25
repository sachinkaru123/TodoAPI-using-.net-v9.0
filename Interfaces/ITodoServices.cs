// using TodoAPI.Contracts;
using TodoAPI.Models;

namespace TodoAPI.Interface
{
     public interface ITodoServices
     {
         Task<IEnumerable<Todo>> GetAllAsync();
         Task<Todo> GetByIdAsync(Guid id);
         Task CreateTodoAsync(CreateTodoRequest request);
         Task UpdateTodoAsync(Guid id, UpdateTodoRequest request);
         Task DeleteTodoAsync(Guid id);
     }
}

// GetAllAsync: Retrieves all Todo items from the database.
// GetByIdAsync: Fetches a specific Todo item by its Id.
// CreateTodoAsync: Adds a new Todo item to the database.
// UpdateTodoAsync: Modifies an existing Todo item in the database.
// DeleteTodoAsync: Removes a Todo item from the database.