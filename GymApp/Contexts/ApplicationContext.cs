using GymApp.Configurations;
using GymApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client>? Clients { get; set; }
        public DbSet<Exercise>? Exercises { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingExercise> TrainingExercises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\mssqllocaldb; Database=GymAppDb; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(ClientConfigure.ClientConfigureMethod);
            modelBuilder.Entity<Exercise>(ExerciseConfigure.ExerciseConfigureMethod);
            modelBuilder.Entity<Membership>(MembershipConfigure.MembershipConfigureMethod);
            modelBuilder.Entity<Trainer>(TrainerConfigure.TrainerConfigureMethod);
            modelBuilder.Entity<Training>(TrainingConfigure.TrainingsConfigureMethod);
            modelBuilder.Entity<TrainingExercise>(TrainingExerciseConfigure.TrainingExerciseConfigureMethod);
        }


    }
}
