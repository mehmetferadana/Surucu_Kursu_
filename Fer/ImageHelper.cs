using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tarantula_MTSK.Models
{
    internal class ImageHelper
    {
        public static Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        internal static byte[] ImageToByteArray(Image ımage)
        {
            throw new NotImplementedException();
        }


    }
}
