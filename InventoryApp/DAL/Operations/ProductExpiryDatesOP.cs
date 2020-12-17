using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using InventoryApp.DAL.DBConnection;
using InventoryApp.DAL.Entities;

namespace InventoryApp.DAL.Operations
{
    class ProductExpiryDatesOP
    {
        #region Select
        public static ProductExpiryDates GetNearestProductExpiryDate(Nullable<int> ProductID)
        {
            ProductExpiryDates PExp = new ProductExpiryDates();
            SqlCeCommand com = DBCon.CeCon.CreateCommand();

            com.CommandText = "SELECT PRODUCT_ID, MIN(PRODUCT_EXPIRY_DATE) AS PRODUCT_EXPIRY_DATE FROM PRODUCT_EXPIRY_DATES WHERE PRODUCT_ID = @PRODUCT_ID GROUP BY PRODUCT_ID";
            com.Parameters.AddWithValue("PRODUCT_ID", ProductID);
            SqlCeDataReader rd = com.ExecuteReader();
            if (rd.Read())
            {
                PExp.PRODUCT_ID = rd["PRODUCT_ID"] == DBNull.Value ? null : rd["PRODUCT_ID"].ToString().ToNullableInt();
                PExp.PRODUCT_EXPIRY_DATE = rd["PRODUCT_EXPIRY_DATE"] == DBNull.Value ? null : rd["PRODUCT_EXPIRY_DATE"].ToString().ToNullableDateTime();
            }
            rd.Close();
            com.Dispose();
            return PExp;
        }

        #endregion


        #region Insert

        public static void InsertProductExpiryDate(ProductExpiryDates PExp)
        {
            SqlCeCommand com = DBCon.CeCon.CreateCommand();

            com.CommandText = "INSERT INTO PRODUCT_EXPIRY_DATES (PRODUCT_ID, PRODUCT_EXPIRY_DATE) VALUES (@PRODUCT_ID, @PRODUCT_EXPIRY_DATE)";
            com.Parameters.AddWithValue("PRODUCT_ID", PExp.PRODUCT_ID == null ? (object)DBNull.Value : PExp.PRODUCT_ID);
            com.Parameters.AddWithValue("PRODUCT_EXPIRY_DATE", PExp.PRODUCT_EXPIRY_DATE == null ? (object)DBNull.Value : PExp.PRODUCT_EXPIRY_DATE);
            com.ExecuteNonQuery();
            com.Dispose();
        }


        #endregion


        #region Update
        public static void UpdateProductExpiryDate(ProductExpiryDates PExp)
        {
            SqlCeCommand com = DBCon.CeCon.CreateCommand();

            com.CommandText = "UPDATE PRODUCT_EXPIRY_DATES SET PRODUCT_EXPIRY_DATE = @PRODUCT_EXPIRY_DATE WHERE PRODUCT_ID = @PRODUCT_ID";
            com.Parameters.AddWithValue("PRODUCT_ID", PExp.PRODUCT_ID == null ? (object)DBNull.Value : PExp.PRODUCT_ID);
            com.Parameters.AddWithValue("PRODUCT_EXPIRY_DATE", PExp.PRODUCT_EXPIRY_DATE == null ? (object)DBNull.Value : PExp.PRODUCT_EXPIRY_DATE);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        #endregion


        #region Delete

        #endregion
    }
}
