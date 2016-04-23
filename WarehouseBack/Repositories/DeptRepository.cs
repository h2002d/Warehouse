using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBack.Classes;


namespace WarehouseBack.Repositories
{
    internal class DeptRepository : Repository
    {
        internal int Save(Dept dept)
        {
            command = database.GetStoredProcCommand("spDeptSave");
            if (dept.DeptID.HasValue)
                database.AddInParameter(command, "@DeptID", SqlDbType.Int, dept.DeptID.Value);
            database.AddInParameter(command, "@ProductOutID", SqlDbType.Int, dept.ProductOutID);
            database.AddInParameter(command, "@PayedAmount", SqlDbType.Float, dept.PayedAmount);
            database.AddInParameter(command, "@IsFinishDept", SqlDbType.Bit, dept.IsFinishDept);
            database.AddInParameter(command, "@UserID", SqlDbType.Int, dept.UserID);




            return (int)database.ExecuteScalar(command);
        }

        internal void Delete(Dept Dept)
        {
            command = database.GetStoredProcCommand("spDeptDelete");
            database.AddInParameter(command, "@DeptID", SqlDbType.Int, Dept.DeptID.Value);

            database.ExecuteNonQuery(command);
        }

        internal List<Dept> GetDepts(int? DeptId)
        {
            List<Dept> result = new List<Dept>();

            command = database.GetStoredProcCommand("spDebtGet");
            if (DeptId.HasValue)
                database.AddInParameter(command, "@DeptID", SqlDbType.Int, DeptId.Value);

            using (var reader = database.ExecuteReader(command))
            {
                while (reader.Read())
                {
                    result.Add(new Dept
                    {
                        DeptID = Convert.ToInt32(reader["DeptID"]),
                        ProductOutID = Convert.ToInt32(reader["ProductOutID"]),
                        PayedAmount = Convert.ToSingle(reader["PayedAmount"]),
                        IsFinishDept = Convert.ToBoolean(reader["IsFinishDept"]),
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
