using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BpmApp.Models.DepartmentModels;

namespace BpmApp.Infrastructure.Repositories
{
    public interface IDepartmentRepository
    {
        /// <summary>
        /// Получить все отделы
        /// </summary>
        /// <returns></returns>
        IEnumerable<DepartmentModel> GetAll();

        /// <summary>
        /// Поиск или создание отдела
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        DepartmentModel Upsert(CreateDepartmentModel model);
    }
}
