using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FDCalculatorApp.Pages
{
    public class IndexModel2 : PageModel
    {
       // public string question;
		//public string description; 
        public Dictionary<string,Question> dictQuestions= new Dictionary<string,Question>();
        public class Question {
		
		public Question(string title,string description)
		{
			this.Title=title;
			this.Description=description;
			
		}
		public string Title{get;private set;}
		public string Description {get;private set;}

		public override string ToString()
		{
			return this.Title + this.Description;
		}
	}
        private readonly ILogger<IndexModel> _logger;

        public IndexModel2(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost(string question,string description)
        {
           dictQuestions.Add("question",new Question(question,description));
        }
    }
}
