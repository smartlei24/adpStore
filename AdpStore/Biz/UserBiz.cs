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

        public void DeleteUserById(int id)
        {
            this.dao.DeleteUserById(id);
        }

        public User GetUserById(int id)
        {
            return this.dao.QueryUserById(id);
        }

        public List<User> QueryAllUser()
        {
            return this.dao.QueryAllUser();
        }

        public void UpdateUser(User user)
        {
            this.dao.UpdateUser(user);
        }
    }
}
