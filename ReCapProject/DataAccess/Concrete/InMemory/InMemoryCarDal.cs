using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> {
            new Car{ CarId=1,BrandId=1,ColorId=1,DailyPrice=300,ModelYear="2019",Description="This is Description"},
            new Car{ CarId=2,BrandId=2,ColorId=2,DailyPrice=150,ModelYear="2017",Description="This is Description"},
            new Car{ CarId=3,BrandId=3,ColorId=2,DailyPrice=250,ModelYear="2020",Description="This is Description"},
            new Car{ CarId=4,BrandId=1,ColorId=3,DailyPrice=350,ModelYear="2021",Description="This is Description"},
            new Car{ CarId=5,BrandId=2,ColorId=1,DailyPrice=100,ModelYear="2014",Description="This is Description"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c=>c.CarId==car.CarId);

            _car.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void GetById(int carId)
        {
             _car.Where(c => c.CarId == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.FirstOrDefault(c => c.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
