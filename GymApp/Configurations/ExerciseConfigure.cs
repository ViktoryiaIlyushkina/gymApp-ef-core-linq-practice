using GymApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Configurations
{
    public class ExerciseConfigure
    {
        public static void ExerciseConfigureMethod(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new Exercise
                {
                    Id = 1,
                    Name = "Push-ups",
                    MusculeGroup = "Chest",
                    Description = "Exercise for chest, triceps and shoulder muscles."
                },
                new Exercise
                {
                    Id = 2,
                    Name = "Lifts",
                    MusculeGroup = "Back",
                    Description = "Exercise for back, biceps and shoulders muscles."
                },
                new Exercise
                {
                    Id = 3,
                    Name = "Squats",
                    MusculeGroup = "Legs",
                    Description = "Exercise for leg, buttock and back muscles."
                },
                new Exercise
                {
                    Id = 4,
                    Name = "Bench Press",
                    MusculeGroup = "Chest",
                    Description = "Exercise for the chest, triceps, and shoulder muscles performed using a barbell or dumbbell."
                },
                new Exercise
                {
                    Id = 5,
                    Name = "Upper Thrust",
                    MusculeGroup = "Back",
                    Description = "Exercise for the back, biceps, and shoulder muscles performed using barbell or dumbbell."
                },
                new Exercise
                {
                    Id = 6,
                    Name = "Deadlift",
                    MusculeGroup = "Back",
                    Description = "Exercise for the back, legs, buttocks and shoulders using a barbell."
                },
                new Exercise
                {
                    Id = 7,
                    Name = "Standing Press",
                    MusculeGroup = "Shoulders",
                    Description = "A shoulder muscle exercise performed using a barbell or dumbbell."
                },
                new Exercise
                {
                    Id = 8,
                    Name = "Barbell pull",
                    MusculeGroup = "Back",
                    Description = "Exercise for the back, biceps, and shoulders muscles performed using a barbell."
                },
                new Exercise
                {
                    Id = 9,
                    Name = "Biceps",
                    MusculeGroup = "Biceps",
                    Description = "A biceps muscle exercise performed using a barbell or dumbbell."
                },
                new Exercise
                {
                    Id = 10,
                    Name = "Triceps",
                    MusculeGroup = "Triceps",
                    Description = "Triceps muscle exercise performed using a barbell or dumbbell."
                },
                new Exercise
                {
                    Id = 11,
                    Name = "Press",
                    MusculeGroup = "Press",
                    Description = "A self-weight exercise for the abs."
                },
                new Exercise
                {
                    Id = 12,
                    Name = "Biceps Lift",
                    MusculeGroup = "Biceps",
                    Description = "Biceps Muscle Exercise performed using a barbell or dumbbell."
                },
                new Exercise
                {
                    Id = 13,
                    Name = "Dumbbell Press",
                    MusculeGroup = "Shoulders",
                    Description = "Exercise for shoulder muscles performed using dumbbells."
                },
                new Exercise
                {
                    Id = 14,
                    Name = "Dumbbell pull",
                    MusculeGroup = "Back",
                    Description = "Exercise for the back, biceps, and shoulders muscles using dumbbells."
                },
                new Exercise
                {
                    Id = 15,
                    Name = "Biceps flexions",
                    MusculeGroup = "Biceps",
                    Description = "Exercise for the biceps muscles performed using a barbell or dumbbell."
                }
                );
        }
    }
}
