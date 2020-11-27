using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hutanu_Diana_Lab8.Models;

namespace Hutanu_Diana_Lab8.Data
{
    public class Hutanu_Diana_Lab8Context : DbContext
    {
        public Hutanu_Diana_Lab8Context (DbContextOptions<Hutanu_Diana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Hutanu_Diana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Hutanu_Diana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Hutanu_Diana_Lab8.Models.Category> Category { get; set; }
    }
}
