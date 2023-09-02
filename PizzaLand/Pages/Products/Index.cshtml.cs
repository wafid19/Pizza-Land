using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaLand.Data;
using PizzaLand.Models;

namespace PizzaLand.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly PizzaLand.Data.PizzaLandContext _context;

        public IndexModel(PizzaLand.Data.PizzaLandContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
