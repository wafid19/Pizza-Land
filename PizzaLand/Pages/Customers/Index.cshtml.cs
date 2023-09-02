﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaLand.Data;
using PizzaLand.Models;

namespace PizzaLand.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly PizzaLand.Data.PizzaLandContext _context;

        public IndexModel(PizzaLand.Data.PizzaLandContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customer = await _context.Customers.ToListAsync();
            }
        }
    }
}
