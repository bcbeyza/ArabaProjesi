using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {

        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetAllById(int id);
        IDataResult<List<User>> GetAllByFirstName(string firstName);
        IResult Add(User user);
    }
}
