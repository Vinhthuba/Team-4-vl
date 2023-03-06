using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Team_4.Data;
using System;
using System.Linq;

namespace Team_4.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Team_4Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<Team_4Context>>()))
        {
            // Look for any movies.
            if (context.SanPham.Any())
            {
                return;   // DB has been seeded
            }
            context.SanPham.AddRange(
                new SanPham
                {
                    TenSanpham = "Crab Pool Security",

                    Price = 7.99M
                },
                new SanPham
                {
                    TenSanpham = "Ocean Foods",

                    Price = 6M
                },
                 new SanPham
                 {
                     TenSanpham = "Fastfood",

                     Price = 6M
                 },
                  new SanPham
                  {
                      TenSanpham = "Fresh Onion",

                      Price = 4M
                  },
                   new SanPham
                   {
                       TenSanpham = " Vegetables",

                       Price = 4M
                   }







            );
            context.SaveChanges();
        }
    }
}