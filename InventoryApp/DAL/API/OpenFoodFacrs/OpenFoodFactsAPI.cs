using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InventoryApp.DAL.Entities;
using System.Net;
using System.IO;
using CodeBetter.Json;
using System.Drawing;

namespace InventoryApp.DAL.API.OpenFoodFacts
{
    class OpenFoodFactsAPI
    {

        public static Products GetProductDetails(string Barcode)
        {
            try
            {
                string URL = @"https://world.openfoodfacts.org/api/v0/product/{0}.json";
                URL = String.Format(URL, Barcode);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                //JObject o = JObject.Parse(reader.ReadToEnd());
                Rootobject R = Converter.DeserializeFromFile<Rootobject>(reader.ReadToEnd());
                if (R.status_verbose == "product found")
                    return MapOPenFoodsFacts(R.product);
                else
                    return null;
            }
            catch
            {
                Products P = new Products();
                P.PRODUCT_CODE = Barcode;
                P.PRODUCT_NAME = Barcode;
                P.PRODUCT_IMAGE = new Bitmap(79, 79, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                return P;
                throw new Exception("Internet connection issue");
            }
        }

        private static Products MapOPenFoodsFacts(Product OpP)
        {
            Products P = new Products();
            P.PRODUCT_CODE = OpP.code;
            P.PRODUCT_NAME = OpP.product_name;
            P.PRODUCT_IMAGE = getImageFromURL(OpP.image_url);
            return P;
        }

        private static Bitmap getImageFromURL(String sURL)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(sURL);
            myRequest.Method = "GET";
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
            myResponse.Close();

            return bmp;
        }

    }
}
