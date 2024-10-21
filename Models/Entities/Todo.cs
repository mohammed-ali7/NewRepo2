using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ToDoApp.Models.Entities
{
    
    public class Todo
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        //  add-migration "initial migration"
    }
}
