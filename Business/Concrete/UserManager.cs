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

        public UserManager(IUserDal userdal)
        {
            _userDal = userdal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.UserIdInvalid);
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserIsAdded); throw new NotImplementedException();
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserIsDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
            }
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == userId));
        }

        public IResult Update(User user)
        {
            if (user.UserId != user.UserId)
            {
                return new ErrorResult(Messages.UserIdInvalid);
            }
            _userDal.Update(user);
            return new SuccessResult(Messages.UserIsUpdated);
        }
    }
}
