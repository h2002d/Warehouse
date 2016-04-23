using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Classes;


namespace WarehouseBack.Repositories
{
    internal class UserRepository : Repository
    {
        internal int Save(User user)
        {
            command = database.GetStoredProcCommand("spUserSave");
            if (user.UserID.HasValue)
                database.AddInParameter(command, "@UserID", SqlDbType.Int, user.UserID.Value);
            database.AddInParameter(command, "@Name", SqlDbType.NVarChar, user.Name);
            database.AddInParameter(command, "@Persent", SqlDbType.NVarChar, user.Persent);

            return (int)database.ExecuteScalar(command);
        }

        internal void Delete(User user)
        {
            command = database.GetStoredProcCommand("spUserDelete");
            database.AddInParameter(command, "@UserID", SqlDbType.Int, user.UserID.Value);

            database.ExecuteNonQuery(command);
        }

        internal List<User> GetUsers(int? userId)
        {
            List<User> result = new List<User>();

            command = database.GetStoredProcCommand("spUserGet");
            if (userId.HasValue)
                database.AddInParameter(command, "@UserID", SqlDbType.Int, userId.Value);

            using (var reader = database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    result.Add(new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        Name = reader["Name"].ToString(),
                        Persent = Convert.ToInt32(reader["Persent"]),

                    });
                }
            }

            return result;
        }


    }
}
