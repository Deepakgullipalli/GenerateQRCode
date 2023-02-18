using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenerateQRCode.Models;

namespace GenerateQRCode.Data
{
    public class GenerateQRCodeContext : DbContext
    {
        public GenerateQRCodeContext (DbContextOptions<GenerateQRCodeContext> options)
            : base(options)
        {
        }

        public DbSet<GenerateQRCode.Models.Employee> Employee { get; set; } = default!;
    }
}
