using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITodoListRepository
    {
        Task<TodoList> GetAsync();
        Task<TodoList> UpdateAsync(TodoList list);
    }
}
