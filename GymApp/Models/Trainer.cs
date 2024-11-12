using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Specialization { get; set; }
        public int Experience { get; set; }

        public List<Training>? Trainings { get; set; }
    }
}
