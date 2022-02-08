using Business.Abstract;
using Business.Constants;
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

        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirtsName.Length > 3)
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.UserAdded);
            }
            return new ErrorResult(Messages.UserNameInvalid);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.UsersListed);
        }

        public IDataResult<List<User>> GetAllByFirstName(string firstName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u =>u.FirtsName==firstName));
        }

        public IDataResult<List<User>> GetAllById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.Id == id));
        }
    }
}
