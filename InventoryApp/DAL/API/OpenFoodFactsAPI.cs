using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InventoryApp.DAL.Entities;
using System.Net;
using System.IO;
using CodeBetter.Json;

namespace InventoryApp.DAL.API
{
    class OpenFoodFactsAPI
    {
        string URL = @"https://world.openfoodfacts.org/api/v0/product/{0}.json";

        public void GetProductDetails(string Barcode)
        {
            URL = String.Format(URL, Barcode);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            //JObject o = JObject.Parse(reader.ReadToEnd());
            var o = Converter.DeserializeFromFile<int[]>(reader.ReadToEnd());
        }

        //private static T _download_serialized_json_data<T>(string url) where T : new()
        //{
        //    using (var w = new WebClient())
        //    {
        //        var json_data = string.Empty;
        //        // attempt to download JSON data as a string
        //        try
        //        {
        //            json_data = w.DownloadString(url);
        //        }
        //        catch (Exception) { }
        //        // if string with JSON data is not empty, deserialize it to class and return its instance 
        //        return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
        //    }
        //}

        //private string TranslateText(string Input, string From, string To)
        //{
        //    // Set the language from/to in the url (or pass it into this function)
        //    Input = Input.Replace("&", "and");
        //    string url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", From, To, Uri.EscapeUriString(Input));
        //    HttpClient httpClient = new HttpClient();
        //    string result = httpClient.GetStringAsync(url).Result;

        //    // Get all json data
        //    var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);

        //    // Extract just the first array element (This is the only data we are interested in)
        //    var translationItems = jsonData[0];

        //    // Translation Data
        //    string translation = "";

        //    // Loop through the collection extracting the translated objects
        //    foreach (object item in translationItems)
        //    {
        //        // Convert the item array to IEnumerable
        //        IEnumerable translationLineObject = item as IEnumerable;

        //        // Convert the IEnumerable translationLineObject to a IEnumerator
        //        IEnumerator translationLineString = translationLineObject.GetEnumerator();

        //        // Get first object in IEnumerator
        //        translationLineString.MoveNext();

        //        // Save its value (translated text)
        //        translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
        //    }

        //    // Remove first blank character
        //    if (translation.Length > 1) { translation = translation.Substring(1); };

        //    // Return translation
        //    return translation;
        //}

    }
}
