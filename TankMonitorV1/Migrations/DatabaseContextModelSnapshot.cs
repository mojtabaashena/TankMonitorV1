﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TankMonitorV1.Models;

namespace TankMonitorV1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TankMonitorV1.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Descript");

                    b.Property<bool>("Enable");

                    b.Property<int>("GSID");

                    b.Property<string>("GSName")
                        .IsRequired();

                    b.Property<string>("Location");

                    b.Property<int>("Priority");

                    b.Property<string>("SerialNumber");

                    b.Property<int>("TankCount");

                    b.HasKey("Id");

                    b.ToTable("tblStations");
                });

            modelBuilder.Entity("TankMonitorV1.Models.Tank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capasity");

                    b.Property<string>("Descript");

                    b.Property<bool>("Enable");

                    b.Property<int>("FuelType");

                    b.Property<int>("GSID");

                    b.Property<int>("Priority");

                    b.Property<int>("SerialNumber");

                    b.Property<int?>("StationId");

                    b.Property<int>("TankNumber");

                    b.HasKey("Id");

                    b.HasIndex("StationId");

                    b.ToTable("tblTanks");
                });

            modelBuilder.Entity("TankMonitorV1.Models.Tank", b =>
                {
                    b.HasOne("TankMonitorV1.Models.Station", "Station")
                        .WithMany("Tanks")
                        .HasForeignKey("StationId");
                });
#pragma warning restore 612, 618
        }
    }
}
