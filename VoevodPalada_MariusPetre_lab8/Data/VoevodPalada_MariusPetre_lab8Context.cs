using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VoevodPalada_MariusPetre_lab8.Models;

namespace VoevodPalada_MariusPetre_lab8.Data
{
    public class VoevodPalada_MariusPetre_lab8Context : DbContext
    {
        public VoevodPalada_MariusPetre_lab8Context (DbContextOptions<VoevodPalada_MariusPetre_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<VoevodPalada_MariusPetre_lab8.Models.Book> Book { get; set; }

        public DbSet<VoevodPalada_MariusPetre_lab8.Models.Publisher> Publisher { get; set; }
    }
}
