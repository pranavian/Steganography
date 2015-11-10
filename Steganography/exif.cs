using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    class exif
    {
        //variables
        string[] properties;

        //methods
        public void extractExif(byte[] array)
        {
            // Find Exif objects
            int segmentStart = -1;
            int segmentEnd = -1;
            while(segmentStart < 0)
            {
                for (int i = 0; i < (array.Length - 1); i++)
                {
                    if (array[i] == 0xFF && array[i + 1] == 0xE1)
                    {
                        segmentStart = (i + 2);
                    }
                }
            }
            while(segmentEnd < 0)
            {
                for (int i = segmentStart; i < (array.Length - 1); i++)
                { 
                    if (array[i] == 0xFF && array[i + 1] == 0xDA)
                    {
                        segmentEnd = (i - 1);
                    }
                }
            }
            
            int segmentLength = segmentEnd - segmentStart;
            byte[] APP1 = array.Skip(segmentStart).Take(segmentLength).ToArray();

            // Build array of objects
            
        }

        public string[] returnProperties()
        {
            return properties;
        }
    }
}
