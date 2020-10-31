using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace FDCalculatorApp.Pages
{
    public class ListModel : PageModel
    {
        public List<QuestionsDomain> QuestionList = new List<QuestionsDomain>();
        public void OnGet()
        {
            SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Stackoverflowdatabase;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM question", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               QuestionList.Add(new QuestionsDomain(reader.GetString(1), reader.GetString(2)));
            }
        }
    }
    public class QuestionsDomain
    {
        public QuestionsDomain() { }  
        public QuestionsDomain(string question, string details)
        {
            this.Questions = question;
            this.Details = details;
            
        }
        public string Questions { get; private set; } 
        public string Details{ get; private set; }
        
       /* public override string ToString()  
        {
            return " Movie Name:" + this.MovieName + "\n Description:" + this.Synopsis + "\n Release Year:" + this.Year;
        }*/
    }
}