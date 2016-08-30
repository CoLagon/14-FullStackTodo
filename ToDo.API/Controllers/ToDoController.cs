using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ToDo.API.Models;
using ToDo.API.Infrastructure;


namespace ToDo.API.Controllers
{
    public class ToDoController : ApiController
    {
        private ToDoDataContext _dataContext;
        public ToDoController()
        {
            _dataContext = new ToDoDataContext();
        }
        // GET: api/ToDo
        public IEnumerable<Models.ToDoList> Get()
        {
            return _dataContext.todos;
        }


        // POST: api/ToDo
        public Models.ToDoList Post(Models.ToDoList todo)
        {
            _dataContext.todos.Add(todo);

            _dataContext.SaveChanges();

            return todo;

        }


        // PUT: api/ToDo/5
        public void Put(int id, [FromBody]ToDoList updatedToDo)
        {

        }

        // DELETE: api/ToDo/5
        public void Delete(int id)
        {
          
        }
    }
}
