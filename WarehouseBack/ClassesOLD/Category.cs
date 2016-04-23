using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Repositories;

namespace WarehouseBack.Classes

{
    public class Category
    {
        #region Private Members

        private static CategoryRepository mCategoryRepository = new CategoryRepository();

        #endregion

        #region Properties

        public int? CategoryID { get; set; }

        public string Name { get; set; }

        public int? ParentID { get; set; }

        public bool HaveChild { get; set; }

        public DateTime  UpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
      

        #endregion

        #region Static Methods

        public static List<Category> GetCategories()
        {
            return mCategoryRepository.GetCategories(null);
        }

        public static Category GetCategory(int categoryId)
        {
            return mCategoryRepository.GetCategories(categoryId).FirstOrDefault();
        }

        //public static List<Category> GetCategoriesByParentID(int? parentId)
        //{
        //    return mCategoryRepository.GetCategoriesByParentID(parentId);
        //}

        //public static bool CheckCategory(int categoryId)
        //{
        //    return mCategoryRepository.CheckCategory(categoryId);
        //}

        #endregion


        #region Methods  (Save, Delete)

        public int Save()
        {
            return mCategoryRepository.Save(this);
        }

        public void Delete()
        {
            mCategoryRepository.Delete(this);
        }

        #endregion
    }
}
