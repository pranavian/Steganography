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
        private Image image;
        private PropertyItem[] props;
        private System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();


        //methods
        public void extractExif(string exifFilePath)
        {
            image = new Bitmap(exifFilePath);
            props = image.PropertyItems;
        }

        public int[] returnIDs()
        {
            List<int> idList = new List<int>();
            foreach (PropertyItem itm in props)
            {
                idList.Add(itm.Id);

            }
            return idList.ToArray();
        }

        public string[] returnValues()
        {
            List<string> valueList = new List<string>();
            foreach(PropertyItem itm in props)
            {
                string str = ascii.GetString(itm.Value);
                valueList.Add(str);
            }
            return valueList.ToArray();
        }
    }
}