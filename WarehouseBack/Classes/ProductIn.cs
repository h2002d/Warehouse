using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Repositories;

namespace WarehouseBack.Classes
{
    public class ProductIn
    {
        #region Private Members

        private static ProductInRepository mProductInRepository = new ProductInRepository();

        #endregion

        #region Properties

        public int? ProductInID { get; set; }

        public int CategoryID { get; set; }

        public string Name { get; set; }

        public float Amount { get; set; }

        public float OutAmount { get; set; }

        public int Count { get; set; }

        public int UnitID { get; set; }

        public int CurrCount { get; set; }

        public int MinCount { get; set; }

        public int ProducKey { get; set; }

        public int CountryID { get; set; }

        public int PlaceID { get; set; }

        public string PlaceName { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime CreateDate { get; set; }


        #endregion

        #region Static Methods

        public static List<ProductIn> GetProductIns()
        {
            return mProductInRepository.GetProductIns(null);
        }

        public static ProductIn GetProductIn(int productInId)
        {
            return mProductInRepository.GetProductIns(productInId).FirstOrDefault();
        }

        public static ProductIn GetProductInForSell(int productInId)
        {
            return mProductInRepository.GetProductInsSell(productInId).FirstOrDefault();
        }

        #endregion


        #region Methods  (Save, Delete)

        public int Save()
        {
            return mProductInRepository.Save(this);
        }

        public void Delete()
        {
            mProductInRepository.Delete(this);
        }

        #endregion
    }
}
