using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zad5.Data;
using Zad5.Models;

namespace Zad5.Pages
{
    public class DataFromDBModel : PageModel
    {
        private readonly ProductContext _context;
        public DataFromDBModel(ProductContext context)
        {
            _context = context;
        }
        public IList<Product> Product { get; set; }
        public void OnGet()
        {
            Product = _context.Product.ToList();
        }
    }
}
