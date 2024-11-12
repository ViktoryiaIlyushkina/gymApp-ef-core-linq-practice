using GymApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Configurations
{
    public class TrainerConfigure
    {
        public static void TrainerConfigureMethod(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new Trainer
                {
                    Id = 1,
                    FirstName = "Andrey",
                    LastName = "Petrov",
                    Specialization = "Fitness",
                    Experience = 5
                },
                new Trainer
                {
                    Id = 2,
                    FirstName = "Olga",
                    LastName = "Sidorova",
                    Specialization = "Bodybuilding",
                    Experience = 8
                },
                new Trainer
                {
                    Id = 3,
                    FirstName = "Maxim",
                    LastName = "Ivanov",
                    Specialization = "Fitness",
                    Experience = 3
                },
                new Trainer
                {
                    Id = 4,
                    FirstName = "Elena",
                    LastName = "Kuznetsova",
                    Specialization = "Bodybuilding",
                    Experience = 7
                },
                new Trainer
                {
                    Id = 5,
                    FirstName = "Sergey",
                    LastName = "Vasiliev",
                    Specialization = "Fitness",
                    Experience = 4
                },
                new Trainer
                {
                    Id = 6,
                    FirstName = "Irina",
                    LastName = "Romanova",
                    Specialization = "Bodybuilding",
                    Experience = 6
                },
                new Trainer
                {
                    Id = 7,
                    FirstName = "Alexey",
                    LastName = "Morozov",
                    Specialization = "Fitness",
                    Experience = 2
                },
                new Trainer
                {
                    Id = 8,
                    FirstName = "Natalia",
                    LastName = "Zaitseva",
                    Specialization = "Bodybuilding",
                    Experience = 9
                },
                new Trainer
                {
                    Id = 9,
                    FirstName = "Pavel",
                    LastName = "Grigoriev",
                    Specialization = "Fitness",
                    Experience = 5
                },
                new Trainer
                {
                    Id = 10,
                    FirstName = "Anna",
                    LastName = "Kudryavtseva",
                    Specialization = "Bodybuilding",
                    Experience = 8
                },
                new Trainer
                {
                    Id = 11,
                    FirstName = "Denis",
                    LastName = "Petrov",
                    Specialization = "Fitness",
                    Experience = 3
                },
                new Trainer
                {
                    Id = 12,
                    FirstName = "Ksenia",
                    LastName = "Smirnova",
                    Specialization = "Bodybuilding",
                    Experience = 7
                },
                new Trainer
                {
                    Id = 13,
                    FirstName = "Dmitry",
                    LastName = "Popov",
                    Specialization = "Fitness",
                    Experience = 4
                },
                new Trainer
                {
                    Id = 14,
                    FirstName = "Maria",
                    LastName = "Kozlova",
                    Specialization = "Bodybuilding",
                    Experience = 6
                },
                new Trainer
                {
                    Id = 15,
                    FirstName = "Alexander",
                    LastName = "Sidorov",
                    Specialization = "Fitness",
                    Experience = 2
                }
                );
        }
    }
}
