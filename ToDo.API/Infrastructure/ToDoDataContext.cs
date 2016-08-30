using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDo.API.Infrastructure
{
    public class ToDoDataContext: DbContext
    {
        public ToDoDataContext() : base("MyToDoDataBase")
        {

        }
        public  IDbSet<Models.ToDoList> todos { get; set; }
    }
}