using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Steganography
{
    class exif
    {
        //variables
        Image myImage;
        PropertyItem[] data;
        //methods
        public void extractExif(string filePath)
        {
            myImage = Image.FromFile(filePath);
            data = myImage.PropertyItems; // builds array of EXIF data from jpeg
            List<int> IDs = new List<int>();
            List<int> types = new List<int>();
            List<byte[]> values = new List<byte[]>();
            foreach(PropertyItem p in data)
            {
                IDs.Add(p.Id);
                types.Add(p.Type);
                values.Add(p.Value);
            }
            
        }

        public string[] returnProperties()
        {
            return null;
        }
    }
}
