﻿// <auto-generated />
using System;
using FlexiBackEnd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlexiBackEnd.Migrations
{
    [DbContext(typeof(FlexiDbContext))]
    partial class FlexiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlexiBackEnd.Request", b =>
                {
                    b.Property<int>("requestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("accepted")
                        .HasColumnType("bit");

                    b.Property<string>("deniedReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("endHour")
                        .HasColumnType("int");

                    b.Property<DateTime>("exceptionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("requestType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("startHour")
                        .HasColumnType("int");

                    b.HasKey("requestId");

                    b.ToTable("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
