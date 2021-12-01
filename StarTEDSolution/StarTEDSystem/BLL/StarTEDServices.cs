using StarTEDSystem.DAL;
using StarTEDSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTEDSystem.BLL
{
    public class StarTEDServices
    {
        private readonly StartedContext _context;

        internal StarTEDServices(StartedContext context)
        {
            _context = context;
        }


    }
}
