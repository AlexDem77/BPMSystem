using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BpmApp.Models.EmployeeModels;
using BpmApp.Db.Infrastructure;
using BpmApp.Db.Entities;
using BpmApp.Models.DepartmentModels;

namespace BpmApp.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly BpmContext _bpmContext;

        public DepartmentRepository(BpmContext context)
        {
            _bpmContext = context;
        }

        public IEnumerable<DepartmentModel> GetAll()
        {
            var res = _bpmContext
                .Departments
                .Select(d => new DepartmentModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    ExtensionNumber = d.ExtensionNumber
                })
                .ToList();

            return res;
        }

        public DepartmentModel Upsert(CreateDepartmentModel model)
        {
            var department = _bpmContext.Departments.SingleOrDefault(d => d.Name == model.Name && d.ExtensionNumber == model.ExtensionNumber);

            if (department is null)
            {
                department = new Department
                {
                    Name = model.Name,
                    ExtensionNumber = model.ExtensionNumber
                };
                _bpmContext.Departments.Add(department);
                _bpmContext.SaveChanges();
            }

            return new DepartmentModel
            {
                Id = department.Id,
                Name = department.Name,
                ExtensionNumber = department.ExtensionNumber
            };
        }
    }
}