using System;
using System.Linq;
using Gymlog.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Gymlog.Domain.Services
{
    public class ExerciseContext: DbContext
    {
        public ExerciseContext(DbContextOptions<ExerciseContext> options)
        : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }

        internal void InitDefaults()
        {
            if (Exercises.Count() == 0)
            {
                Exercises.AddRange(
                    new Exercise{ Id = 1, Title = "Squats" }
                    , new Exercise{ Id = 2, Title = "Leg press" }
                    , new Exercise{ Id = 3, Title = "Calf raises" }
                    , new Exercise{ Id = 4, Title = "Leg curls" }
                );
                this.SaveChanges();
            }
        }
    }
}