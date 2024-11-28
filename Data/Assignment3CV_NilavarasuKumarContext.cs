using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment3_NilavarasuKumar.Models;

namespace Assignment3CV_NilavarasuKumar.Data
{
    public class Assignment3CV_NilavarasuKumarContext : DbContext
    {
        public Assignment3CV_NilavarasuKumarContext (DbContextOptions<Assignment3CV_NilavarasuKumarContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment3_NilavarasuKumar.Models.CVModel> CVModel { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define one-to-many relationship between CVModel and WorkExperience
            modelBuilder.Entity<WorkExperience>()
                .HasOne(w => w.CVModel)
                .WithMany(c => c.WorkExperiences)
                .HasForeignKey(w => w.CVModelId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete if a CVModel is removed

            modelBuilder.Entity<Education>()
               .HasOne(w => w.CVModel)
               .WithMany(c => c.EducationList)
               .HasForeignKey(w => w.CVModelId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Skill>()
               .HasOne(w => w.CVModel)
               .WithMany(c => c.Skills)
               .HasForeignKey(w => w.CVModelId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Language>()
               .HasOne(w => w.CVModel)
               .WithMany(c => c.Languages)
               .HasForeignKey(w => w.CVModelId)
               .OnDelete(DeleteBehavior.Cascade);

        }


    }
}
