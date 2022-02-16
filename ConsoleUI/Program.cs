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

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName + "/ " + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            


            Console.WriteLine("**************************");

            ColorManager colorManager = new ColorManager(new EfColorDal());


            var result2 = colorManager.GetAllColorsByColorId(1);

            if (result2.Success == true)
            {
                foreach (var color in result2.Data)
                {
                    Console.WriteLine(color.ColorName);
                }

            }
            else
            {
                Console.WriteLine(result2.Message);
            }



            Console.ReadLine();
        }
    }
}
