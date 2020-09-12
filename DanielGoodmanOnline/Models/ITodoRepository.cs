using System.Collections.Generic;
using System.Threading.Tasks;

namespace DanielGoodmanOnline.Models
{
    public interface ITodoRepository
    {
        Task Create(Todo todo);
        Task<bool> Delete(long id);
        Task<IEnumerable<Todo>> GetAllTodos();
        Task<long> GetNextId();
        Task<Todo> GetTodo(long id);
        Task<bool> Update(Todo todo);
    }
}