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
            CarTest();

            ColorTest();

            BrandTest();

            //CarCrudTest();

            //ColorCrudTest();

            //BrandCrudTest();


        }

        private static void BrandCrudTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand
            {
                BrandName = "BMW"
            });
            Console.WriteLine("BMW marka eklendi");

            brandManager.Update(new Brand
            {
                BrandId = 1,
                BrandName = "Zeynep"
            });
            Console.WriteLine("1 nolu marka Zeynep olarak güncellendi");

            brandManager.Delete(new Brand
            {
                BrandId = 7,
            });
            Console.WriteLine("7 nolu marka silindi");
        }

        private static void ColorCrudTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color
            {
                ColorName = "Kırmızı"
            });

            Console.WriteLine("Kırmızı renk eklendi");

            colorManager.Update(new Color
            {
                ColorId = 3,
                ColorName = "Beyaz"
            });

            Console.WriteLine("3 nolu renk beyaz olarak güncellendi");

            colorManager.Delete(new Color
            {
                ColorId = 5,
            });

            Console.WriteLine("5 nolu renk silindi");
        }

        private static void CarCrudTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {
                ColorId = 3,
                BrandId = 3,
                DailyPrice = 125,
                Description = "Eklenen yeni model",
                ModelYear = 2021
            });

            Console.WriteLine("Yeni araba eklendi");

            carManager.Update(new Car
            {
                Id = 1,
                ColorId = 3,
                BrandId = 3,
                DailyPrice = 125,
                Description = "1. araba güncellendi",
                ModelYear = 2021
            });

            Console.WriteLine("1. araba güncellendi");

            carManager.Delete(new Car
            {
                Id = 1
            });

            Console.WriteLine("1. araba silindi");

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetById(1);
            Console.WriteLine(" Color GetById Bulunan =");
            Console.WriteLine(result.ColorId + "/" +
                    result.ColorName);
            Console.WriteLine("Color GetById Bulunan sonu");

            Console.WriteLine(" Color GetAll Bulunan =");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + "/" +
                    color.ColorName);
            }
            Console.WriteLine(" Color GetAll Bulunan sonu");
        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetById(1);
            Console.WriteLine(" Brand GetById Bulunan =");
            Console.WriteLine(result.BrandId + "/" +
                    result.BrandName);
            Console.WriteLine("Brand GetById Bulunan sonu");

            Console.WriteLine(" Brand GetAll Bulunan =");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + "/" +
                    brand.BrandName);
            }
            Console.WriteLine(" Brand GetAll Bulunan sonu");
        }


        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetById(3);

            Console.WriteLine(" Car GetById Bulunan =");
            Console.WriteLine(result.Id + "/" +
                    result.ColorId + "/" +
                    result.BrandId + "/" +
                    result.DailyPrice + "/" +
                    result.Description + "/" +
                    result.ModelYear);
            Console.WriteLine("Car GetById Bulunan sonu");

            Console.WriteLine(" Car GetAll Bulunan =");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "/" +
                    car.ColorId + "/" +
                    car.BrandId + "/" +
                    car.DailyPrice + "/" +
                    car.Description + "/" +
                    car.ModelYear);
            }
            Console.WriteLine(" Car GetAll Bulunan sonu");


            Console.WriteLine(" Car GetCarsByBrandId Bulunan =");
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Id + "/" +
                    car.ColorId + "/" +
                    car.BrandId + "/" +
                    car.DailyPrice + "/" +
                    car.Description + "/" +
                    car.ModelYear);
            }
            Console.WriteLine(" Car GetCarsByBrandId Bulunan sonu");

            Console.WriteLine(" Car GetCarsByColorId Bulunan =");
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Id + "/" +
                    car.ColorId + "/" +
                    car.BrandId + "/" +
                    car.DailyPrice + "/" +
                    car.Description + "/" +
                    car.ModelYear);
            }
            Console.WriteLine(" Car GetCarsByColorId Bulunan sonu");

            Console.WriteLine(" Car GetCarDetails Bulunan =");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" +
                    car.BrandName + "/" +
                    car.ColorName + "/" +
                    car.DailyPrice);
            }
            Console.WriteLine(" Car GetCarDetails Bulunan sonu");
        }
    }
}