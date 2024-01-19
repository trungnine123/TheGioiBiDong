using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheGioiBiDong.Models;

namespace TheGioiBiDong.Data
{
    public class TheGioiBiDongContext : DbContext
    {
        public TheGioiBiDongContext (DbContextOptions<TheGioiBiDongContext> options)
            : base(options)
        {
        }

        public DbSet<TheGioiBiDong.Models.Users> Users { get; set; } = default!;
        public DbSet<TheGioiBiDong.Models.Brand> Brand { get; set; } = default!;
        public DbSet<TheGioiBiDong.Models.Categories> Categories { get; set; } = default!;
        public DbSet<TheGioiBiDong.Models.Products> Products { get; set; } = default!;
    }
}
