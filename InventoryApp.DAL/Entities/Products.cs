using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InventoryApp.DAL.Entities
{
    class Products
    {
        #region Private Fields
        private Nullable<int> _PRODUCT_ID;
        private string _PRODUCT_CODE;
        private string _PRODUCT_NAME;
        private Image _PRODUCT_IMAGE;
        #endregion

        #region Public Fields
        public Nullable<int> PRODUCT_ID
        {
            get { return _PRODUCT_ID; }
            set { _PRODUCT_ID = value; }
        }

        public string PRODUCT_CODE
        {
            get { return _PRODUCT_CODE; }
            set { _PRODUCT_CODE = value; }
        }

        public string PRODUCT_NAME
        {
            get { return _PRODUCT_NAME; }
            set { _PRODUCT_NAME = value; }
        }

        public Image PRODUCT_IMAGE
        {
            get
            {
                return _PRODUCT_IMAGE;
            }
            set
            {
                _PRODUCT_IMAGE = value;
            }
        }
        #endregion

    }
}
