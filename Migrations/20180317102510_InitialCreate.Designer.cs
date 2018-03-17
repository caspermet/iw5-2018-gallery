﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using xmorav32.Data;

namespace xmorav32.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180317102510_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("xmorav32.Models.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("xmorav32.Models.Objects", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("IdOfPhotos");

                    b.Property<string>("Name");

                    b.Property<int>("PositionOnPhotos");

                    b.HasKey("Id");

                    b.ToTable("Object");
                });

            modelBuilder.Entity("xmorav32.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<Guid>("IdOfPhotos");

                    b.Property<int>("PositionOnPhotos");

                    b.Property<string>("SurName");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("xmorav32.Models.Photos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Format");

                    b.Property<Guid>("IdOfAlbum");

                    b.Property<string>("Note");

                    b.Property<string>("Resolution");

                    b.HasKey("Id");

                    b.ToTable("Photo");
                });
#pragma warning restore 612, 618
        }
    }
}
