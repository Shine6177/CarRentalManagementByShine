using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalManagementByShine.Data;
using CarRentalManagementByShine.Domain;

namespace CarRentalManagementByShine.Components.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CarRentalManagementByShine.Data.CarRentalManagementByShineContext _context;

        public IndexModel(CarRentalManagementByShine.Data.CarRentalManagementByShineContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
