using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryApp.DAL.Entities
{
    class ProductExpiryDates
    {
        #region Private Fields
        private Nullable<int> _PRODUCT_ID;
        private Nullable<DateTime> _PRODUCT_EXPIRY_DATE;
        #endregion

        #region Public Fields
        public Nullable<int> PRODUCT_ID
        {
            get { return _PRODUCT_ID; }
            set { _PRODUCT_ID = value; }
        }

        public Nullable<DateTime> PRODUCT_EXPIRY_DATE
        {
            get { return _PRODUCT_EXPIRY_DATE; }
            set { _PRODUCT_EXPIRY_DATE = value; }
        }
        #endregion
    }
}
