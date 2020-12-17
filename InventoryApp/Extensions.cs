using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryApp
{
    public static class Extenstions
    {
        public static int? ToNullableInt(this string _string)
        {
            int i;
            try
            {
                i = int.Parse(_string);
                return i;
            }
            catch
            {
                return null;
            }
        }

        public static DateTime? ToNullableDateTime(this string _string)
        {
            DateTime d;
            try
            {
                d = DateTime.Parse(_string);
                return d;
            }
            catch
            {
                return null;
            }
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
                image = _bytes.ToImage();
            }

            return image;
        }

        public static Image ToImage(this byte[] _bytes)
        {
            Image image = null;
            if (_bytes == null)
            {
                image = null;
            }
            else
            {
                image = new Bitmap(new MemoryStream(_bytes));
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
                 _image.Save(mStream,System.Drawing.Imaging.ImageFormat.Png);
                _bytes = mStream.ToArray();
            }
            return _bytes;
        }

        public static void AdjustPictureBox(this PictureBox picB)
        {
            picB.Dock = DockStyle.None;
            picB.SizeMode = PictureBoxSizeMode.StretchImage;
            picB.Width = (int)((float)picB.Image.Width / (float)picB.Image.Height * picB.Height);
            picB.Location = new Point((picB.Parent.Width - picB.Width) / 2, 0);
        }
    }
}
