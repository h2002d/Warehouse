using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Repositories;


namespace WarehouseBack.Classes
{
    public class Rate
    {
        #region Private Members

        private static RateRepository mRateRepository = new RateRepository();

        #endregion

        #region Properties

        public int? RateID { get; set; }

        public string Name { get; set; }

        public float RateIn { get; set; }
        public float RateOut { get; set; }

        #endregion

        #region Static Methods

        public static List<Rate> GetCountries()
        {
            return mRateRepository.GetRates(null);
        }

        public static Rate GetRate(int rateId)
        {
            return mRateRepository.GetRates(rateId).FirstOrDefault();
        }


        #endregion


        #region Methods  (Save, Delete)

        public int Save()
        {
            return mRateRepository.Save(this);
        }

        public void Delete()
        {
            mRateRepository.Delete(this);
        }

        #endregion
    }
}