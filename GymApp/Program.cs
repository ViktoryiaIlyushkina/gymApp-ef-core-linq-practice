using GymApp.Contexts;
using GymApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GymApp
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //1.All / AllAsync:

                //a.Проверьте, все ли клиенты имеют абонементы.
                var res0 = await db.Clients!.AsNoTracking().AllAsync(c => c.MembershipId != null);
                //b.Проверьте, все ли тренеры имеют стаж работы более 3 лет.
                var res1 = await db.Trainers.AsNoTracking().AllAsync(t => t.Experience > 3);
                //c.Проверьте, все ли тренировки длительностью более 45 минут.
                var res2 = await db.Trainings.AsNoTracking().AllAsync(t => t.Duration > 45);

                //2.Any / AnyAsync:

                //a.Проверьте, есть ли клиенты, которые купили абонемент "Премиум".
                var res3 = await db.Clients!.AsNoTracking().AnyAsync(c => c.Membership!.Type == Enums.MembershipType.Premium);
                //b.Проверьте, есть ли тренеры, которые специализируются на бодибилдинге.
                var res4 = await db.Trainers.AsNoTracking().AnyAsync(t => t.Specialization == "Bodybuilding");
                //c.Проверьте, есть ли тренировки, которые проводились в 2023 - 03 - 15.
                var res5 = await db.Trainings.AsNoTracking().AnyAsync(t => t.Date == new DateTime(2023, 3, 15));

                //3.Average / AverageAsync:

                //a.Найдите среднюю продолжительность тренировок.
                var res6 = await db.Trainings.AsNoTracking().AverageAsync(t => t.Duration);
                //b.Найдите среднюю цену абонементов.
                var res7 = await db.Memberships.AsNoTracking().AverageAsync(m => m.Price);
                //c.Найдите средний стаж работы тренеров.
                var res8 = await db.Trainers.AsNoTracking().AverageAsync(t => t.Experience);

                //4.Contains / ContainsAsync:

                //a.Проверьте, содержит ли список клиентов клиента с именем "Иван".
                var res9 = await db.Clients!.AsNoTracking().Select(c => c.FirstName).ContainsAsync("Ivan");
                //b.Проверьте, содержит ли список тренеров тренера с фамилией "Петров".
                var res10 = await db.Trainers.AsNoTracking().Select(t => t.LastName).ContainsAsync("Petrov");
                //c.Проверьте, содержит ли список упражнений упражнение "Отжимания".
                var res11 = db.Exercises!.AsNoTracking().Select(e => e.Name).ContainsAsync("Push-ups");

                //5.Count / CountAsync:

                //a.Подсчитайте количество клиентов в зале.
                var res12 = await db.Clients!.AsNoTracking().CountAsync();
                //b.Подсчитайте количество тренеров.
                var res13 = await db.Trainers.AsNoTracking().CountAsync();
                //c.Подсчитайте количество тренировок, которые были проведены в 2023 - 03 - 10.
                var res14 = await db.Trainings!.AsNoTracking().CountAsync(t => t.Date == new DateTime(2023, 3, 10));

                //6.First / FirstAsync:

                //a.Найдите первого клиента по алфавиту.
                try
                {
                    var res15 = await db.Clients!.AsNoTracking().OrderBy(c => c.FirstName).FirstAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //b.Найдите первого тренера по стажу работы.
                try
                {
                    var res16 = await db.Trainers.AsNoTracking().OrderByDescending(t => t.Experience).FirstAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //c.Найдите первую тренировку по дате.
                try
                {
                    var res17 = await db.Trainings.AsNoTracking().OrderByDescending(t => t.Date).FirstAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //7.FirstOrDefault / FirstOrDefaultAsync:

                //a.Найдите первого клиента с именем "Александр" или верните null, если такого клиента нет.
                var res18 = await db.Clients!.AsNoTracking().FirstOrDefaultAsync(c => c.FirstName == "Alexander");
                //b.Найдите первого тренера с фамилией "Кузнецова" или верните null, если такого тренера нет.
                var res19 = await db.Trainers.AsNoTracking().FirstOrDefaultAsync(t => t.LastName == "Kuznetsova");
                //c.Найдите первую тренировку, которая длилась 60 минут, или верните null, если такой тренировки нет.
                var res20 = await db.Trainings.AsNoTracking().FirstOrDefaultAsync(t => t.Duration == 60);

                //8.Single / SingleAsync:

                //a.Найдите единственного клиента с email "ivan.ivanov@mail.ru".
                try
                {
                    var res30 = await db.Clients!.AsNoTracking()
                        .SingleAsync(c => c.Email == "ivan.ivanov@mail.ru");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //b.Найдите единственного тренера с именем "Андрей" и фамилией "Петров".
                try
                {
                    var res31 = await db.Trainers.AsNoTracking()
                        .SingleAsync(t => t.FirstName == "Andrey" && t.LastName == "Petrov");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //c.Найдите единственную тренировку, которая была проведена в 2023 - 03 - 10, и длилась 60 минут.
                try
                {
                    var res32 = await db.Trainings.AsNoTracking()
                        .SingleAsync(t => t.Date == new DateTime(2023, 3, 10) && t.Duration == 60);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //9.SingleOrDefault / SingleOrDefaultAsync:

                //a.Найдите единственного клиента с именем "Иван" или верните null, если такого клиента нет.
                var res33 = await db.Clients!.AsNoTracking().SingleOrDefaultAsync(c => c.FirstName == "Ivan");
                //b.Найдите единственного тренера с фамилией "Сидорова" или верните null, если такого тренера нет.
                var res34 = await db.Trainers.AsNoTracking().SingleOrDefaultAsync(t => t.LastName == "Sidorova");
                //c.Найдите единственную тренировку, которая была проведена в 2023 - 03 - 10, и длилась 45 минут, или верните null, если такой тренировки нет.
                var res35 = await db.Trainings.AsNoTracking().SingleOrDefaultAsync(t => t.Date == new DateTime(2023, 3, 10) && t.Duration == 45);

                //10.Select:

                //a.Выберите имена и фамилии всех клиентов.
                var res36 = db.Clients!.AsNoTracking().Select(c => c.FirstName + ' ' + c.LastName);
                //b.Выберите имена и специализации всех тренеров.
                var res37 = db.Trainers!.AsNoTracking().Select(t => new
                {
                    FirstName = t.FirstName,
                    LastName = t.LastName,
                    Specialization = t.Specialization
                });
                //c.Выберите названия и группы мышц всех упражнений.
                var res38 = db.Exercises!.AsNoTracking().Select(ex => new
                {
                    Name = ex.Name,
                    MusculeGroup = ex.MusculeGroup
                });

                //11.Where:

                //a.Найдите всех клиентов, у которых абонемент "Премиум".
                var res39 = db.Clients!.AsNoTracking().Where(c => c.Membership!.Type == Enums.MembershipType.Premium);
                //b.Найдите всех тренеров, у которых стаж работы больше 5 лет.
                var res40 = db.Trainers!.AsNoTracking().Where(t => t.Experience > 5);
                //c.Найдите все тренировки, которые длились 60 минут.
                var res41 = db.Trainings!.AsNoTracking().Where(t => t.Duration == 60);

                //12.OrderBy:

                //a.Отсортируйте клиентов по алфавиту по имени.
                var res42 = db.Clients!.AsNoTracking().OrderBy(c => c.FirstName);
                //b.Отсортируйте тренеров по возрастанию стажа работы.
                var res43 = db.Trainers!.AsNoTracking().OrderBy(t => t.Experience);
                //c.Отсортируйте тренировки по возрастанию даты проведения.
                var res44 = db.Trainings!.AsNoTracking().OrderBy(t => t.Date);

                //13.OrderByDescending:

                //a.Отсортируйте клиентов по алфавиту по фамилии в обратном порядке.
                var res45 = db.Clients!.AsNoTracking().OrderByDescending(c => c.LastName);
                //b.Отсортируйте тренеров по убыванию стажа работы.
                var res46 = db.Trainers!.AsNoTracking().OrderByDescending(t => t.Experience);
                //c.Отсортируйте тренировки по убыванию даты проведения.
                var res47 = db.Trainings!.AsNoTracking().OrderByDescending(t => t.Date);

                //14.ThenBy:

                //a.Отсортируйте клиентов по алфавиту по имени, а затем по фамилии.
                var res48 = db.Clients!.AsNoTracking().OrderBy(c => c.FirstName).ThenBy(t => t.LastName);
                //b.Отсортируйте тренеров по возрастанию стажа работы, а затем по алфавиту по имени.
                var res49 = db.Trainers!.AsNoTracking().OrderBy(t => t.Experience).ThenBy(t => t.FirstName);
                //c.Отсортируйте тренировки по возрастанию даты, а затем по продолжительности.
                var res50 = db.Trainings!.AsNoTracking().OrderBy(t => t.Date).ThenBy(t => t.Duration);

                //15.ThenByDescending:

                //a.Отсортируйте клиентов по алфавиту по фамилии в обратном порядке, а затем по имени в обратном порядке.
                var res51 = db.Clients!.AsNoTracking().OrderByDescending(c => c.LastName).ThenByDescending(c => c.FirstName);
                //b.Отсортируйте тренеров по убыванию стажа работы, а затем по алфавиту по имени в обратном порядке.
                var res52 = db.Trainers!.AsNoTracking().OrderByDescending(t => t.Experience).ThenByDescending(t => t.FirstName);
                //c.Отсортируйте тренировки по убыванию даты, а затем по продолжительности в обратном порядке.
                var res53 = db.Trainings!.AsNoTracking().OrderByDescending(t => t.Date).ThenByDescending(t => t.Duration);

                //16.Join:

                //a.Соедините таблицы clients и memberships по membership_id и выведите имена клиентов и тип их абонементов.
                var res54 = db.Clients!.AsNoTracking().Join(db.Memberships,
                    c => c.MembershipId,
                    m => m.Id,
                    (c, m) => new
                    {
                        Name = c.FirstName + " " + c.LastName,
                        Membership = m.Type
                    });

                foreach (var item in res54)
                {
                    Console.WriteLine(item.Name + " - " + item.Membership);
                }
                //b.Соедините таблицы trainings и trainers по trainer_id и выведите даты тренировок и имена тренеров, которые их проводили.
                var res55 = db.Trainings!.AsNoTracking().Join(db.Trainers,
                    t => t.TrainerId,
                    tr => tr.Id,
                    (t, tr) => new
                    {
                        Date = t.Date,
                        TrainerName = tr.FirstName + " " + tr.LastName
                    });

                Console.WriteLine();
                foreach (var item in res55)
                {
                    Console.WriteLine(item.Date + " - " + item.TrainerName);
                }
                //c.Соедините таблицы trainings и exercises по training_id и выведите названия упражнений, которые были выполнены на каждой тренировке.
                var res56 = db.Trainings!.AsNoTracking().Join(db.TrainingExercises,
                    t => t.Id,
                    te => te.TrainingId,
                    (t, te) => new {
                        Id = t.Id,
                        ExerciseId = te.ExerciseId,
                        TrainingId = te.TrainingId
                    }).Join(db.Exercises!,
                    t => t.ExerciseId,
                    e => e.Id,
                    (t, e) => new
                    {
                        Id = t.Id,
                        MusculeGroup = e.MusculeGroup
                    }).GroupBy(item => item.Id);

                Console.WriteLine();
                foreach (var item in res56)
                {
                    Console.WriteLine("Training Id: " + item.Key);
                    foreach (var name in item)
                    {
                        Console.WriteLine(name.MusculeGroup);
                    }
                    Console.WriteLine();
                }
                //17.GroupBy:

                //a.Сгруппируйте клиентов по типуабонемента и подсчитайте количество клиентов в каждой группе.
                var res57 = db.Clients!.AsNoTracking().GroupBy(c => c.Membership!.Type).Select(c => new
                {
                    c.Key,
                    Count = c.Count()
                });

                Console.WriteLine();
                foreach (var item in res57)
                {
                    Console.WriteLine(item.Key + " - " + item.Count);
                }
                //b.Сгруппируйте тренеров по специализации и выведите количество тренеров в каждой специализации.
                var res58 = db.Trainers!.AsNoTracking().GroupBy(t => t.Specialization).Select(t => new
                {
                    t.Key,
                    Count = t.Count()
                });

                Console.WriteLine();
                foreach (var item in res58)
                {
                    Console.WriteLine(item.Key + " - " + item.Count);
                }
                //c.Сгруппируйте тренировки по дате и выведите количество тренировок, проведенных в каждый день.
                var res59 = db.Trainings!.AsNoTracking().GroupBy(t => t.Date).Select(t => new
                {
                    t.Key,
                    Count = t.Count()
                });

                Console.WriteLine();
                foreach (var item in res59)
                {
                    Console.WriteLine(item.Key + " - " + item.Count);
                }

                //18.Except:

                //a.Найдите клиентов, которые не имеют абонемента.
                var res60 = db.Clients!.AsNoTracking().Except(db.Clients!.AsNoTracking().Where(c => c.Membership != null));
                //b.Найдите тренеров, которые не проводили ни одной тренировки.
                var res61 = db.Trainers!.AsNoTracking().Except(db.Trainers!.AsNoTracking().Where(t => t.Trainings != null));
                //c.Найдите упражнения, которые не были выполнены ни на одной тренировке.
                var selector1 = db.Exercises!.AsNoTracking();
                var selector2 = db.Exercises!.AsNoTracking().Where(e => e.TrainingExercises != null);
                var res62 = selector1.Except(selector2);

                //19.Union:

                //a.Объедините списки имен клиентов и имен тренеров.
                var res63 = db.Trainers!.AsNoTracking().Select(t => new { Name = t.FirstName })
                    .Union(db.Clients!.AsNoTracking().Select(c => new { Name = c.FirstName })).ToList();
                //b.Объедините списки названий упражнений и типов абонементов.
                var res64 = db.Exercises!.AsNoTracking().Select(e => new { Name = e.MusculeGroup })
                    .Union(db.Memberships!.AsNoTracking().Select(m => new { Name = m.Type.ToString() })).ToList();

                //20.Intersect:

                //a.Найдите клиентов, которые имеют абонемент "Стандарт" и были на тренировках.
                var res65 = db.Clients!.AsNoTracking().Where(c => c.Membership!.Type == Enums.MembershipType.Standard)
                    .Intersect(db.Clients!.AsNoTracking().Where(c => c.Trainings != null)).ToList();
                //b.Найдите тренеров, которые специализируются на фитнесе и проводили тренировки для клиентов с абонементом "Премиум".
                var res66 = db.Trainers!.AsNoTracking().Where(t => t.Specialization == "Fitness")
                    .Intersect(db.Trainers!.AsNoTracking().Where(t => t.Trainings!.Any(t => t.Client!.Membership!.Type == Enums.MembershipType.Premium))).ToList();
                //c.Найдите упражнения, которые были выполнены на тренировках, проводимых тренерами со стажем более 5 лет.
                var selector3 = db.Exercises!.AsNoTracking();
                var selector4 = db.Exercises!.AsNoTracking().Where(e => e.TrainingExercises!.Any(te => te.Training!.Trainer!.Experience > 5));
                var res67 = selector3.Intersect(selector4).ToList();

                //21.Sum / SumAsync:

                //a.Найдите общую стоимость всех абонементов.
                var res68 = await db.Memberships!.AsNoTracking().SumAsync(m => m.Price);
                //b.Найдите общую продолжительность всех тренировок.
                var res69 = await db.Trainings!.AsNoTracking().SumAsync(t => t.Duration);
                //c.Найдите общее количество сетов всех выполненных упражнений.
                var res70 = await db.TrainingExercises!.AsNoTracking().SumAsync(te => te.Sets);

                //22.Min / MinAsync:

                //a.Найдите минимальную стоимость абонемента.
                var res71 = await db.Memberships!.MinAsync(m => m.Price);
                //b.Найдите минимальную продолжительность тренировки.
                var res72 = await db.Trainings!.MinAsync(t => t.Duration);
                //c.Найдите минимальное количество повторений в одном сете.
                var res73 = await db.TrainingExercises!.AsNoTracking().MinAsync(te => te.Reps);

                //23.Max / MaxAsync:

                //a.Найдите максимальную стоимость абонемента.
                var res74 = await db.Memberships!.AsNoTracking().MaxAsync(m => m.Price);
                //b.Найдите максимальную продолжительность тренировки.
                var res75 = await db.Trainings!.AsNoTracking().MaxAsync(t => t.Duration);
                //c.Найдите максимальное количество повторений в одном сете.
                var res76 = await db.TrainingExercises!.AsNoTracking().MaxAsync(te => te.Reps);

                //24.Take:

                //a.Выберите 5 первых клиентов по алфавиту.
                var res77 = db.Clients!.AsNoTracking().OrderBy(c => c.LastName).Take(5);
                //b.Выберите 3 первых тренеров по стажу работы.
                var res78 = db.Trainers!.AsNoTracking().OrderBy(t => t.Experience).Take(3);
                //c.Выберите 10 первых тренировок по дате.
                var res79 = db.Trainings!.AsNoTracking().OrderBy(t => t.Date).Take(10);


                //25.TakeLast:

                //a.Выберите 5 последних клиентов по алфавиту.
                var res80 = db.Clients!.AsNoTracking().OrderBy(c => c.LastName).TakeLast(5);
                //b.Выберите 3 последних тренеров по стажу работы.
                var res81 = db.Trainers!.AsNoTracking().OrderBy(t => t.Experience).TakeLast(3);
                //c.Выберите 10 последних тренировок по дате.
                var res82 = db.Trainings!.AsNoTracking().OrderBy(t => t.Date).TakeLast(10);

                //26.Skip:

                //a.Пропустите 5 первых клиентов по алфавиту и выберите оставшихся.
                var res83 = db.Clients!.AsNoTracking().OrderBy(c => c.LastName).Skip(5);
                //b.Пропустите 3 первых тренеров по стажу работы и выберите оставшихся.
                var res84 = db.Trainers!.AsNoTracking().OrderBy(t => t.Experience).Skip(3);
                //c.Пропустите 10 первых тренировок по дате и выберите оставшихся.
                var res85 = db.Trainings!.AsNoTracking().OrderBy(t => t.Date).Skip(10);

                //27.SkipLast:

                //a.Пропустите 5 последних клиентов по алфавиту и выберите оставшихся.
                var res86 = db.Clients!.AsNoTracking().OrderBy(c => c.LastName).SkipLast(5);
                //b.Пропустите 3 последних тренеров по стажу работы и выберите оставшихся.
                var res87 = db.Trainers!.AsNoTracking().OrderBy(t => t.Experience).SkipLast(3);
                //c.Пропустите 10 последних тренировок по дате и выберите оставшихся.
                var res88 = db.Trainings!.AsNoTracking().OrderBy(t => t.Date).SkipLast(10);

                //28.TakeWhile:

                //a.Выберите клиентов, пока их имя не будет "Иван".
                var res89 = db.Clients!.AsNoTracking().TakeWhile(c => c.FirstName != "Ivan");
                //b.Выберите тренеров, пока их стаж работы не будет 5 лет.
                var res90 = db.Trainers!.AsNoTracking().TakeWhile(t => t.Experience != 5);
                //c.Выберите тренировки, пока их продолжительность не будет 60 минут.
                var res91 = db.Trainings!.AsNoTracking().TakeWhile(t => t.Duration != 60);

                //29.SkipWhile:

                //a.Пропустите клиентов, пока их имя не будет "Иван", и выберите оставшихся.
                var res92 = db.Clients!.AsNoTracking().SkipWhile(c => c.FirstName != "Ivan");
                //b.Пропустите тренеров, пока их стаж работы не будет 5 лет, и выберите оставшихся.
                var res93 = db.Trainers!.AsNoTracking().SkipWhile(t => t.Experience != 5);
                //c.Пропустите тренировки, пока их продолжительность не будет 60 минут, и выберите оставшихся.
                var res94 = db.Trainings!.AsNoTracking().SkipWhile(t => t.Duration != 60);

                //30.ToList / ToListAsync:

                //a.Получите список всех клиентов.
                var res95 = await db.Clients!.AsNoTracking().ToListAsync();
                //b.Получите список всех тренеров.
                var res96 = await db.Trainers!.AsNoTracking().ToListAsync();
                //c.Получите список всех тренировок.
                var res97 = await db.Trainings.AsNoTracking().ToListAsync();
            }
        }
    }
}
