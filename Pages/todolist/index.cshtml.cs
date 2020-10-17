using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using System.Web;

namespace FDCalculatorApp.Pages
{
    public class ToDoListIndexModel : PageModel
    {
        public string[] tasks;
        private readonly ILogger<ToDoListIndexModel> _logger;

        public ToDoListIndexModel(ILogger<ToDoListIndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {           
            tasks = System.IO.File.ReadAllLines("todotext.txt");

        }
        public void OnPost()
        {
            string input = Request.Form["newtask"];
            System.IO.File.AppendAllText("todotext.txt", input + Environment.NewLine);
            tasks =System.IO.File.ReadAllLines("todotext.txt");

        }
    }
}
