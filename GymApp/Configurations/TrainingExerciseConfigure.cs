using GymApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Configurations
{
    public class TrainingExerciseConfigure
    {
        public static void TrainingExerciseConfigureMethod(EntityTypeBuilder<TrainingExercise> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new TrainingExercise
                {
                    Id = 1,
                    TrainingId = 1,
                    ExerciseId = 1,
                    Sets = 3,
                    Reps =10
                },
                new TrainingExercise
                {
                    Id = 2,
                    TrainingId = 1,
                    ExerciseId = 2,
                    Sets = 3,
                    Reps = 8
                },
                new TrainingExercise
                {
                    Id = 3,
                    TrainingId = 1,
                    ExerciseId = 3,
                    Sets = 3,
                    Reps = 12
                },
                new TrainingExercise
                {
                    Id = 4,
                    TrainingId = 2,
                    ExerciseId = 4,
                    Sets = 3,
                    Reps = 8
                },
                new TrainingExercise
                {
                    Id = 5,
                    TrainingId = 2,
                    ExerciseId = 5,
                    Sets = 3,
                    Reps = 10
                },
                new TrainingExercise
                {
                    Id = 6,
                    TrainingId = 2,
                    ExerciseId = 6,
                    Sets = 1,
                    Reps = 5
                },
                new TrainingExercise
                {
                    Id = 7,
                    TrainingId = 3,
                    ExerciseId = 7,
                    Sets = 3,
                    Reps = 12
                },
                new TrainingExercise
                {
                    Id = 8,
                    TrainingId = 3,
                    ExerciseId = 8,
                    Sets = 3,
                    Reps = 10
                },
                new TrainingExercise
                {
                    Id = 9,
                    TrainingId = 3,
                    ExerciseId = 9,
                    Sets = 3,
                    Reps = 15
                },
                new TrainingExercise
                {
                    Id = 10,
                    TrainingId = 4,
                    ExerciseId = 10,
                    Sets = 3,
                    Reps = 10
                },
                new TrainingExercise
                {
                    Id = 11,
                    TrainingId = 4,
                    ExerciseId = 11,
                    Sets = 3,
                    Reps = 12
                },
                new TrainingExercise
                {
                    Id = 12,
                    TrainingId = 4,
                    ExerciseId = 12,
                    Sets = 3,
                    Reps = 15
                },
                new TrainingExercise
                {
                    Id = 13,
                    TrainingId = 5,
                    ExerciseId = 13,
                    Sets = 3,
                    Reps = 8
                },
                new TrainingExercise
                {
                    Id = 14,
                    TrainingId = 5,
                    ExerciseId = 14,
                    Sets = 3,
                    Reps = 10
                },
                new TrainingExercise
                {
                    Id = 15,
                    TrainingId = 5,
                    ExerciseId = 15,
                    Sets = 3,
                    Reps = 12
                }
                );
        }
    }
}
