using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iscilerin sayini daxil edin:");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

            Employee[] employees = new Employee[count];


            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write($"{i+1}. Fullaname:");
                string fullname = Console.ReadLine();
                    
                Console.Write($"{i + 1}. Age:");
                string ageStr = Console.ReadLine();
                byte age = Convert.ToByte(ageStr);

                Console.Write($"{i + 1}. Position:");
                string postion = Console.ReadLine();

                Console.Write($"{i + 1}. Salary:");
                string salaryStr = Console.ReadLine();
                double salary = Convert.ToDouble(salaryStr);

                employees[i] = new Employee(fullname, age);
                employees[i].Position = postion;
                employees[i].Salary = salary;
            }


            Console.WriteLine("All employees:");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].GetInfo());
            }

            string ans;
            do
            {
                Console.WriteLine("Axtaris etmek isteyirsinizmi? y/n");
                ans = Console.ReadLine();

                if (ans == "y")
                {
                    Console.WriteLine("Axtaris deyerini daxil edin");

                    string search = Console.ReadLine();
                    Console.WriteLine("Filtered employees:");
                    for (int i = 0; i < employees.Length; i++)
                    {
                        if (employees[i].Fullname.Contains(search))
                        {
                            Console.WriteLine(employees[i].GetInfo());
                        }
                    }
                }

            } while (ans!="y" && ans!="n");
          

        }
    }
}
