using Core;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly ITodoListRepository _todoListRepository;

        public TodoListController(ITodoListRepository todoListRepository)
        {
            _todoListRepository = todoListRepository;
        }

        // GET: api/<TodoListController>
        [HttpGet]
        public async Task<TodoList> Get()
        {
            return await _todoListRepository.GetAsync();
        }

        // PUT api/<TodoListController>/5
        [HttpPut()]
        public async Task Put([FromBody] TodoList todoList)
        {
            await _todoListRepository.UpdateAsync(todoList);
        }

        // DELETE api/<TodoListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
