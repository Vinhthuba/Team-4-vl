using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team_4.Models;

namespace Team_4.Data
{
    public class Team_4Context : DbContext
    {
        public Team_4Context (DbContextOptions<Team_4Context> options)
            : base(options)
        {
        }

        public DbSet<Team_4.Models.SanPham> SanPham { get; set; } = default!;

    }
}
