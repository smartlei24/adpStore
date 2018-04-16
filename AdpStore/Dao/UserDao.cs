using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Models;
using VIC.DataAccess.Abstraction;

namespace AdpStore.Dao
{
    public class UserDao : IUserDao
    {
        private IDbManager _db;

        public UserDao(IDbManager db)
        {
            _db = db;
        }

        public User AddNewUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> QueryAllUser()
        {
            throw new NotImplementedException();
        }

        public User QueryUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User QueryUserByUserName(string name)
        {
            var a = this._db.GetCommand("QueryUserByName");
            return a.ExecuteEntity<User>(new
            {
                Name = name
            });
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
