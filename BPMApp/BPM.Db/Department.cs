﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BPMApp.Db
{
    /// <summary>
    /// Отдел комании
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Идентификатор отдела
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование отдела
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Начальник отдела
        /// </summary>
        public string DepartmentHead { get; set; }

        /// <summary>
        /// Внутренний номер
        /// </summary>
        public int ExtensionNumber { get; set; }
    }
}
