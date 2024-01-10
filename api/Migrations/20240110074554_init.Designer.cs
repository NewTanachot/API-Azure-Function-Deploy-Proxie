﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using juttrips_azure_function.Infrastructure.DatabaseConfig;

#nullable disable

namespace juttrips_azure_function.Migrations
{
    [DbContext(typeof(JutTripsDbContext))]
    [Migration("20240110074554_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb3_general_ci")
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GroupUser", b =>
                {
                    b.Property<Guid>("GroupsId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("char(36)");

                    b.HasKey("GroupsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("GroupUser");
                });

            modelBuilder.Entity("juttrips_azure_function.Domain.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("OwnerUserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("juttrips_azure_function.Domain.Entities.GroupPlace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("AppointedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDisplay")
                        .HasColumnType("tinyint(1)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("double");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupPlace");
                });

            modelBuilder.Entity("juttrips_azure_function.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("IvKey")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("MapStyle")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("SubscriptionExpireDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SubscriptionTier")
                        .HasColumnType("int");

                    b.Property<int>("ThemeColor")
                        .HasColumnType("int");

                    b.Property<int>("ThemeStyle")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("juttrips_azure_function.Domain.Entities.UserPlace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("AppointedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsDisplay")
                        .HasColumnType("tinyint(1)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("double");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserPlace");
                });

            modelBuilder.Entity("GroupUser", b =>
                {
                    b.HasOne("juttrips_azure_function.Domain.Entities.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("juttrips_azure_function.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("juttrips_azure_function.Domain.Entities.GroupPlace", b =>
                {
                    b.HasOne("juttrips_azure_function.Domain.Entities.Group", "Group")
                        .WithMany("Places")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("juttrips_azure_function.Domain.Entities.UserPlace", b =>
                {
                    b.HasOne("juttrips_azure_function.Domain.Entities.User", "User")
                        .WithMany("Places")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("juttrips_azure_function.Domain.Entities.Group", b =>
                {
                    b.Navigation("Places");
                });

            modelBuilder.Entity("juttrips_azure_function.Domain.Entities.User", b =>
                {
                    b.Navigation("Places");
                });
#pragma warning restore 612, 618
        }
    }
}