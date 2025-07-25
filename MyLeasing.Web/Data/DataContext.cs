﻿using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Models;
using System.Collections.Generic;

namespace MyLeasing.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
    }
}
