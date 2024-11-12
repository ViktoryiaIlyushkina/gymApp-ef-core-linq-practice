using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Models
{
    public class TrainingExercise
    {
        public int Id { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }

        public int TrainingId { get; set; }
        public Training? Training { get; set; }

        public int ExerciseId { get; set; }
        public Exercise? Exercise { get; set; }
    }
}
