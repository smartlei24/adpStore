using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Dao;
using AdpStore.Models;

namespace AdpStore.Biz
{
    public class UserBiz : IUserBiz
    {
        private IUserDao dao;

        public UserBiz(IUserDao dao)
        {
            this.dao = dao;
        }

        public User AddNewUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool CheckUserIsExist(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> QueryAllUser()
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
