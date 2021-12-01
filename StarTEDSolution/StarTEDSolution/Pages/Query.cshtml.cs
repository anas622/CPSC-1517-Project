using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StarTEDSystem.BLL;

namespace StarTEDSolution.Pages
{
    public class QueryModel : PageModel
    {
        private readonly StarTEDServices _starTEDServices;


        public QueryModel(StarTEDServices starTEDServices)
        {
            _starTEDServices = starTEDServices;
        }

        public void OnGet()
        {
            
        }

    }
}
