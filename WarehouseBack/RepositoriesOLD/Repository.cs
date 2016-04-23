using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WarehouseBack.Repositories
{
        class Repository
        {
            #region Constants


            /// 
            private static string ConnectionName = "test";


            #endregion

            #region Private members

            private SqlDatabase _database;
            protected DbCommand command;

            #endregion

            #region Properties

            /// <summary>
            /// Connnection string that is defined in web.config
            /// </summary>
            private static string ConnectionString
            {
                get
                {
                    return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
                }
            }

            public SqlDatabase database
            {
                get
                {
                    if (_database == null)
                        _database = new SqlDatabase(ConnectionString);
                    return _database;
                }
            }

            #endregion
        }
}
