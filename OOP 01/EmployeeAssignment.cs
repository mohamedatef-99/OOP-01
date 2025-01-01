using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class EmployeeAssignment : IComparable<EmployeeAssignment>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        private char gender;
        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    value = gender;
                }
            }
        }

        public EmployeeAssignment(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hire, char gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hire;
            Gender = gender;
        }

        public int CompareTo(EmployeeAssignment other)
        {
            return this.HireDate.CompareTo(other.HireDate);
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security: {SecurityLevel}," +
                $"Salary: {String.Format("{0:C}", Salary)}, Hire Date: {HireDate}";
        }
    }
}
