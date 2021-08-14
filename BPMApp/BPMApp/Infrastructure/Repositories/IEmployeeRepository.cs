using BpmApp.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BpmApp.Infrastructure.Repositories
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Получить список сотрудников
        /// </summary>
        /// <returns></returns>
        IEnumerable<EmployeeModel> GetAll();

        /// <summary>
        /// Создать или получить модель сотрудника
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        EmployeeModel Upsert(CreateEmployeeModel model);
    }
}
