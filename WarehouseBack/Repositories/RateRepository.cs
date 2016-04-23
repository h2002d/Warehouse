using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Classes;

namespace ClassLibrary1.Repositories
{
    class RateRepository
    {
    }
}
namespace WarehouseBack.Repositories
{
    internal class RateRepository : Repository
    {
        internal int Save(Rate rate)
        {
            command = database.GetStoredProcCommand("spRateSave");
            if (rate.RateID.HasValue)
                database.AddInParameter(command, "@RateID", SqlDbType.Int, rate.RateID.Value);
            database.AddInParameter(command, "@Name", SqlDbType.NVarChar, rate.Name);
            database.AddInParameter(command, "@RateIn", SqlDbType.Float, rate.RateIn);
            database.AddInParameter(command, "@RateOut", SqlDbType.Float, rate.RateOut);


            return (int)database.ExecuteScalar(command);
        }

        internal void Delete(Rate rate)
        {
            command = database.GetStoredProcCommand("spRateDelete");
            database.AddInParameter(command, "@RateID", SqlDbType.Int, rate.RateID.Value);

            database.ExecuteNonQuery(command);
        }

        internal List<Rate> GetRates(int? RateId)
        {
            List<Rate> result = new List<Rate>();

            command = database.GetStoredProcCommand("spRateGet");
            if (RateId.HasValue)
                database.AddInParameter(command, "@RateID", SqlDbType.Int, RateId.Value);

            using (var reader = database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    result.Add(new Rate
                    {
                        RateID = Convert.ToInt32(reader["RateID"]),
                        Name = reader["Name"].ToString(),
                        RateIn = Convert.ToSingle(reader["RateIn"]),
                        RateOut = Convert.ToSingle(reader["RateOut"]),

                    });
                }
            }

            return result;
        }


    }
}