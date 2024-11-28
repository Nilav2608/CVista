﻿// <auto-generated />
using System;
using Assignment3CV_NilavarasuKumar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment3_NilavarasuKumar.Migrations
{
    [DbContext(typeof(Assignment3CV_NilavarasuKumarContext))]
    [Migration("20241126003637_UpdateDBContext")]
    partial class UpdateDBContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.CVModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfessionalSummary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CVModel");
                });

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CVModelId")
                        .HasColumnType("int");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CVModelId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CVModelId")
                        .HasColumnType("int");

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProficiencyLevel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CVModelId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CVModelId")
                        .HasColumnType("int");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CVModelId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.WorkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CVModelId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CVModelId");

                    b.ToTable("WorkExperiences");
                });

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.Education", b =>
                {
                    b.HasOne("Assignment3_NilavarasuKumar.Models.CVModel", "CVModel")
                        .WithMany("EducationList")
                        .HasForeignKey("CVModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CVModel");
                });

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.Language", b =>
                {
                    b.HasOne("Assignment3_NilavarasuKumar.Models.CVModel", "CVModel")
                        .WithMany("Languages")
                        .HasForeignKey("CVModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CVModel");
                });

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.Skill", b =>
                {
                    b.HasOne("Assignment3_NilavarasuKumar.Models.CVModel", "CVModel")
                        .WithMany("Skills")
                        .HasForeignKey("CVModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CVModel");
                });

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.WorkExperience", b =>
                {
                    b.HasOne("Assignment3_NilavarasuKumar.Models.CVModel", "CVModel")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("CVModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CVModel");
                });

            modelBuilder.Entity("Assignment3_NilavarasuKumar.Models.CVModel", b =>
                {
                    b.Navigation("EducationList");

                    b.Navigation("Languages");

                    b.Navigation("Skills");

                    b.Navigation("WorkExperiences");
                });
#pragma warning restore 612, 618
        }
    }
}
