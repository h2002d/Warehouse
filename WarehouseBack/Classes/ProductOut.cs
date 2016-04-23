using ClassLibrary1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Repositories;



namespace WarehouseBack.Classes
{

    public class ProductOut
    {
        #region Private Members

        private static ProductOutRepository mProductOutRepository = new ProductOutRepository();

        #endregion

        #region Properties
        public int? ProductOutID { get; set; }
        public int ProductInID { get; set; }
        public float Amount { get; set; }
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserID { get; set; }

        #endregion

        #region Static Methods

        public static List<ProductOut> GetProductOuts()
        {
            return mProductOutRepository.GetProductOuts(null);
        }

        public static ProductOut GetProductOut(int productOutId)
        {
            return mProductOutRepository.GetProductOuts(productOutId).FirstOrDefault();
        }


        #endregion


        #region Methods  (Save, Delete)

        public int Save()
        {
            return mProductOutRepository.Save(this);
        }

        public void Delete()
        {
            mProductOutRepository.Delete(this);
        }

        #endregion
    }

}
