using Core;
using Core.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TodoListRepository : ITodoListRepository
    {
        private readonly IMongoContext _mongoContext;
        public const string CollectionName = "TodoList";

        public TodoListRepository(IMongoContext mongoContext)
        {
            _mongoContext = mongoContext;
        }
        private IMongoCollection<TodoList> TodoList => _mongoContext.GetCollection<TodoList>(CollectionName);

        public async Task<TodoList> GetAsync()
        {
            return await TodoList.AsQueryable().SingleAsync();
        }

        public async Task<TodoList> UpdateAsync(TodoList list)
        {
            await TodoList.ReplaceOneAsync(t => t.Id == list.Id, list);
            return list;
        }
    }
}
