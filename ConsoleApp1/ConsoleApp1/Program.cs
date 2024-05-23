using System;
using static System.Console;

namespace Hell
{
    public class Human
    {
        string first_name, last_name, town;
        DateTime date;
        public Human() { }

        public virtual void Show()
        {
            WriteLine($"Фамилия {last_name}, Имя {first_name}, Дата рождения {date.ToShortDateString()}");
        }
        public void SetFirstName(string name) { first_name = name; }
        public void SetLastName(string name) { last_name = name; }
        public void SetBirthDate(DateTime name) { date = name; }
        public void SetBirthTown(string name) { town = name; }
    }

    public class Employee : Human
    {
        double salary;
        public Employee() { }

        public override void Show()
        {
            base.Show();
            WriteLine($", Зароботная плата {salary}\n");
        }
        public void SetSalary(double sal) { salary = sal; }
    }

    public class EmployeeBilder
    {
        Employee emp = new Employee();
        public EmployeeBilder SetFirstName(string value) { emp.SetFirstName(value); return this; }
        public EmployeeBilder SetLastName(string value) { emp.SetLastName(value); return this; }
        public EmployeeBilder SetBirthDate(DateTime value) { emp.SetBirthDate(value); return this; }
        public EmployeeBilder SetSalary(double sal) { emp.SetSalary(sal); return this; }
        public EmployeeBilder SetBirthTown(string name) { emp.SetBirthTown(name); return this; }

        public Employee build()
        {
            return emp;
        }

    }

    public class Scientist : Employee
    {
        public void ShowScientist()
        {
            WriteLine("I'm a Scientist!");
        }
    }

    public class Manager : Employee
    {
        public void ShowManager()
        {
            WriteLine("I'm a Manager!");
        }
    }

    public class Specialist : Employee
    {
        public void ShowSpecialist()
        {
            WriteLine("I'm a Specialist!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Employee emp = new EmployeeBilder().SetFirstName("IDK").SetLastName("Help").SetBirthDate(DateTime.Now).SetSalary(1500).build();
            emp.Show();

            Employee emp1 = new EmployeeBilder().SetFirstName("").SetLastName("Help").SetBirthDate(DateTime.MinValue).SetSalary(0).build();
            emp1.Show();*/

            Employee[] arr = {new Manager(), new Specialist(), new Scientist()};
            foreach (Employee item in arr)
            {

                //1
                try
                {
                    ((Manager)item).ShowManager();
                }
                catch { }

                //2
                Specialist a = item as Specialist;
                if (a != null)
                {
                    a.ShowSpecialist();
                }

                //3
                if (item is Scientist)
                {
                    (item as Scientist).ShowScientist();
                }
            }
        }
    }
}