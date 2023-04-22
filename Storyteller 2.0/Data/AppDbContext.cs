﻿using Microsoft.EntityFrameworkCore;
using Storyteller_2._0.Models;

namespace Storyteller_2._0.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}
