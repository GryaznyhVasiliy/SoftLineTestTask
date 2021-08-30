using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftLineTestTask.Models
{
    public class SubTable //Таблица для дополнительных полей
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; } //Id сотрудника
        public string FieldName { get; set; } //Название поля
        public string FieldText { get; set; } //Содержание поля

        public Employee Employee { get; set; }  // Пользователь-владелец
    }
}
