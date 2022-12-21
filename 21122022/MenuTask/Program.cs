using System;

namespace MenuTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[4];

            notebooks[0] = new Notebook("Macbook Pro 15", 3500);
            notebooks[1] = new Notebook("Macbook Pro 13", 2500);
            notebooks[2] = new Notebook("Macbook Air", 1500);
            notebooks[3] = new Notebook("Asus ROG", 3200);

            string opt;
            do
            {
                Console.WriteLine("1. Notebooklar uzerinde axtaris");
                Console.WriteLine("0. Menudan cix");

                opt = Console.ReadLine();

                if (opt == "1")
                {
                    Console.WriteLine("Axtaris deyerini daxil edin:");
                    string search = Console.ReadLine();

                    var filteredArr = SearchByName(notebooks, search);

                    ShowNotebooksInfo(filteredArr);
                }

            } while (opt!="0");
            
        }

        static Notebook[] SearchByName(Notebook[] arr,string search)
        {
            Notebook[] newArr = new Notebook[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Name.Contains(search))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }

            return newArr;
        }

        static void ShowNotebooksInfo(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetInfo());
            }
        }

        static void Add(ref Notebook[] arr,Notebook value)
        {
            Notebook[] newArr = new Notebook[arr.Length + 1];

            for (int i = 0;i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;

            arr = newArr;
        }
    }
}
