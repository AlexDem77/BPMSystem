using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BpmApp.Models.PositionModels
{
    /// <summary>
    /// DTO-модель должности (отображение)
    /// </summary>
    public class PositionModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
