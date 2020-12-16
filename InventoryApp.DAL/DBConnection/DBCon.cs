using System;
using System.Data.SqlServerCe;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryApp.DAL.DBConnection
{
    public sealed class DBCon
    {
        static string _SqlCEConnectionString = @"Data Source =\InventoryApp\DB\InventoryDB.sdf;Password=123;Persist Security Info=True";
        static SqlCeConnection _CeCon;

        public static SqlCeConnection CeCon
        {
            get
            {
                OpenConnection();
                return _CeCon;
            }
        }

        public static void OpenConnection()
        {
            if (_CeCon == null || _CeCon.State != System.Data.ConnectionState.Open)
            {
                _CeCon = new SqlCeConnection(_SqlCEConnectionString);
                _CeCon.Open();
            }
        }

        public static void CloseConnection()
        {
            if (_CeCon != null && _CeCon.State == System.Data.ConnectionState.Open)
                _CeCon.Close();
        }
    }
}
