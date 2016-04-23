using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Repositories;

namespace WarehouseBack.Classes
{
    
    public class Dept
    {
        #region Private Members

        private static DeptRepository mDeptRepository = new DeptRepository();

        #endregion

        #region Properties

        public int? DeptID { get; set; }
        public int ProductOutID { get; set; }
        public float PayedAmount { get; set; }
        public bool IsFinishDept { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserID { get; set; }

        #endregion

        #region Static Methods

        public static List<Dept> GetDepts()
        {
            return mDeptRepository.GetDepts(null);
        }

        public static Dept GetDept(int deptId)
        {
            return mDeptRepository.GetDepts(deptId).FirstOrDefault();
        }


        #endregion


        #region Methods  (Save, Delete)

        public int Save()
        {
            return mDeptRepository.Save(this);
        }

        public void Delete()
        {
            mDeptRepository.Delete(this);
        }
        public static string GetString()
        {
            return Repository.ConnectionString;
        }
        #endregion
    }

}
