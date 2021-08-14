using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BpmApp.Models.EmployeeModels
{
    /// <summary>
    /// DTO-модель сотрудника для отображения
    /// </summary>
    public class EmployeeModel
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonNumber { get; set; }
    }
}
