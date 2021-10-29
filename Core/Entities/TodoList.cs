using System;
using System.Collections.Generic;

namespace Core
{
    public class TodoList
    {
        public string Id { get; set; }
        public ICollection<TodoListItem> Items { get; set; }
    }
}
