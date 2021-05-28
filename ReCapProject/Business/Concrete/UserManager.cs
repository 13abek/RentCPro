﻿using Business.Abstract;
using Business.Constance;
using Core.Entities.Concrete;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);

            return new SuccessResult(Message.Added);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Message.Deleted);
        }

        public IDataResult<User> GetByMail(string email)
        {
         return new SuccessDataResult<User>(_userDal.Get(u => u.Email==email));
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user),"Users Claims");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);

            return new SuccessResult(Message.Updated);
        }
    }
}