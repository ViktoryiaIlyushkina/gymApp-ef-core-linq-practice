using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? MusculeGroup { get; set; }
        public string? Description { get; set; }

        public List<TrainingExercise>? TrainingExercises { get; set; }
    }
}
