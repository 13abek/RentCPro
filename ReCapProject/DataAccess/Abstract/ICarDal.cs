using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Entities.DTOs;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
