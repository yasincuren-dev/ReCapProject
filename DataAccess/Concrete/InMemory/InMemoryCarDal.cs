using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, ColorId=1, BrandId=1, ModelYear=2015, DailyPrice=150000, Description="Kiralık"},
                new Car{Id=2, ColorId=1, BrandId=2, ModelYear=2018, DailyPrice=180000, Description="Kiralık"},
                new Car{Id=3, ColorId=2, BrandId=1, ModelYear=2019, DailyPrice=250000, Description="Satılık"},
                new Car{Id=4, ColorId=2, BrandId=4, ModelYear=2012, DailyPrice=75000, Description="Satılık"},
                new Car{Id=5, ColorId=3, BrandId=3, ModelYear=2020, DailyPrice=350000, Description="Kiralık"},
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(item => item.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
        }
    }
 }

