using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Борисов_Сергей_26ИС
{
    using System;

    namespace EmployeeApp
    {
        // Описание класса служащих
        public class Employee
        {
            // Открытые поля для хранения ФИО и зарплаты
            public string FullName;
            public decimal Salary;

            // Конструктор для удобства инициализации (опционально, но полезно)
            public Employee(string fullName, decimal salary)
            {
                FullName = fullName;
                Salary = salary;
            }

            // Метод Show() – показать на экране данные о служащем
            public void Show()
            {
                Console.WriteLine($"ФИО: {FullName}");
                Console.WriteLine($"Ежемесячная зарплата: {Salary} руб.");
            }

            // Метод расчета годовой зарплаты
            public decimal CalculateAnnualSalary()
            {
                return Salary * 12;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // 1. Создать объект класса Employee.
                // 2. Задать полям объекта следующие значения: ФИО = Иванов, зарплата = 63500.
                Employee employee = new Employee("Иванов", 63500m);

                // Альтернативный способ создания и инициализации без конструктора:
                // Employee employee = new Employee();
                // employee.FullName = "Иванов";
                // employee.Salary = 63500m;

                // 3. Вывести на экран данные, хранящиеся в объекте.
                employee.Show();
                Console.WriteLine(); // Пустая строка для визуального разделения вывода

                // 4. Рассчитать годовой размер зарплаты сотрудника и вывести на печать.
                decimal annualSalary = employee.CalculateAnnualSalary();
                Console.WriteLine($"Годовая зарплата: {annualSalary} руб.");

                // Чтобы консоль не закрылась сразу после выполнения (актуально для Windows)
                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
    }
}
