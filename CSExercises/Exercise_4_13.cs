using System;
using System.Collections.Generic;
using System.Text;

namespace CSExercises
{
    public class Employee
    {
        private decimal salary;
        private decimal yearlySalary;

        public string firstName { get; set; }
        public string lastName { get; set; }
        
        public decimal mSalary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                    mSalary = value;
            }
        }


        public Employee(string firstName, string lastName, decimal mSalary)
        {
            
            firstName = firstName;
            lastName = lastName;
            salary = mSalary;
        }

        public decimal YearlySalary(decimal salary)
        {
            yearlySalary = salary * 12;
            return yearlySalary;
        }
    }
}
