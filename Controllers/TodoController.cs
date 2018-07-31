using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers {
    public class Todocontroller : ControllerBase {
        private readonly TodoContext _context;
        public Todocontroller (TodoContext context) {
            _context = context;

            if (_context.TodoItems.Count () == 0) {
                _context.TodoItems.Add (new TodoItem { Name = "item1" });
                _context.SaveChanges ();
            }
        }
    }
}