using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    internal class Employee
    {
        private int id;
        private string name;
        private double salary;



        #region Apply Encapsulation using setter and getter methods
        // Apply Encapsulation using setter and getter methods

        // Setter
        //public void SetId(int id)
        //{
        //    if (id > 0)
        //    {
        //        this.id = id;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid ID");
        //    }
        //}

        //// Getter
        //public int GetId()
        //{
        //    return id;
        //}

        //public void setName(string name)
        //{
        //    this.name = name;
        //}

        //public string getName()
        //{
        //    return name;
        //}

        //public void setSalary(double salary)
        //{
        //    if(salary > 0)
        //        this.salary = salary;
        //}

        //public double getSalary()
        //{
        //    return salary;
        //}

        //public Employee(int id, string name, double salary) {
        //    //this.id = id;
        //    //this.name = name;
        //    //this.salary = salary;

        //    SetId(id);
        //    setName(name);
        //    setSalary(salary);
        //} 
        #endregion

        #region Apply Encapsulation using properties
        //Apply Encapsulation using properties

        // 1. Full Property
        // 2. Auto Property
        // 3. Special Property [Indexer]



        // 1. Full Property
        //public int Id
        //{
        //    // set
        //    // get
        //    set
        //    {
        //        id = value;
        //    }
        //    get
        //    {
        //        return id;
        //    }
        //}

        //public string Name
        //{
        //    set
        //    {
        //        name = value;
        //    }
        //    get
        //    {
        //        return name;
        //    }
        //}

        //public double Salary
        //{
        //    set
        //    {
        //        salary = value;
        //    }

        //    get
        //    {
        //        return salary;
        //    }
        //}

        //// 2. Auto Property
        //public string Address { set; get; } 
        #endregion

    }
}
