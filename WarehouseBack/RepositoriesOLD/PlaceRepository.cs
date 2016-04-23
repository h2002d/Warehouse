using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Classes;

namespace WarehouseBack.Repositories
{
    internal class PlaceRepository : Repository
    {
        internal int Save(Place Place)
        {
            command = database.GetStoredProcCommand("spPlaceSave");
            if (Place.PlaceID.HasValue)
                database.AddInParameter(command, "@PlaceID", SqlDbType.Int, Place.PlaceID.Value);
            database.AddInParameter(command, "@Name", SqlDbType.NVarChar, Place.Name);



            return (int)database.ExecuteScalar(command);
        }

        internal void Delete(Place place)
        {
            command = database.GetStoredProcCommand("spPlaceDelete");
            database.AddInParameter(command, "@PlaceID", SqlDbType.Int, place.PlaceID.Value);

            database.ExecuteNonQuery(command);
        }

        internal List<Place> GetPlaces(int? placeId)
        {
            List<Place> result = new List<Place>();

            command = database.GetStoredProcCommand("spPlaceGet");
            if (placeId.HasValue)
                database.AddInParameter(command, "@PlaceID", SqlDbType.Int, placeId.Value);

            using (var reader = database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    result.Add(new Place
                    {
                        PlaceID = Convert.ToInt32(reader["PlaceID"]),
                        Name = reader["Name"].ToString(),

                    });
                }
            }

            return result;
        }


    }
}
