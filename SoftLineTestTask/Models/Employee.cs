using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLineTestTask.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } //ФИО
        public string Position { get; set; } //Должность
        public DateTime Birthday { get; set; } //ДР
        public string Text { get; set; } // Текст
        public bool Decree { get; set; } // Декрет

        public List<SubTable> SubTable { get; set; } = new List<SubTable>(); //Лист доп. полей
    }
}
