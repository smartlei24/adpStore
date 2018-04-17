using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Dao
{
    public interface IUserDao
    {
        void AddNewUser(User user);

        bool DeleteUserById(int id);

        User QueryUserById(int id);

        List<User> QueryAllUser();

        User UpdateUser(User user);

        User QueryUserByUserName(string name);
    }
}
