using Business.Abstract;
using Business.ValidationRules.FulentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _cars;

        public CarManager(ICarDal car)
        {
            _cars = car;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
             
            ValidationTool.Validate(new CarValidator(), car);

            _cars.Add(car);
            return new SuccessResult("Melumat elave olundu");
        }

        public IResult Delete(Car car)
        {
            _cars.Delete(car);
            return new SuccessResult("Melumat Silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(),"Melumatlar Listlendi");
        }

        public IDataResult<Car> GetById(int carId)
        {
           

            return new SuccessDataResult<Car>(_cars.Get(c => c.CarId == carId), "Axtarishin Neticesi");
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _cars.GetCarDetails(),"Melumatin Detallari ");
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
           return new SuccessDataResult<List<Car>>(_cars.GetAll(c => c.BrandId == brandId),"Brend secimine gore avtomobillerin siyahisi");
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(c => c.ColorId == colorId),"Reng secimine gore avtomobilerin siyahisi");
        }

        public IResult Update(Car car)
        {
             _cars.Update(car);
           return new SuccessResult("Melumat Yenilendi");
        }
    }
}
