using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Models
{
    public class Training
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }

        public int ClientId { get; set; }
        public Client? Client { get; set; }

        public int TrainerId { get; set; }
        public Trainer? Trainer { get; set; }

        public List<TrainingExercise>? TrainingExercises { get; set; }
    }
}
