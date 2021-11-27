using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cocos_Alex_Lab8.Models;

namespace Cocos_Alex_Lab8.Data
{
    public class Cocos_Alex_Lab8Context : DbContext
    {
        public Cocos_Alex_Lab8Context (DbContextOptions<Cocos_Alex_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cocos_Alex_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cocos_Alex_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cocos_Alex_Lab8.Models.Category> Category { get; set; }
    }
}
