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

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }
            
            
           
        }
    }
}
