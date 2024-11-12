using GymApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymApp.Configurations
{
    public class ClientConfigure
    {
        public static void ClientConfigureMethod(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new Client
                {
                    Id = 1,
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    PhoneNumber = "+79111234567",
                    Email = "ivan.ivanov@mail.ru",
                    MembershipId = 1
                },
                new Client
                {
                    Id = 2,
                    FirstName = "Olga",
                    LastName = "Petrova",
                    PhoneNumber = "+79222345678",
                    Email = "olga.petrova@mail.ru",
                    MembershipId = 2
                },
                new Client
                {
                    Id = 3,
                    FirstName = "Alexander",
                    LastName = "Sidorov",
                    PhoneNumber = "+79333456789",
                    Email = "alexandr.sidorov@mail.ru",
                    MembershipId = 1
                },
                new Client
                {
                    Id = 4,
                    FirstName = "Maria",
                    LastName = "Kozlova",
                    PhoneNumber = "+79444567890",
                    Email = "maria.kozlova@mail.ru",
                    MembershipId = 2
                },
                new Client
                {
                    Id = 5,
                    FirstName = "Andrey",
                    LastName = "Kuznetsov",
                    PhoneNumber = "+79555678901",
                    Email = "andrey.kuznetsov@mail.ru",
                    MembershipId = 1
                },
                new Client
                {
                   Id = 6,
                   FirstName = "Ekaterina",
                   LastName = "Smirnova",
                   PhoneNumber = "+79666789012",
                   Email = "ekaterina.smirnova@mail.ru",
                   MembershipId = 2
                },
                new Client
                {
                   Id = 7,
                   FirstName = "Dmitry",
                   LastName = "Popov",
                   PhoneNumber = "+79777890123",
                   Email = "dmitriy.popov@mail.ru",
                   MembershipId = 1
                },
                 new Client
                 {
                     Id = 8,
                     FirstName = "Elena",
                     LastName = "Sokolova",
                     PhoneNumber = "+79888901234",
                     Email = "elena.sokolova@mail.ru",
                     MembershipId = 2
                 },
                new Client
                {
                    Id = 9,
                    FirstName = "Sergey",
                    LastName = "Vasiliev",
                    PhoneNumber = "+79999012345",
                    Email = "sergey.vasilev@mail.ru",
                    MembershipId = 1
                },
                new Client
                {
                    Id = 10,
                    FirstName = "Irina",
                    LastName = "Romanova",
                    PhoneNumber = "+79111123456",
                    Email = "irina.romanova@mail.ru",
                    MembershipId = 2
                },
                new Client
                {
                    Id = 11,
                    FirstName = "Alexey",
                    LastName = "Morozov",
                    PhoneNumber = "+79222234567",
                    Email = "alexey.morozov@mail.ru",
                    MembershipId = 1
                },
                new Client
                {
                    Id = 12,
                    FirstName = "Natalia",
                    LastName = "Zaytseva",
                    PhoneNumber = "+79333345678",
                    Email = "natalia.zaytseva@mail.ru",
                    MembershipId = 2
                },
                new Client
                {
                    Id = 13,
                    FirstName = "Pavel",
                    LastName = "Grigoryev",
                    PhoneNumber = "+79444456789",
                    Email = "pavel.grigoryev@mail.ru",
                    MembershipId = 1
                },
                new Client
                {
                    Id = 14,
                    FirstName = "Anna",
                    LastName = "Kudryavtseva",
                    PhoneNumber = "+79555567890",
                    Email = "anna.kudryavtseva@mail.ru",
                    MembershipId = 2
                },
                new Client
                {
                    Id = 15,
                    FirstName = "Denis",
                    LastName = "Petrov",
                    PhoneNumber = "+79666678901",
                    Email = "denis.petrov@mail.ru",
                    MembershipId = 1
                }
                );
        }
    }
}
