using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PauloOlivo_TallerCodeFirst.Models;

namespace PauloOlivo_TallerCodeFirst.Data
{
    public class PauloOlivo_TallerCodeFirstContext : DbContext
    {
        public PauloOlivo_TallerCodeFirstContext (DbContextOptions<PauloOlivo_TallerCodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<PauloOlivo_TallerCodeFirst.Models.Burger> Burger { get; set; } = default!;
    }
}
