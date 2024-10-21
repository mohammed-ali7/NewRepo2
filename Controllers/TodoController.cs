using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Data;
using ToDoApp.Models;
using ToDoApp.Models.Entities;

namespace ToDoApp.Controllers
{
    // localhost:/api/controllers
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public TodoController(ApplicationDbContext dbContext) 
        
        {
            this.dbContext = dbContext;
        }
        //get all tasks through dbcontext from database sql server
        [HttpGet]

        public IActionResult GetallTasks()
        {
            return Ok(dbContext.Tasks.ToList());
        }
        // post means create a tasks from swagger or sql server
        [HttpPost]

        public IActionResult Addtasks(AddTasksDto addTasksDto)
        {
            var taskEntity = new Todo()
            {
            
                Name = addTasksDto.Name
            };

            dbContext.Tasks.Add(taskEntity);
            dbContext.SaveChanges();
            return Ok(taskEntity);
        }
        // put means update the database throgh dbcontext by [Route("{id:int}")]
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Updatetasks(int id,UpdateTasksDto updateTasksDto)
        {
            var Todo = dbContext.Tasks.Find(id);

            if (Todo == null)
            {

                return NotFound();
            }

            Todo.Name = updateTasksDto.Name;

            dbContext.SaveChanges();
            return Ok(Todo);
        }

    }
}
