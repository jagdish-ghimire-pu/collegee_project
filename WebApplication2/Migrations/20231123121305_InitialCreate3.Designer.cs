﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using testTaskManagement.EfContext;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231123121305_InitialCreate3")]
    partial class InitialCreate3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("testTaskManagement.Modal.TasksModal", b =>
                {
                    b.Property<Guid>("taskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("dueDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("taskDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("taskName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid");

                    b.HasKey("taskId");

                    b.ToTable("tasks");
                });

            modelBuilder.Entity("testTaskManagement.Modal.UsersModal", b =>
                {
                    b.Property<Guid>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("hashedPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
