﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using xmorav32.Models;

namespace xmorav32.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Objects> Object { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Photos> Photo { get; set; }
    }
}
