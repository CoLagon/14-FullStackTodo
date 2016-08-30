using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ToDo.API.Models
{
    public class ToDoList
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name{ get; set; }
        [Required]
        public string Priority { get; set; }
    }
}