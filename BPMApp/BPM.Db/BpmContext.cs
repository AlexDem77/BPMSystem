﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BpmApp.Db
{

    // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bpm_db;Integrated Security=True
    // Data Source=DESKTOP-RQPV4MR;Initial Catalog=bpm_db;Integrated Security=True

    /// <summary>
    /// Описание базы данных. Для разработки
    /// </summary>
    public class BpmContext : DbContext
    {
        /// <summary>
        /// Описание таблицы сотрудников. Для разработки
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Описание таблицы отделов. Для разработки
        /// </summary>
        public DbSet<Department> Departments { get; set; }

        //public BpmContext()
        //    : base("DbConnection")
        //{ }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    string connectionString = "Data Source=DESKTOP-RQPV4MR;Initial Catalog=bpm_db;Integrated Security=True";
                    optionsBuilder.UseSqlServer(connectionString);
                }
                base.OnConfiguring(optionsBuilder);
            }
        }
}
