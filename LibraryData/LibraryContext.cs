﻿using LibraryData.Models;
using Microsoft.EntityFrameworkCore;


namespace LibraryData
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options):base(options) { }

        public DbSet<Patron> Patrons { get; set; }
    }
}
