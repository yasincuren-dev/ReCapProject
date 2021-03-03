using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Business.Abstract;
using Entities.Concrete;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand {BrandName="BMW"});
            brandManager.Add(new Brand { BrandName = "Toyota"});

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color {ColorName="mavi" });

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 2, ColorId = 1, ModelYear=2015, DailyPrice=160000, Description="kiralık" });
            carManager.Add(new Car { ColorId = 2, BrandId = 1, DailyPrice = 240000, Description = "Satılık", ModelYear = 2019 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }

        }
    }
}
