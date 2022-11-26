﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbSet<Book> Books { get; set; }
        public DbSet<BookItem> BookItems { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Librarian> Librarian { get; set; }
        public IList<BookAuthor> BookAuthors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-TD29OVV;Database=LibraryDB;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.BookID, ba.AuthorID });
        }

    }
}
