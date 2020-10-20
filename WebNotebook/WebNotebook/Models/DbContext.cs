﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNotebook.Models
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<User> User { get; set; }
        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
    }
}
