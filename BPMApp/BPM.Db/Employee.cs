using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BPMApp.Db
{
    /// <summary>
    /// Работник компании
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Идентификатор работника
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Имя работника
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия работника
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Дата рождения работника
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Опыт работы
        /// </summary>
        public string WorkExperience { get; set; }

        /// <summary>
        /// Табельный номер
        /// </summary>
        public int PersonNumber { get; set; }
    }
}
