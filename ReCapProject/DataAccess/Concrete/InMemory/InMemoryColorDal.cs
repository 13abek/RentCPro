using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;

        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                new Color{ColorId=1,ColorName="Black"},
                new Color{ColorId=2,ColorName="White"},
                new Color{ColorId=3,ColorName="Pink"},
                new Color{ColorId=4,ColorName="blue"},
                new Color{ColorId=4,ColorName="Gray"},

            };
        }

        public  List<Color> GetAll()
        {
            return _colors;
        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.FirstOrDefault(co => co.ColorId == color.ColorId);
            _colors.Remove(colorToDelete);
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.FirstOrDefault(co => co.ColorId == color.ColorId);

            colorToUpdate.ColorId = color.ColorId;
            colorToUpdate.ColorName = color.ColorName;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
