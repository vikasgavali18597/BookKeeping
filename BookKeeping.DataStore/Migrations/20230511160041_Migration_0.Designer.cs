﻿// <auto-generated />
using System;
using BookKeeping.DataStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookKeeping.DataStore.Migrations
{
    [DbContext(typeof(BookKeepingDbContext))]
    [Migration("20230511160041_Migration_0")]
    partial class Migration_0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookKeeping.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountCategoryId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BookKeeping.Models.AccountCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountCategories");
                });

            modelBuilder.Entity("BookKeeping.Models.Credit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CrAccCatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CrAccId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("CrAmt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("GeneralJournalId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GeneralJournalId")
                        .IsUnique();

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("BookKeeping.Models.Debit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DrAccCatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DrAccId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("DrAmt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("GeneralJournalId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GeneralJournalId")
                        .IsUnique();

                    b.ToTable("Debits");
                });

            modelBuilder.Entity("BookKeeping.Models.GeneralJournal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("GLNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Narration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GeneralJournals");
                });

            modelBuilder.Entity("BookKeeping.Models.Account", b =>
                {
                    b.HasOne("BookKeeping.Models.AccountCategory", "AccountCategoryCategory")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountCategoryCategory");
                });

            modelBuilder.Entity("BookKeeping.Models.Credit", b =>
                {
                    b.HasOne("BookKeeping.Models.GeneralJournal", "GeneralJournal")
                        .WithOne("Credit")
                        .HasForeignKey("BookKeeping.Models.Credit", "GeneralJournalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GeneralJournal");
                });

            modelBuilder.Entity("BookKeeping.Models.Debit", b =>
                {
                    b.HasOne("BookKeeping.Models.GeneralJournal", "GeneralJournal")
                        .WithOne("Debit")
                        .HasForeignKey("BookKeeping.Models.Debit", "GeneralJournalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GeneralJournal");
                });

            modelBuilder.Entity("BookKeeping.Models.AccountCategory", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("BookKeeping.Models.GeneralJournal", b =>
                {
                    b.Navigation("Credit")
                        .IsRequired();

                    b.Navigation("Debit")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}