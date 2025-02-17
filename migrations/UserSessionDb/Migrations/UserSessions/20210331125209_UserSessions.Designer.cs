﻿// <auto-generated />
using System;
using Duende.Bff.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace UserSessionDb.Migrations.UserSessions
{
    [DbContext(typeof(SessionDbContext))]
    [Migration("20210331125209_UserSessions")]
    partial class UserSessions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Duende.Bff.EntityFramework.UserSessionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expires")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Renewed")
                        .HasColumnType("TEXT");

                    b.Property<string>("Scheme")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Ticket")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.HasIndex("SessionId")
                        .IsUnique();

                    b.HasIndex("SubjectId", "SessionId")
                        .IsUnique();

                    b.ToTable("UserSessions");
                });
#pragma warning restore 612, 618
        }
    }
}
