using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Repositories;

namespace WarehouseBack.Classes
{
    public class Place
    {
        #region Private Members

        private static PlaceRepository mPlaceRepository = new PlaceRepository();

        #endregion

        #region Properties

        public int? PlaceID { get; set; }

        public string Name { get; set; }


        #endregion

        #region Static Methods

        public static List<Place> GetPlaces()
        {
            return mPlaceRepository.GetPlaces(null);
        }

        public static Place GetPlace(int placeId)
        {
            return mPlaceRepository.GetPlaces(placeId).FirstOrDefault();
        }


        #endregion


        #region Methods  (Save, Delete)

        public int Save()
        {
            return mPlaceRepository.Save(this);
        }

        public void Delete()
        {
            mPlaceRepository.Delete(this);
        }

        #endregion
    }
}
