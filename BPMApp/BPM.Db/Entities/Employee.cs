using BpmApp.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BpmApp.Db.Entities
{
    /// <summary>
    /// Работник компании
    /// </summary>
    public class Employee : BaseEntity
    {
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
        /// Опыт работы
        /// </summary>
        public double WorkExperience { get; set; }

        /// <summary>
        /// Табельный номер
        /// </summary>
        public int PersonNumber { get; set; }

        /// <summary>
        /// Идентификатор должности
        /// </summary>
        [ForeignKey(nameof(Position))]
        public Guid PositionId { get; set; }

        /// <summary>
        /// Должность, навигационное свойство 
        /// </summary>
        public virtual Position Position { get; set; }
    }
}
