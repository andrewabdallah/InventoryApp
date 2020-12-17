using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryApp.DAL.API.OpenFoodFacts
{
    public class Rootobject
    {
        public string code { get; set; }
        public string status_verbose { get; set; }
        public int status { get; set; }
        public Product product { get; set; }
    }

    public class Product
    {
        public string product_name { get; set; }
        public string image_url { get; set; }
        public string code { get; set; }
    }
}
