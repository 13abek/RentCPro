using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EtityFramwork;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            // CarDetails();
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();
            car.CarName = "m3";
            car.BrandId = 1;
            car.ColorId = 1;
            car.DailyPrice = 100;
            car.Description = "This is Descripion";
            car.ModelYear = "2018";
            carManager.Add(car);
                

        }

        //private static void CarDetails()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.Add()
        //    {
        //        Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
        //    }
        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

           
        }
    }
}
