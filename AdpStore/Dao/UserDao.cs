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

        public void AddNewUser(User user)
        {
            this._db.GetCommand("AddANewUser").ExecuteScalar<User>(user);
        }

        public void DeleteUserById(int id)
        {
            this._db.GetCommand("DeleteUserById").ExecuteNonQuery(new
            {
                UserId = id
            });
        }

        public List<User> QueryAllUser()
        {
            return this._db.GetCommand("QueryAllUser").ExecuteEntityList<User>();
        }

        public User QueryUserById(int id)
        {
            return this._db.GetCommand("QueryUserById").ExecuteEntity<User>(new
            {
                UserId = id
            });
        }

        public User QueryUserByUserName(string name)
        {
            var a = this._db.GetCommand("QueryUserByName");
            return a.ExecuteEntity<User>(new
            {
                Name = name
            });
        }

        public int UpdateUser(User user)
        {
            return this._db.GetCommand("UpdateUserInfo").ExecuteNonQuery(user);
        }
    }
}
