using GymApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Configurations
{
    public class TrainingConfigure
    {
        public static void TrainingsConfigureMethod(EntityTypeBuilder<Training> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new Training
                {
                    Id = 1,
                    ClientId = 1,
                    TrainerId = 1,
                    Date = new DateTime(2023, 3, 10),
                    Duration = 60
                },
                new Training
                {
                    Id = 2,
                    ClientId = 2,
                    TrainerId = 2,
                    Date = new DateTime(2023, 3, 11),
                    Duration = 45
                },
                new Training
                {
                    Id = 3,
                    ClientId = 3,
                    TrainerId = 3,
                    Date = new DateTime(2023, 3, 12),
                    Duration = 60
                },
                new Training
                {
                    Id = 4,
                    ClientId = 4,
                    TrainerId = 4,
                    Date = new DateTime(2023, 3, 13),
                    Duration = 45
                },
                new Training
                {
                    Id = 5,
                    ClientId = 5,
                    TrainerId = 5,
                    Date = new DateTime(2023, 3, 14),
                    Duration = 60
                },
                new Training
                {
                    Id = 6,
                    ClientId = 6,
                    TrainerId = 6,
                    Date = new DateTime(2023, 3, 15),
                    Duration = 45
                },
                new Training
                {
                    Id = 7,
                    ClientId = 7,
                    TrainerId = 7,
                    Date = new DateTime(2023, 3, 16),
                    Duration = 60
                },
                new Training
                {
                    Id = 8,
                    ClientId = 8,
                    TrainerId = 8,
                    Date = new DateTime(2023, 3, 17),
                    Duration = 45
                },
                new Training
                {
                    Id = 9,
                    ClientId = 9,
                    TrainerId = 9,
                    Date = new DateTime(2023, 3, 18),
                    Duration = 60
                },
                new Training
                {
                    Id = 10,
                    ClientId = 10,
                    TrainerId = 10,
                    Date = new DateTime(2023, 3, 19),
                    Duration = 45
                },
                new Training
                {
                    Id = 11,
                    ClientId = 11,
                    TrainerId = 11,
                    Date = new DateTime(2023, 3, 20),
                    Duration = 60
                },
                new Training
                {
                    Id = 12,
                    ClientId = 12,
                    TrainerId = 12,
                    Date = new DateTime(2023, 3, 21),
                    Duration = 45
                },
                new Training
                {
                    Id = 13,
                    ClientId = 13,
                    TrainerId = 13,
                    Date = new DateTime(2023, 3, 22),
                    Duration = 60
                },
                new Training
                {
                    Id = 14,
                    ClientId = 14,
                    TrainerId = 14,
                    Date = new DateTime(2023, 3, 23),
                    Duration = 45
                },
                new Training
                {
                    Id = 15,
                    ClientId = 15,
                    TrainerId = 15,
                    Date = new DateTime(2023, 3, 24),
                    Duration = 60
                }
                );
        }
    }
}
