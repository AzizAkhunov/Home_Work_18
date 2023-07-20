﻿// <auto-generated />
using Home_Work_18.DataBases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Home_Work_18.Migrations
{
    [DbContext(typeof(CRUDDB))]
    partial class CRUDDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CarPerson", b =>
                {
                    b.Property<long>("CarsId")
                        .HasColumnType("bigint");

                    b.Property<long>("ChildrenId")
                        .HasColumnType("bigint");

                    b.HasKey("CarsId", "ChildrenId");

                    b.HasIndex("ChildrenId");

                    b.ToTable("CarPerson");
                });

            modelBuilder.Entity("Home_Work_18.Moduls.Car", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("Home_Work_18.Moduls.Passport", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("passports");
                });

            modelBuilder.Entity("Home_Work_18.Moduls.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("PassportId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PassportId");

                    b.ToTable("children");
                });

            modelBuilder.Entity("CarPerson", b =>
                {
                    b.HasOne("Home_Work_18.Moduls.Car", null)
                        .WithMany()
                        .HasForeignKey("CarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Home_Work_18.Moduls.Person", null)
                        .WithMany()
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Home_Work_18.Moduls.Person", b =>
                {
                    b.HasOne("Home_Work_18.Moduls.Passport", "Passport")
                        .WithMany("Children")
                        .HasForeignKey("PassportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passport");
                });

            modelBuilder.Entity("Home_Work_18.Moduls.Passport", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
