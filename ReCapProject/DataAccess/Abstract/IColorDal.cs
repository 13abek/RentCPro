using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;
using DataAccess.Concrete.EtityFramwork;
using Core.DataAccess.EntityFramework;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
     

    }
}
