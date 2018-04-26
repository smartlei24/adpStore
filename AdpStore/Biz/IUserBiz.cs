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

        void UpdateUser(User user);

        bool AddNewUser(User user);

        void DeleteUserById(int id);

        bool CheckUserIsExist(User user);
    }
}
