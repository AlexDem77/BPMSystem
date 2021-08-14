using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BpmApp.Db.Infrastructure;
using BpmApp.Db.Entities;
using BpmApp.Models.EmployeeModels;

namespace BpmApp.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly BpmContext _bpmContext;

        public EmployeeRepository(BpmContext context)
        {
            _bpmContext = context;
        }

        public IEnumerable<EmployeeModel> GetAll()
        {
            var res = _bpmContext
                .Employees
                .Select(e => new EmployeeModel
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    PersonNumber = e.PersonNumber
                })
                .ToList();

            return res;
        }

        public EmployeeModel Upsert(CreateEmployeeModel model)
        {
            // запрос для поиска позиции
            var employee = _bpmContext.Employees.SingleOrDefault(e => e.FirstName == model.FirstName
            && e.LastName == model.LastName
            && e.PersonNumber == model.PersonNumber);

            if (employee is null)
            {
                employee = new Employee
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PersonNumber = model.PersonNumber
                };
                _bpmContext.Employees.Add(employee);
                _bpmContext.SaveChanges();
            }

            return new EmployeeModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PersonNumber = employee.PersonNumber
            };
        }
    }
}
