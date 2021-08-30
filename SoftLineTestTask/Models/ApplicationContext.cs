using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SoftLineTestTask.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<SubTable> SubTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SoftLineTestTask;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//добавление данных в бд
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee[] //Таблица сотрудников
                {
                    new Employee { Id = 1, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true },
                    new Employee { Id = 2, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true },
                    new Employee { Id = 3, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true },
                    new Employee { Id = 4, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true },
                    new Employee { Id = 5, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true },
                    new Employee { Id = 6, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true },
                    new Employee { Id = 7, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true },
                    new Employee { Id = 8, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true },
                    new Employee { Id = 9, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true },
                    new Employee { Id = 10, Name = "Tom", Position = "1", Birthday = new DateTime(2008, 5, 1, 8, 30, 52), Text = "1", Decree = true }
                });
            modelBuilder.Entity<SubTable>().HasData(
                new SubTable[] //Вспомогательная таблица
                {
                    new SubTable { Id = 1, EmployeeId = 5, FieldName = "Рад работать в компании", FieldText = "да"},
                    new SubTable { Id = 2, EmployeeId = 6, FieldName = "Всегда в хорошем настроении", FieldText = "да"},
                    new SubTable { Id = 3, EmployeeId = 10, FieldName = "Первое поле", FieldText = "действительно первое"},
                    new SubTable { Id = 4, EmployeeId = 10, FieldName = "Второе поле", FieldText = "действительно второе"}
                });
        }
    }
}

