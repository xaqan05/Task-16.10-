using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16._10_
{
    public class Gallery1

    {
        public Car1[] cars;

        public Gallery1()
        {
            cars = new Car1[0];
        }
        public void AddCar(Car1 car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;

            Console.WriteLine("Masin sisteme elave olundu");
        }

        public void FilterCar(string brand)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Brand == brand)
                {
                    Console.WriteLine($"Brand: {cars[i].Brand} Model: {cars[i].Model}, Mile: {cars[i].Mile}");
                }
            }
        }
        public void FilterCar(double mile)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Mile == mile)
                {
                    Console.WriteLine($"Brand: {cars[i].Brand} Model: {cars[i].Model}, Mile: {cars[i].Mile}");
                }
            }
        }
    }
}
