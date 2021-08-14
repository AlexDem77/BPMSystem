using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BpmApp.Models.DepartmentModels
{
    /// <summary>
    /// DTO-модель отдела для отображения
    /// </summary>
    public class DepartmentModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ExtensionNumber { get; set; }
    }
}
