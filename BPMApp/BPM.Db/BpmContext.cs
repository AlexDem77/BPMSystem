using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BpmApp.Db
{

    // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bpm_db;Integrated Security=True

    /// <summary>
    /// Описание базы данных. Для разработки
    /// </summary>
    public class BpmContext : DbContext
    {
        /// <summary>
        /// Описание таблицы сотрудников. Для разработки
        /// </summary>
        public DbSet<Employee>  Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conectionString = "Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=bpm_db;Integrated Security=True";
                optionsBuilder.UseSqlServer(conectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
