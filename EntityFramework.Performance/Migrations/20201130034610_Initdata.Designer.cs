﻿// <auto-generated />
using System;
using EntityFramework.Performance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFramework.Performance.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20201130034610_Initdata")]
    partial class Initdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EntityFramework.Performance.Entities.EngagementUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EngagementUser");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b756a857-cc5a-4d6e-ac0c-3decd23ffde9"),
                            UserId = new Guid("59ef6921-22bd-4c09-a982-2ed314992593")
                        },
                        new
                        {
                            Id = new Guid("c86c22de-85d0-4f22-8727-f6eb039adf12"),
                            UserId = new Guid("59ef6921-22bd-4c09-a982-2ed314992593")
                        });
                });

            modelBuilder.Entity("EntityFramework.Performance.Entities.TermAndCondition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TermAndCondition");

                    b.HasData(
                        new
                        {
                            Id = new Guid("802d598e-4ca9-4f23-850c-ca37f2450fb4"),
                            UserId = new Guid("59ef6921-22bd-4c09-a982-2ed314992593")
                        },
                        new
                        {
                            Id = new Guid("57808e40-bcf2-48f1-826a-59f0178a1dc7"),
                            UserId = new Guid("59ef6921-22bd-4c09-a982-2ed314992593")
                        });
                });

            modelBuilder.Entity("EntityFramework.Performance.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("59ef6921-22bd-4c09-a982-2ed314992593"),
                            Email = "abc@abc.com"
                        });
                });

            modelBuilder.Entity("EntityFramework.Performance.Entities.EngagementUser", b =>
                {
                    b.HasOne("EntityFramework.Performance.Entities.User", "User")
                        .WithMany("EngagementUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityFramework.Performance.Entities.TermAndCondition", b =>
                {
                    b.HasOne("EntityFramework.Performance.Entities.User", "User")
                        .WithMany("TermAndCondition")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityFramework.Performance.Entities.User", b =>
                {
                    b.Navigation("EngagementUser");

                    b.Navigation("TermAndCondition");
                });
#pragma warning restore 612, 618
        }
    }
}
