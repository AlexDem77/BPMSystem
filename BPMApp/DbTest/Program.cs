using BpmApp.Db;
using System;

namespace DbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для продолжения игры нажмите любую клавишу...");
            //Console.ReadKey();



            try
            {
                using (var context = new BpmContext())
                {
                    context.Employees.Add(new Employee()
                    {
                        FirstName = "Иван",
                        LastName = "Иванов",
                        PersonNumber = 35,
                        Position = new Position() { Name = "developer" },
                        WorkExperience = 2.3,
                        DateOfBirth = new DateTime(1992, 7, 20)
                    });
                    context.SaveChanges();
                }
            }
            catch
            {
                int i = 0;
                i++;
            }

        }
    }
}
