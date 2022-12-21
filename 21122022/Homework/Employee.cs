using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Employee:Human
    {
        public Employee(string fullname,byte age):base(fullname,age)
        {

        }

        public Employee(string fullname, byte age,string positon,double salary) : base(fullname, age)
        {
            this.Salary = salary;
            this.Position = positon;
        }
        public double Salary;
        public string Position;

        public string GetInfo()
        {
            return $"Fullname: {Fullname} - Age: {Age} - Position: {Position} - Salary: {Salary}";
        }
    }
}
