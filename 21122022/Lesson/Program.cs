using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hasProblem = false;
            do
            {
                try
                {
                    hasProblem = false;
                    Console.Write("eded 1: ");
                    string num1Str = Console.ReadLine();
                    int num1 = Convert.ToInt32(num1Str);

                    Console.Write("eded 2: ");
                    string num2Str = Console.ReadLine();
                    int num2 = Convert.ToInt32(num2Str);

                    var result = num1 / num2;
                    Console.WriteLine(result);

                    var human = CreateHuman();
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Daxil etdiyiniz deyer int formatina uygun deyil, yeniden daxil edin");
                    hasProblem = true;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("0-a bolme ede bilmezsiniz, yeniden cehd edin!");
                    hasProblem = true;
                }
                //catch(HumanNameFormatException e)
                //{
                //    Console.WriteLine("Ad ve Soyadin duzgun daxil edin:");
                //    hasProblem= true;
                //}
                catch(Exception e)
                {
                    Console.WriteLine("Bilinmedik bir xeta bas verdi :(") ;
                    Console.WriteLine("Xeta: "+e.Message);
                    Console.WriteLine("Yeniden daxil edin!");
                    hasProblem = true;
                }

            } while (hasProblem);
        }

        static Human CreateHuman()
        {
            Console.WriteLine("Ad:");
            string name = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(name) || name.Length < 3)
            {
                throw new HumanNameFormatException("Ad-in uzunlugu minimum 3 olmalidir");
            }

            Console.WriteLine("Soyad:");
            string surname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(surname) || surname.Length < 3)
            {
                throw new HumanNameFormatException("Soyadin-in uzunlugu minimum 3 olmalidir");
            }

            Human human = new Human
            {
                Name = name,
                Surname = surname
            };

            return human;

        }
    }
}
