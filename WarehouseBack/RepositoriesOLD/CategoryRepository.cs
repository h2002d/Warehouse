using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Classes;

namespace WarehouseBack.Repositories
{
    internal class CategoryRepository : Repository
    {
        internal int Save(Category category)
        {
            command = database.GetStoredProcCommand("spCategorySave");
            if (category.CategoryID.HasValue)
                database.AddInParameter(command, "@CategoryID", SqlDbType.Int, category.CategoryID.Value);
            database.AddInParameter(command, "@Name", SqlDbType.NVarChar, category.Name);

            if (category.ParentID.HasValue)
                database.AddInParameter(command, "@ParentID", SqlDbType.Int, category.ParentID.Value);

            return (int)database.ExecuteScalar(command);
        }

        internal void Delete(Category category)
        {
            command = database.GetStoredProcCommand("spCategoryDelete");
            database.AddInParameter(command, "@CategoryID", SqlDbType.Int, category.CategoryID.Value);

            database.ExecuteNonQuery(command);
        }

        internal List<Category> GetCategories(int? categoryId)
        {
            List<Category> result = new List<Category>();

            command = database.GetStoredProcCommand("spCategoryGet");
            if (categoryId.HasValue)
                database.AddInParameter(command, "@CategoryID", SqlDbType.Int, categoryId.Value);

            using (var reader = database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    result.Add(new Category
                    {
                        CategoryID = Convert.ToInt32(reader["CategoryID"]),
                        Name = reader["Name"].ToString(),
                        ParentID = reader["ParentID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["ParentID"]),
                        HaveChild = Convert.ToBoolean(reader["HaveChild"]),
                        UpdateDate = Convert.ToDateTime(reader["UpdateDate"]),
                        CreateDate = Convert.ToDateTime(reader["CreateDate"])
                    });
                }
            }

            return result;
        }

        //internal List<Category> GetCategoriesByParentID(int? parentId)
        //{
        //    List<Category> result = new List<Category>();

        //    command = database.GetStoredProcCommand("spCategoryGetByParentID");
        //    if (parentId.HasValue)
        //        database.AddInParameter(command, "@ParentID", SqlDbType.Int, parentId.Value);

        //    using (var reader = database.ExecuteReader(command))
        //    {
        //        while (reader.Read())
        //        {
        //            result.Add(new Category
        //            {
        //                CategoryID = Convert.ToInt32(reader["CategoryID"]),
        //                Name = reader["Name"].ToString(),
        //                ParentID = reader["ParentID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["ParentID"]),
        //                HaveChild = Convert.ToBoolean(reader["HaveChild"])
        //            });
        //        }
        //    }

        //    return result;
        //}

        //internal bool CheckCategory(int categoryId)
        //{

        //    command = database.GetStoredProcCommand("spCategoryCheck");
        //    database.AddInParameter(command, "@CategoryID", SqlDbType.Int, categoryId);

        //    return ((int)database.ExecuteScalar(command)) > 0;
        //}
    }
}
