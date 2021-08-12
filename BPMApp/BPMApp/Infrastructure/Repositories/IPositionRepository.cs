using BpmApp.Models.PositionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BpmApp.Infrastructure.Repositories
{
    interface IPositionRepository
    {
        /// <summary>
        /// Получение всех должностей
        /// </summary>
        /// <returns></returns>
        IEnumerable<PositionModel> GetAll();

        /// <summary>
        /// Поиск или создание должности в контексте
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        PositionModel Upsert(CreatePositionModel model);
    }
}
