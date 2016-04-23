using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Classes;


namespace WarehouseBack.Repositories
{
    internal class CountryRepository : Repository
    {
        internal int Save(Country country)
        {
            command = database.GetStoredProcCommand("spCountrySave");
            if (country.CountryID.HasValue)
                database.AddInParameter(command, "@CountryID", SqlDbType.Int, country.CountryID.Value);
            database.AddInParameter(command, "@Name", SqlDbType.NVarChar, country.Name);

          

            return (int)database.ExecuteScalar(command);
        }

        internal void Delete(Country country)
        {
            command = database.GetStoredProcCommand("spCountryDelete");
            database.AddInParameter(command, "@CountryID", SqlDbType.Int, country.CountryID.Value);

            database.ExecuteNonQuery(command);
        }

        internal List<Country> GetCountries(int? countryId)
        {
            List<Country> result = new List<Country>();

            command = database.GetStoredProcCommand("spCountryGet");
            if (countryId.HasValue)
                database.AddInParameter(command, "@CountryID", SqlDbType.Int, countryId.Value);

            using (var reader = database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    result.Add(new Country
                    {
                        CountryID = Convert.ToInt32(reader["CountryID"]),
                        Name = reader["Name"].ToString(),
                        
                    });
                }
            }

            return result;
        }

        
    }
}

