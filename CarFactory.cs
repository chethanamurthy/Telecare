using System;
using System.Collections.Generic;
using System.Linq;

namespace Telecare
{
    public class CarFactory
    {
        public CarTypes Model;
        public CarSafety HighlySafe;
        public string Color;
        private float price;

        public float Price
        {
            get { return price; }
        }
        internal CarFactory(CarTypes model, CarSafety HighlySafe, string color, float price)
        {
            this.Model = model;
            this.HighlySafe = HighlySafe;
            this.Color = color;
            this.price = price;
        }

    }

    public static class CarFac
    {
        public static CarFactory CreateCar(CarTypes model, CarSafety HighlySafe, string color, float price)
        {
            CarFactory newCar = null;
            switch (HighlySafe)
            {
                case CarSafety.FirstSafe:
                    newCar = new CarFactory(model, HighlySafe, color, 75000);
                    break;

                case CarSafety.SecondSafe:
                    newCar = new CarFactory(model, HighlySafe, color, 85000);
                    break;
            }

            Console.WriteLine("Car was created:\n Model: {0}\nSafety: {1}\nHas {2} Safety\nPrice:{3}\n*************************\n\n", newCar.Model, newCar.HighlySafe, newCar.Price);

            return newCar;
        }
    }

    public enum CarSafety
    {
       FirstSafe,
       SecondSafe
    }

    public enum CarTypes
    {
        SportCar,
        FamaliyCar
    }

    public static class Extensions
    {

        public static List<CarFactory> CompareCars(this List<CarFactory> cars, bool sort = false)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-7} ", "Safety", "Model", "Price");
            Console.WriteLine("{0,-15} {1,-15} {2,-7} ", "-----------", "-----", "-----");

            foreach (CarFactory car in cars)
            {
                Console.WriteLine("{0,-15} {1,-15} {3,-10}", car.HighlySafe, car.Model, car.Price);
            }
            return cars;
       

        }
    }
}