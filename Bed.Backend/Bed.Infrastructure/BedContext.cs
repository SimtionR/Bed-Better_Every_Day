using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bed.Core.Models.Food;
using Bed.Core.Models.Gym;
using Bed.Core.Models.UserRelated;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bed.Infrastructure
{
    public class BedContext : IdentityDbContext<User>
    {
        public BedContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<WorkoutDayPlan> WorkoutDayPlans { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDayPlan> MealDayPlans { get; set; }
        public DbSet<MealRecomandations> MealRecomandations { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId);

        }
    }

    
}
