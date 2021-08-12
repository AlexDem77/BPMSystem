using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BpmApp.Models.PositionModels
{
    /// <summary>
    /// DTO-модель должности (создание)
    /// </summary>
    public class CreatePositionModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
