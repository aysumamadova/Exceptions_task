using System;
using System.Collections.Generic;
using System.Text;

namespace Person_task1_.Models
{
    class Employee : Person
    {
        private double _salaryOfHour;
        private double _workingHour;

        public double salaryOfaHour
        {
            get
            {
                return _salaryOfHour;
            }
            set
            {
                _salaryOfHour = value;
            }

        }
        public double workingHour
        {
            get
            {
                return _workingHour;
            }
            set
            {
                _workingHour = value;
            }

        }
        public Employee(string name, string surname, int age, double workingHour, double salaryOfHour)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salaryOfaHour = salaryOfHour;
            this.workingHour = workingHour;
        }

        public void CalculateSalary(double salaryOfaHour, double workingHour, double salary)
        {
           if ((salaryOfaHour * workingHour)>250)
           {
                  salary = salaryOfaHour * workingHour;

                 Console.WriteLine($"Maas{salary}AZN");
           }
            else
            {
                    
             Console.WriteLine("Duzgun deyil");
            }
        }
    }

}
