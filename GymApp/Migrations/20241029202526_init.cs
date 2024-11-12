using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusculeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Memberships_MembershipId",
                        column: x => x.MembershipId,
                        principalTable: "Memberships",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trainings_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingExercises_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "MusculeGroup", "Name" },
                values: new object[,]
                {
                    { 1, "Exercise for chest, triceps and shoulder muscles.", "Chest", "Push-ups" },
                    { 2, "Exercise for back, biceps and shoulders muscles.", "Back", "Lifts" },
                    { 3, "Exercise for leg, buttock and back muscles.", "Legs", "Squats" },
                    { 4, "Exercise for the chest, triceps, and shoulder muscles performed using a barbell or dumbbell.", "Chest", "Bench Press" },
                    { 5, "Exercise for the back, biceps, and shoulder muscles performed using barbell or dumbbell.", "Back", "Upper Thrust" },
                    { 6, "Exercise for the back, legs, buttocks and shoulders using a barbell.", "Back", "Deadlift" },
                    { 7, "A shoulder muscle exercise performed using a barbell or dumbbell.", "Shoulders", "Standing Press" },
                    { 8, "Exercise for the back, biceps, and shoulders muscles performed using a barbell.", "Back", "Barbell pull" },
                    { 9, "A biceps muscle exercise performed using a barbell or dumbbell.", "Biceps", "Biceps" },
                    { 10, "Triceps muscle exercise performed using a barbell or dumbbell.", "Triceps", "Triceps" },
                    { 11, "A self-weight exercise for the abs.", "Press", "Press" },
                    { 12, "Biceps Muscle Exercise performed using a barbell or dumbbell.", "Biceps", "Biceps Lift" },
                    { 13, "Exercise for shoulder muscles performed using dumbbells.", "Shoulders", "Dumbbell Press" },
                    { 14, "Exercise for the back, biceps, and shoulders muscles using dumbbells.", "Back", "Dumbbell pull" },
                    { 15, "Exercise for the biceps muscles performed using a barbell or dumbbell.", "Biceps", "Biceps flexions" }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "Duration", "Price", "Type" },
                values: new object[,]
                {
                    { 1, 12, 2000m, 1 },
                    { 2, 6, 3500m, 2 },
                    { 3, 3, 700m, 1 },
                    { 4, 12, 5000m, 2 },
                    { 5, 6, 1200m, 1 },
                    { 6, 3, 1500m, 2 },
                    { 7, 12, 2500m, 1 },
                    { 8, 6, 4000m, 2 },
                    { 9, 3, 800m, 1 },
                    { 10, 12, 6000m, 2 },
                    { 11, 6, 1500m, 1 },
                    { 12, 3, 2000m, 2 },
                    { 13, 12, 3000m, 1 },
                    { 14, 6, 4500m, 2 },
                    { 15, 3, 900m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Experience", "FirstName", "LastName", "Specialization" },
                values: new object[,]
                {
                    { 1, 5, "Andrey", "Petrov", "Fitness" },
                    { 2, 8, "Olga", "Sidorova", "Bodybuilding" },
                    { 3, 3, "Maxim", "Ivanov", "Fitness" },
                    { 4, 7, "Elena", "Kuznetsova", "Bodybuilding" },
                    { 5, 4, "Sergey", "Vasiliev", "Fitness" },
                    { 6, 6, "Irina", "Romanova", "Bodybuilding" },
                    { 7, 2, "Alexey", "Morozov", "Fitness" },
                    { 8, 9, "Natalia", "Zaitseva", "Bodybuilding" },
                    { 9, 5, "Pavel", "Grigoriev", "Fitness" },
                    { 10, 8, "Anna", "Kudryavtseva", "Bodybuilding" },
                    { 11, 3, "Denis", "Petrov", "Fitness" },
                    { 12, 7, "Ksenia", "Smirnova", "Bodybuilding" },
                    { 13, 4, "Dmitry", "Popov", "Fitness" },
                    { 14, 6, "Maria", "Kozlova", "Bodybuilding" },
                    { 15, 2, "Alexander", "Sidorov", "Fitness" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "MembershipId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "ivan.ivanov@mail.ru", "Ivan", "Ivanov", 1, "+79111234567" },
                    { 2, "olga.petrova@mail.ru", "Olga", "Petrova", 2, "+79222345678" },
                    { 3, "alexandr.sidorov@mail.ru", "Alexander", "Sidorov", 1, "+79333456789" },
                    { 4, "maria.kozlova@mail.ru", "Maria", "Kozlova", 2, "+79444567890" },
                    { 5, "andrey.kuznetsov@mail.ru", "Andrey", "Kuznetsov", 1, "+79555678901" },
                    { 6, "ekaterina.smirnova@mail.ru", "Ekaterina", "Smirnova", 2, "+79666789012" },
                    { 7, "dmitriy.popov@mail.ru", "Dmitry", "Popov", 1, "+79777890123" },
                    { 8, "elena.sokolova@mail.ru", "Elena", "Sokolova", 2, "+79888901234" },
                    { 9, "sergey.vasilev@mail.ru", "Sergey", "Vasiliev", 1, "+79999012345" },
                    { 10, "irina.romanova@mail.ru", "Irina", "Romanova", 2, "+79111123456" },
                    { 11, "alexey.morozov@mail.ru", "Alexey", "Morozov", 1, "+79222234567" },
                    { 12, "natalia.zaytseva@mail.ru", "Natalia", "Zaytseva", 2, "+79333345678" },
                    { 13, "pavel.grigoryev@mail.ru", "Pavel", "Grigoryev", 1, "+79444456789" },
                    { 14, "anna.kudryavtseva@mail.ru", "Anna", "Kudryavtseva", 2, "+79555567890" },
                    { 15, "denis.petrov@mail.ru", "Denis", "Petrov", 1, "+79666678901" }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "ClientId", "Date", "Duration", "TrainerId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 1 },
                    { 2, 2, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 3, 3, new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 3 },
                    { 4, 4, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 4 },
                    { 5, 5, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 5 },
                    { 6, 6, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 6 },
                    { 7, 7, new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 7 },
                    { 8, 8, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 8 },
                    { 9, 9, new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 9 },
                    { 10, 10, new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 10 },
                    { 11, 11, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 11 },
                    { 12, 12, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 12 },
                    { 13, 13, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 13 },
                    { 14, 14, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 14 },
                    { 15, 15, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 15 }
                });

            migrationBuilder.InsertData(
                table: "TrainingExercises",
                columns: new[] { "Id", "ExerciseId", "Reps", "Sets", "TrainingId" },
                values: new object[,]
                {
                    { 1, 1, 10, 3, 1 },
                    { 2, 2, 8, 3, 1 },
                    { 3, 3, 12, 3, 1 },
                    { 4, 4, 8, 3, 2 },
                    { 5, 5, 10, 3, 2 },
                    { 6, 6, 5, 1, 2 },
                    { 7, 7, 12, 3, 3 },
                    { 8, 8, 10, 3, 3 },
                    { 9, 9, 15, 3, 3 },
                    { 10, 10, 10, 3, 4 },
                    { 11, 11, 12, 3, 4 },
                    { 12, 12, 15, 3, 4 },
                    { 13, 13, 8, 3, 5 },
                    { 14, 14, 10, 3, 5 },
                    { 15, 15, 12, 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_MembershipId",
                table: "Clients",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingExercises_ExerciseId",
                table: "TrainingExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingExercises_TrainingId",
                table: "TrainingExercises",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_ClientId",
                table: "Trainings",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_TrainerId",
                table: "Trainings",
                column: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingExercises");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Memberships");
        }
    }
}
