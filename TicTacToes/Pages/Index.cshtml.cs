using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TicTacToes.components;

// questions:
    // class methods

// set up btns and catch events

namespace TicTacToes.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
	   EmptyClass sd = new EmptyClass(); 
	   Console.WriteLine(sd);
	    Console.WriteLine("yes");
	    Console.WriteLine("@23232#");
            _logger = logger;
        }

        public void OnGet()
        {
	    Console.WriteLine("@23232#");
        }
    }
}
