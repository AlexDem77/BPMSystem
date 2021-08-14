using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BpmApp.Models.EmployeeModels
{
    /// <summary>
    /// DTO-модель сотрудника для создания
    /// </summary>
    public class CreateEmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonNumber { get; set; }
    }
}
