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

        public bool AddNewUser(User user)
        {
            var queryUser = this.dao.QueryUserByUserName(user.Name);
            if (queryUser == null)
            {
                this.dao.AddNewUser(user);
                return true;
            }

            return false;
        }

        public bool CheckUserIsExist(User user)
        {
            var queryUser = this.dao.QueryUserByUserName(user.Name);
            if (queryUser != null)
            {
                return user.Password.Equals(queryUser.Password);
            }
            else
            {
                return false;
            }
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
