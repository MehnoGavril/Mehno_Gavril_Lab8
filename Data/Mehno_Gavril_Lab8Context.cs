using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mehno_Gavril_Lab8.Models;

namespace Mehno_Gavril_Lab8.Data
{
    public class Mehno_Gavril_Lab8Context : DbContext
    {
        public Mehno_Gavril_Lab8Context (DbContextOptions<Mehno_Gavril_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Mehno_Gavril_Lab8.Models.Book> Book { get; set; }

        public DbSet<Mehno_Gavril_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Mehno_Gavril_Lab8.Models.Category> Category { get; set; }
    }
}
