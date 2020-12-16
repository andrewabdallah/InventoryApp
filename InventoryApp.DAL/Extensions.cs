using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace InventoryApp.DAL
{
    public static class Extenstions
    {
        public static int? ToNullableInt(this string _string)
        {
            int i;
            if (int.TryParse(_string, out i)) return i;
            return null;
        }

        public static DateTime? ToNullableDateTime(this string _string)
        {
            DateTime d;
            if (DateTime.TryParse(_string, out d)) return d;
            return null;
        }


        public static Image ToImage(this string _string)
        {
            Image image;
            byte[] _bytes = Encoding.ASCII.GetBytes(_string);
            if (_bytes == null)
            {
                image = null;
            }
            else
            {
                MemoryStream mStream = new MemoryStream();
                mStream.Write(_bytes, 0, Convert.ToInt32(_bytes.Length));
                image = Image.FromStream(mStream);
            }

            return image;
        }

        public static Image ToImage(this byte[] _bytes)
        {
            Image image;
            if (_bytes == null)
            {
                image = null;
            }
            else
            {
                MemoryStream mStream = new MemoryStream();
                mStream.Write(_bytes, 0, Convert.ToInt32(_bytes.Length));
                image = Image.FromStream(mStream);
            }

            return image;
        }

        public static byte[] ToArrayOfBytes(this Image _image)
        {
            byte[] _bytes;
            if (_image == null)
            {
                _bytes = null;
            }
            else
            {
                MemoryStream mStream = new MemoryStream();
                _image.Save(mStream, _image.RawFormat);
                _bytes = mStream.ToArray();
            }
            return _bytes;
        }
    }
}
