using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BpmApp.Models.DepartmentModels
{
    /// <summary>
    /// DTO-модель отдела для создания
    /// </summary>
    public class CreateDepartmentModel
    {
        public string Name { get; set; }
        public int ExtensionNumber { get; set; }
    }
}
