using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDeleteTest();
            //GetCarsColorIdTest();
            //GetCarBrandIdTest();
            //GetCarsDailyPriceTest();
            //CarUpdateTest();
            //CarAddTest();


            //ColorGetAllTest();
            //ColorGetByIdTest();
            //ColorAddTest();
            //ColorDeleteTest();
            //ColorUpdateTest();


            //BrandGetAllTest();
            //BrandGetByIdTest();
            //BrandAddTest();
            //BrandDeleteTest();
            //BrandUpdateTest();


        }

        private static void BrandUpdateTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.Update(new Brand { BrandId = 5, BrandName = "Mercedes" });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandDeleteTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.Delete(new Brand { BrandId = 3 });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.Add(new Brand() { BrandName = "Cadillac" });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandGetByIdTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(2).Data.BrandId + " " + brandManager.GetById(2).Data.BrandName);
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandId + " / " + brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        private static void ColorUpdateTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.Update(new Color() { ColorId = 4, ColorName = "Orange" });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorDeleteTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.Delete(new Color { ColorId = 5 });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.Add(new Color() { ColorName = "Purple" });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorGetByIdTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetById(2).Data.ColorId + " " + colorManager.GetById(2).Data.ColorName);
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in colorManager.GetAll().Data)
                {
                    Console.WriteLine(color.ColorId + " / " + color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Update(new Car()
            {
                Id = 5,
                BrandId = 3,
                ColorId = 3,
                CarName = "BMW",
                DailyPrice = 11300,
                Description = "Sports",
                ModelYear = 2010
            });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Delete(new Car { Id = 4 });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByBrandId(4);

            if (result.Success)
            {
                foreach (var car in carManager.GetCarsByBrandId(4).Data)
                {
                    Console.WriteLine($"The car is listed with BrandId.\n {car.CarName}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarsColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByColorId(3);

            if (result.Success)
            {
                foreach (var car in carManager.GetCarsByColorId(3).Data)
                {
                    Console.WriteLine(car.Description + " Color ID : " + car.ColorId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarsDailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetByDailyPrice(5000, 15000);
            if (result.Success)
            {
                foreach (var car in carManager.GetByDailyPrice(5000, 15000).Data)
                {
                    Console.WriteLine(car.Description + " DailyPrice: " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.Add(new Car()
            {
                CarName = "Ferrari",
                ColorId = 3,
                DailyPrice = 13200,
                BrandId = 2,
                Description = "Sports",
                ModelYear = 1987
            });

            if (result.Success)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine("Car Name : {0}", car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

    }
}
