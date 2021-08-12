using BpmApp.Db;
using Microsoft.EntityFrameworkCore;
using System;
using BpmApp.Db.Entities;
using BpmApp.Db.Infrastructure;

namespace DbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            //Console.ReadKey();

            try
            {
                using (var context = new BpmContext())
                {
                    //context.Database.Migrate();

                    var developerPositionId = context.CreateOrFindPosition(context, "Developer", "DevTitle");

                    context.Employees.Add(new Employee()
                    {
                        FirstName = "Иван",
                        LastName = "Иванов",
                        PersonNumber = 35,
                        PositionId = developerPositionId,
                        WorkExperience = 2.3,
                        DateOfBirth = new DateTime(1992, 7, 20)
                    });
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    Console.WriteLine($"{ex.GetType().Name}, message: {ex.Message}");
                    ex = ex.InnerException;
                }
            }
        }
    }
}
