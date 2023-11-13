using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_GUI_PresentationLayer.Utilities
{
    public class Extension
    {
        public static byte[]? ImageToArrBytes(Image img)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                byte[]? arrImg = (byte[])converter.ConvertTo(img, typeof(byte[]));
                return arrImg;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Image ArrBytesToImage(byte[] arr)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(arr))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

       
    }
}
