using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace FDCalculatorApp.Pages
{
    public class AddIndex : PageModel
    {
       
        public string[] QuestionList { get; set; }
        private readonly ILogger<AddIndex> _logger;

        public AddIndex(ILogger<AddIndex> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
        public void OnPost(string question, string details)
        {
            SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Stackoverflowdatabase;Integrated Security=True");
            connection.Open();
            
            string sqlquery = "INSERT INTO [question]([Question],[Detail]) VALUES('" + question + "','" + details + "')";
            SqlCommand command = new SqlCommand(sqlquery, connection);
             command.ExecuteNonQuery();
        }
    }
}