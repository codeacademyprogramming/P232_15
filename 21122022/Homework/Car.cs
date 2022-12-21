using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Car:Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;
        public void AddFuel(int fuel)
        {
            if (CheckFuel(fuel)) //CurrentFuel+fuel<=FuelCapacity
            {
                CurrentFuel += fuel;
            }
        }

        public int GetFreeFuelCapacity()
        {
            return FuelCapacity - CurrentFuel;
        }

        public bool CheckFuel(int fuel)
        {
            return fuel <= GetFreeFuelCapacity();
        }
    }
}
