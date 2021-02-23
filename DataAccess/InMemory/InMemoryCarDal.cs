﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=500, Description="Lamborghini"},
            new Car{Id=2, BrandId=2, ColorId=2, ModelYear=2018, DailyPrice=150, Description="Audi"},
            new Car{Id=3, BrandId=2, ColorId=3, ModelYear=2016, DailyPrice=80, Description="BMW"},
            new Car{Id=4, BrandId=3, ColorId=4, ModelYear=2019, DailyPrice=200, Description="Mercedes"},
            new Car{Id=5, BrandId=3, ColorId=4, ModelYear=2017, DailyPrice=100, Description="Maserati"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars;
        }

        public void Update(Car car)
        {
            //Gönderdiğim araba id sine sahip olan listedeki arabayı bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}