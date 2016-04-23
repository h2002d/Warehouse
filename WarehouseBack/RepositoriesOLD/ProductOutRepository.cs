using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Classes;


namespace WarehouseBack.Repositories
{
    internal class ProductOutRepository : Repository
    {
        internal int Save(ProductOut productOut)
        {
            command = database.GetStoredProcCommand("spProductOutSave");
            if (productOut.ProductOutID.HasValue)
                database.AddInParameter(command, "@ProductOutID", SqlDbType.Int, productOut.ProductOutID.Value);
            database.AddInParameter(command, "@ProductInID", SqlDbType.Int, productOut.ProductInID);
            database.AddInParameter(command, "@Amount", SqlDbType.Float, productOut.Amount);
            database.AddInParameter(command, "@Count", SqlDbType.Bit, productOut.Count);
            database.AddInParameter(command, "@UserID", SqlDbType.Int, productOut.UserID);

            return (int)database.ExecuteScalar(command);
        }

        internal void Delete(ProductOut productOut)
        {
            command = database.GetStoredProcCommand("spProductOutDelete");
            database.AddInParameter(command, "@ProductOutID", SqlDbType.Int, productOut.ProductOutID.Value);

            database.ExecuteNonQuery(command);
        }

        internal List<ProductOut> GetProductOuts(int? productOutId)
        {
            List<ProductOut> result = new List<ProductOut>();

            command = database.GetStoredProcCommand("spProductOutGet");
            if (productOutId.HasValue)
                database.AddInParameter(command, "@ProductOutID", SqlDbType.Int, productOutId.Value);

            using (var reader = database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    result.Add(new ProductOut
                    {  
                        ProductOutID = Convert.ToInt32(reader["ProductOutID"]),
                        ProductInID = Convert.ToInt32(reader["ProductInID"]),
                        Amount = Convert.ToSingle(reader["Amount"]),
                        Count = Convert.ToInt32(reader["Count"]),
                        CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                        UpdateDate = Convert.ToDateTime(reader["UpdateDate"]),
                        UserID = Convert.ToInt32(reader["UserID"]),

                    });
                }
            }

            return result;
        }


    }
}
