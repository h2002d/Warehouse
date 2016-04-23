using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Repositories;

namespace WarehouseBack.Classes
{
    public class Country
    {
        #region Private Members

        private static CountryRepository mCountryRepository = new CountryRepository();

        #endregion

        #region Properties

        public int? CountryID { get; set; }

        public string Name { get; set; }

       
        #endregion

        #region Static Methods

        public static List<Country> GetCountries()
        {
            return mCountryRepository.GetCountries(null);
        }

        public static Country GetCountry(int countryId)
        {
            return mCountryRepository.GetCountries(countryId).FirstOrDefault();
        }

       
        #endregion


        #region Methods  (Save, Delete)

        public int Save()
        {
            return mCountryRepository.Save(this);
        }

        public void Delete()
        {
            mCountryRepository.Delete(this);
        }

        #endregion
    }
}
