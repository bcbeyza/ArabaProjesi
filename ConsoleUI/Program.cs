using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+" / "+car.BrandName+"/ "+ car.ColorName);
            }


            Console.WriteLine("*************************");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetColorsByColorId(1))
            {
                Console.WriteLine(color.ColorName);
            }


            Console.ReadLine();
        }
    }
}
