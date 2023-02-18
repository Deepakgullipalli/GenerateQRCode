using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GenerateQRCode.Data;
using GenerateQRCode.Models;

namespace GenerateQRCode.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly GenerateQRCode.Data.GenerateQRCodeContext _context;

        public IndexModel(GenerateQRCode.Data.GenerateQRCodeContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
}
