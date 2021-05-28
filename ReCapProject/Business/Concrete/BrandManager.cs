using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brand;
        public BrandManager(IBrandDal brand)
        {
            _brand = brand;
        }

        public IDataResult<Brand> GetById(int id)
        {

         return new SuccessDataResult<Brand>(_brand.Get(b => b.BrandId == id),"Operation Successfully!");
            
        }

        IResult IBrandService.Add(Brand brand)
        {
            _brand.Add(brand);
            return new SuccessResult("New Brand Add DataBase!");
        }

        IResult IBrandService.Delete(Brand brand)
        {
            _brand.Delete(brand);
            return new SuccessResult("Data Deleted!");
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
           return new SuccessDataResult<List<Brand>> (_brand.GetAll());
        }

        IResult IBrandService.Update(Brand brand)
        {
            _brand.Update(brand);
            return new SuccessResult("Data Updated");
        }
    }
}
