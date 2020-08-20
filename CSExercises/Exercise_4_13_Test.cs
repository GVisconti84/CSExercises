using System;
using System.Collections.Generic;
using System.Text;

namespace CSExercises
{
    public class EmployeeTest
    {
        public static void LocalMain (string[] args)
        {
            Console.WriteLine("Insert first employee name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Insert first employee surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Insert first employee salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Employee emp1 = new Employee(name, surname, salary);
            Console.WriteLine("Insert second employee name: ");
            name = Console.ReadLine();
            Console.WriteLine("Insert second employee surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Insert second employee salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Employee emp2 = new Employee(name, surname, salary);

            Console.WriteLine("{0} {1} Yearly Salary is {2:C}", emp1.firstName, emp1.lastName, emp1.YearlySalary(emp1.mSalary));
            Console.WriteLine("{0} {1} Yearly Salary is {2:C}", emp2.firstName, emp2.lastName, emp2.YearlySalary(emp2.mSalary));

            Console.WriteLine("You are so fucking poor, take this 10% raise of your fucking miserable salary.");
            Console.WriteLine("{0} {1} Yearly Salary is {2:C}", emp1.firstName, emp1.lastName, emp1.YearlySalary(emp1.mSalary) + emp1.YearlySalary(emp1.mSalary)*0.10M);
            Console.WriteLine("{0} {1} Yearly Salary is {2:C}", emp2.firstName, emp2.lastName, emp2.YearlySalary(emp2.mSalary) + emp2.YearlySalary(emp2.mSalary)*0.10M);
        }

       
    }
}
