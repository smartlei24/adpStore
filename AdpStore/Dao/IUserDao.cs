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

        void DeleteUserById(int id);

        User QueryUserById(int id);

        List<User> QueryAllUser();

        int UpdateUser(User user);

        User QueryUserByUserName(string name);
    }
}
