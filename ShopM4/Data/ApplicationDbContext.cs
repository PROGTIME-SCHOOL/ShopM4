﻿using System;
using Microsoft.EntityFrameworkCore;
using ShopM4.Models;

namespace ShopM4.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}

