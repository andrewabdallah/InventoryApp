using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using InventoryApp.DAL.DBConnection;
using InventoryApp.DAL.Entities;

namespace InventoryApp.DAL.Operations
{
    class ProductsOP
    {
        #region Select
        public static Products GetProduct(int _ProductID)
        {
            Products P = new Products();
            SqlCeCommand com = DBCon.CeCon.CreateCommand();

            com.CommandText = "SELECT PRODUCT_ID, PRODUCT_CODE, PRODUCT_NAME, PRODUCT_IMAGE FROM PRODUCTS WHERE PRODUCT_ID";
            SqlCeDataReader rd = com.ExecuteReader();
            if (rd.Read() && rd.HasRows)
            {
                P.PRODUCT_ID = rd["PRODUCT_ID"] == DBNull.Value ? null : rd["PRODUCT_ID"].ToString().ToNullableInt();
                P.PRODUCT_CODE = rd["PRODUCT_CODE"] == DBNull.Value ? null : rd["PRODUCT_CODE"].ToString();
                P.PRODUCT_NAME = rd["PRODUCT_NAME"] == DBNull.Value ? null : rd["PRODUCT_NAME"].ToString();
                P.PRODUCT_IMAGE = rd["PRODUCT_IMAGE"] == DBNull.Value ? null : rd["PRODUCT_IMAGE"].ToString().ToImage();
            }
            rd.Close();
            com.Dispose();
            return P;
        }

        #endregion


        #region Insert

        public static void InsertProduct(Products P)
        {
            SqlCeCommand com = DBCon.CeCon.CreateCommand();

            com.CommandText = "INSERT INTO PRODUCTS (PRODUCT_ID, PRODUCT_CODE, PRODUCT_NAME, PRODUCT_IMAGE) VALUES (@PRODUCT_ID, @PRODUCT_CODE, @PRODUCT_NAME, @PRODUCT_IMAGE)";
            com.Parameters.AddWithValue("PRODUCT_ID", P.PRODUCT_ID == null ? (object)DBNull.Value : P.PRODUCT_ID);
            com.Parameters.AddWithValue("PRODUCT_CODE", P.PRODUCT_CODE == null ? (object)DBNull.Value : P.PRODUCT_CODE);
            com.Parameters.AddWithValue("PRODUCT_NAME", P.PRODUCT_NAME == null ? (object)DBNull.Value : P.PRODUCT_NAME);
            com.Parameters.AddWithValue("PRODUCT_IMAGE", P.PRODUCT_IMAGE == null ? (object)DBNull.Value : P.PRODUCT_IMAGE.ToArrayOfBytes());
            com.ExecuteNonQuery();
            com.Dispose();
        }


        #endregion


        #region Update
        public static void UpdateProduct(Products P)
        {
            SqlCeCommand com = DBCon.CeCon.CreateCommand();

            com.CommandText = "UPDATE PRODUCTS SET PRODUCT_CODE = @PRODUCT_CODE, PRODUCT_NAME = @PRODUCT_NAME, PRODUCT_IMAGE = @PRODUCT_IMAGE WHERE PRODUCT_ID = @PRODUCT_ID";
            com.Parameters.AddWithValue("PRODUCT_ID", P.PRODUCT_ID == null ? (object)DBNull.Value : P.PRODUCT_ID);
            com.Parameters.AddWithValue("PRODUCT_CODE", P.PRODUCT_CODE == null ? (object)DBNull.Value : P.PRODUCT_CODE);
            com.Parameters.AddWithValue("PRODUCT_NAME", P.PRODUCT_NAME == null ? (object)DBNull.Value : P.PRODUCT_NAME);
            com.Parameters.AddWithValue("PRODUCT_IMAGE", P.PRODUCT_IMAGE == null ? (object)DBNull.Value : P.PRODUCT_IMAGE.ToArrayOfBytes());
            com.ExecuteNonQuery();
            com.Dispose();
        }

        #endregion


        #region Delete

        #endregion
    }
}
