using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FDCalculatorApp.Pages
{
    public class IndexModel : PageModel
    {

        public double _maturity;
        private double maturity_;
        public double Maturity
        {
            get
            {
                return maturity_;
            }
            set
            {
                maturity_ = value;
            }
        }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
       /* public void OnPost()
        {
            double amnt = double.Parse(Request.Form["amount"]);
            double interest = double.Parse(Request.Form["interest"]);
            double years = double.Parse(Request.Form["years"]);
            double maturity = amnt + ((amnt * interest * years) / 100);
            ViewData["Maturity"] = maturity;
            _maturity = maturity;
            Maturity = maturity;


        }*/
    }
}
