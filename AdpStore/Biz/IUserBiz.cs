using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Biz
{
    public interface IUserBiz
    {
        List<User> QueryAllUser();

        User GetUserById(int id);

        User UpdateUser(User user);

        User AddNewUser(User user);

        bool DeleteUserById(int id);

        bool CheckUserIsExist(User user);
    }
}
