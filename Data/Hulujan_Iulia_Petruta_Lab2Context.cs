using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hulujan_Iulia_Petruta_Lab2.Models;

namespace Hulujan_Iulia_Petruta_Lab2.Data
{
    public class Hulujan_Iulia_Petruta_Lab2Context : DbContext
    {
        public Hulujan_Iulia_Petruta_Lab2Context (DbContextOptions<Hulujan_Iulia_Petruta_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Hulujan_Iulia_Petruta_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Hulujan_Iulia_Petruta_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Hulujan_Iulia_Petruta_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Hulujan_Iulia_Petruta_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
