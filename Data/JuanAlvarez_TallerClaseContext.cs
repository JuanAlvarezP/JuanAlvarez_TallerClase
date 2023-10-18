using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuanAlvarez_TallerClase.Models;

namespace JuanAlvarez_TallerClase.Data
{
    public class JuanAlvarez_TallerClaseContext : DbContext
    {
        public JuanAlvarez_TallerClaseContext (DbContextOptions<JuanAlvarez_TallerClaseContext> options)
            : base(options)
        {
        }

        public DbSet<JuanAlvarez_TallerClase.Models.Burger> Burger { get; set; } = default!;
        public DbSet<JuanAlvarez_TallerClase.Models.Promo> Promo { get; set; } 

    }
}
