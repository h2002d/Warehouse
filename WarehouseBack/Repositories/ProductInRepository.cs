using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Classes;



namespace WarehouseBack.Repositories
{
    internal class ProductInRepository : Repository
    {
        internal int Save(ProductIn productIn)
        {
            command = database.GetStoredProcCommand("spProductInSave");
            if (productIn.ProductInID.HasValue)
                database.AddInParameter(command, "@ProductInID", SqlDbType.Int, productIn.ProductInID.Value);
            database.AddInParameter(command, "@CategoryID", SqlDbType.Int, productIn.CategoryID);//
            database.AddInParameter(command, "@Name", SqlDbType.NVarChar, productIn.Name);//
            database.AddInParameter(command, "@UnitID", SqlDbType.Int, productIn.UnitID);//
            database.AddInParameter(command, "@Amount", SqlDbType.Float, productIn.Amount);//
            database.AddInParameter(command, "@OutAmount", SqlDbType.Float, productIn.OutAmount);//
            database.AddInParameter(command, "@Count", SqlDbType.Int, productIn.Count);//
            database.AddInParameter(command, "@CurrCount", SqlDbType.Int, productIn.CurrCount);//
            database.AddInParameter(command, "@MinCount", SqlDbType.Int, productIn.MinCount);
            database.AddInParameter(command, "@ProducKey", SqlDbType.Int, productIn.ProducKey);//
            database.AddInParameter(command, "@CountryID", SqlDbType.Int, productIn.CountryID);//
            database.AddInParameter(command, "@PlaceName", SqlDbType.NVarChar, "pl");//
            database.AddInParameter(command, "@PlaceID", SqlDbType.Int, productIn.PlaceID);//

            return (int)database.ExecuteScalar(command);
        }

        internal void Delete(ProductIn productIn)
        {
            command = database.GetStoredProcCommand("spProductInDelete");
            database.AddInParameter(command, "@ProductInID", SqlDbType.Int, productIn.ProductInID.Value);

            database.ExecuteNonQuery(command);
        }

        internal List<ProductIn> GetProductIns(int? ProductInId)
        {
            List<ProductIn> result = new List<ProductIn>();

            command = database.GetStoredProcCommand("spProductInGet");
            if (ProductInId.HasValue)
                database.AddInParameter(command, "@ProductInID", SqlDbType.Int, ProductInId.Value);

            using (var reader = database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    result.Add(new ProductIn
                    {
                        ProductInID = Convert.ToInt32(reader["ProductInID"]),
                        CategoryID = Convert.ToInt32(reader["CategoryID"]),
                        Name = reader["Name"].ToString(),
                        UnitID = Convert.ToInt32(reader["UnitID"]),
                        Amount = Convert.ToSingle(reader["Amount"]),
                        OutAmount = Convert.ToSingle(reader["OutAmount"]),
                        Count = Convert.ToInt32(reader["Count"]),
                        CurrCount = Convert.ToInt32(reader["CurrCount"]),
                        MinCount = Convert.ToInt32(reader["MinCount"]),
                        ProducKey = Convert.ToInt32(reader["ProducKey"]),
                        CountryID = Convert.ToInt32(reader["CountryID"]),
                        PlaceName = reader["PlaceName"].ToString(),
                        CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                        UpdateDate = Convert.ToDateTime(reader["UpdateDate"])
                    });
                }
            }

            return result;
        }

        internal List<ProductIn> GetProductInsSell(int? ProductInId)
        {
            List<ProductIn> result = new List<ProductIn>();

            command = database.GetStoredProcCommand("spGetProdForSale");
            if (ProductInId.HasValue)
                database.AddInParameter(command, "@ProductId", SqlDbType.Int, ProductInId.Value);

            using (var reader = database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    result.Add(new ProductIn
                    {
                        ProductInID = Convert.ToInt32(reader["ProductInID"]),
                        CategoryID = Convert.ToInt32(reader["CategoryID"]),
                        Name = reader["Name"].ToString(),
                        UnitID = Convert.ToInt32(reader["UnitID"]),
                        Amount = Convert.ToSingle(reader["Amount"]),
                        OutAmount = Convert.ToSingle(reader["OutAmount"]),
                        Count = Convert.ToInt32(reader["Count"]),
                        CurrCount = Convert.ToInt32(reader["CurrCount"]),
                        MinCount = Convert.ToInt32(reader["MinCount"]),
                        ProducKey = Convert.ToInt32(reader["ProducKey"]),
                        CountryID = Convert.ToInt32(reader["CountryID"]),
                        PlaceName = reader["PlaceName"].ToString(),
                        CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                        UpdateDate = Convert.ToDateTime(reader["UpdateDate"])
                    });
                }
            }

            return result;
        }
      
    }
}
