using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Human
    {
        public Human(string fullname,byte age)
        {
            this.Fullname = fullname;
            this.Age = age;
        }
        public string Fullname;
        public byte Age;
    }
}
