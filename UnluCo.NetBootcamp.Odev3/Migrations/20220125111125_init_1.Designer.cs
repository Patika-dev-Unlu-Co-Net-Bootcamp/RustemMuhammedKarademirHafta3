﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnluCo.NetBootcamp.Odev3.DBOperations;

namespace UnluCo.NetBootcamp.Odev3.Migrations
{
    [DbContext(typeof(PatikaDevDBContext))]
    [Migration("20220125111125_init_1")]
    partial class init_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EducationStudent", b =>
                {
                    b.Property<int>("EducationsId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("EducationsId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("EducationStudent");
                });

            modelBuilder.Entity("UnluCo.NetBootcamp.Odev3.Models.Assistant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assistants");
                });

            modelBuilder.Entity("UnluCo.NetBootcamp.Odev3.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssistantId")
                        .HasColumnType("int");

                    b.Property<int?>("EducatorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AssistantId");

                    b.HasIndex("EducatorId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("UnluCo.NetBootcamp.Odev3.Models.Educator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Educators");
                });

            modelBuilder.Entity("UnluCo.NetBootcamp.Odev3.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EducationStudent", b =>
                {
                    b.HasOne("UnluCo.NetBootcamp.Odev3.Models.Education", null)
                        .WithMany()
                        .HasForeignKey("EducationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UnluCo.NetBootcamp.Odev3.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UnluCo.NetBootcamp.Odev3.Models.Education", b =>
                {
                    b.HasOne("UnluCo.NetBootcamp.Odev3.Models.Assistant", null)
                        .WithMany("Educations")
                        .HasForeignKey("AssistantId");

                    b.HasOne("UnluCo.NetBootcamp.Odev3.Models.Educator", null)
                        .WithMany("Educations")
                        .HasForeignKey("EducatorId");
                });

            modelBuilder.Entity("UnluCo.NetBootcamp.Odev3.Models.Assistant", b =>
                {
                    b.Navigation("Educations");
                });

            modelBuilder.Entity("UnluCo.NetBootcamp.Odev3.Models.Educator", b =>
                {
                    b.Navigation("Educations");
                });
#pragma warning restore 612, 618
        }
    }
}
