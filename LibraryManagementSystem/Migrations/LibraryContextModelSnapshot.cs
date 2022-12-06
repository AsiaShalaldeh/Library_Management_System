﻿// <auto-generated />
using System;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            //modelBuilder.Entity("AuthorBook", b =>
            //    {
            //        b.Property<int>("AuthorsAuthorID")
            //            .HasColumnType("int");

            //        b.Property<int>("BooksISBN")
            //            .HasColumnType("int");

            //        b.HasKey("AuthorsAuthorID", "BooksISBN");

            //        b.HasIndex("BooksISBN");

            //        b.ToTable("AuthorBook");
            //    });

            modelBuilder.Entity("LibraryManagementSystem.Models.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"), 1L, 1);

                    b.Property<string>("History")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LibraryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Opened")
                        .HasColumnType("datetime2");

                    b.Property<int>("PatronID")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.HasIndex("LibraryID");

                    b.HasIndex("PatronID")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"), 1L, 1);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Book", b =>
                {
                    b.Property<int>("ISBN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ISBN"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ISBN");

                    b.ToTable("Books");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Book");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.HasKey("BookID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Catalog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Librarian", b =>
                {
                    b.Property<int>("LibrarianID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibrarianID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibrarianID");

                    b.ToTable("Librarian");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Library", b =>
                {
                    b.Property<int>("LibraryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibraryID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatalogID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibraryID");

                    b.HasIndex("CatalogID");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Patron", b =>
                {
                    b.Property<int>("PatronID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatronID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatronID");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.BookItem", b =>
                {
                    b.HasBaseType("LibraryManagementSystem.Models.Book");

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatalogID")
                        .HasColumnType("int");

                    b.Property<bool>("IsReferenceOnly")
                        .HasColumnType("bit");

                    b.Property<int>("LibraryID")
                        .HasColumnType("int");

                    b.Property<int>("LibrarianID")
                        .HasColumnType("int");

                    b.Property<string>("RFID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("AccountID");

                    b.HasIndex("CatalogID");

                    b.HasIndex("LibraryID");

                    b.HasIndex("LibrarianID");

                    b.HasDiscriminator().HasValue("BookItem");
                });

            //modelBuilder.Entity("AuthorBook", b =>
            //    {
            //        b.HasOne("LibraryManagementSystem.Models.Author", null)
            //            .WithMany()
            //            .HasForeignKey("AuthorsAuthorID")
            //            .IsRequired();

            //        b.HasOne("LibraryManagementSystem.Models.Book", null)
            //            .WithMany()
            //            .HasForeignKey("BooksISBN")
            //            .IsRequired();
            //    });

            modelBuilder.Entity("LibraryManagementSystem.Models.Account", b =>
                {
                    b.HasOne("LibraryManagementSystem.Models.Library", "Library")
                        .WithMany("Accounts")
                        .HasForeignKey("LibraryID")
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.Models.Patron", "Patron")
                        .WithOne("Account")
                        .HasForeignKey("LibraryManagementSystem.Models.Account", "PatronID")
                        .IsRequired();

                    b.Navigation("Library");

                    b.Navigation("Patron");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.BookAuthor", b =>
                {
                    b.HasOne("LibraryManagementSystem.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Library", b =>
                {
                    b.HasOne("LibraryManagementSystem.Models.Catalog", "Catalog")
                        .WithMany()
                        .HasForeignKey("CatalogID")
                        .IsRequired();

                    b.Navigation("Catalog");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.BookItem", b =>
                {
                    b.HasOne("LibraryManagementSystem.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.Models.Catalog", "Catalog")
                        .WithMany("bookItems")
                        .HasForeignKey("CatalogID")
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.Models.Library", "Library")
                        .WithMany("bookItems")
                        .HasForeignKey("LibraryID")
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Catalog");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Catalog", b =>
                {
                    b.Navigation("bookItems");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Library", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("bookItems");
                });

            modelBuilder.Entity("LibraryManagementSystem.Models.Patron", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
