using Telecare;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start building cars");
            List<CarFactory> myCars = new List<CarFactory>();
            myCars.Add(CarFactory.CreateCar(CarTypes.FamaliyCar, CarSafety.FirstSafe, "Blue"));
            myCars.Add(CarFactory.CreateCar(CarTypes.SportCar, CarSafety.SecondSafe, "Red"));
           

            Console.WriteLine("Compare cars:");
            myCars = myCars.CompareCars(true);


            Console.WriteLine("Specific feature vs car -  {0}:", myCars[0]);

                    if (myCars.HasSafety(car))
                    {
                        Console.WriteLine("Safety exist in {1} and is better: {0} [{2} ", myCars.HasSafety(FirstSafe), myCars.HasSafety(SecondSafe));
                    }
                    else
                    {
                        Console.WriteLine("Safety does not exist in {0}", car);
                    }
                }
            }

        }

