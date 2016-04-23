using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Repositories;


namespace WarehouseBack.Classes
{
    public class User
    {
        #region Private Members

        private static UserRepository mUserRepository = new UserRepository();

        #endregion

        #region Properties

        public int? UserID { get; set; }

        public string Name { get; set; }

        public int Persent { get; set; }


        #endregion

        #region Static Methods

        public static List<User> GetUsers()
        {
            return mUserRepository.GetUsers(null);
        }

        public static User GetUser(int userId)
        {
            return mUserRepository.GetUsers(userId).FirstOrDefault();
        }


        #endregion


        #region Methods  (Save, Delete)

        public int Save()
        {
            return mUserRepository.Save(this);
        }

        public void Delete()
        {
            mUserRepository.Delete(this);
        }

        #endregion
    }
}
