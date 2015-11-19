using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Collections;

namespace Steganography
{
    class StegReveal
    {
        // variables
        private byte[] inputData;
        private byte[] extracted;
        private string extractText;
        private byte[] imageData;
        private byte[] headerData;

        //methods

        public void setInput(Image input)
        {
            try
            {
                // Converts an image to a byte array
                using (MemoryStream stream = new MemoryStream())
                {
                    // Saves image to the stream as a Jpeg
                    input.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // Outputs contents of stream to an array
                    inputData = stream.ToArray();
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Warning: Image byte conversion failed!");
            }
        }

        public string getText()
        {
            return extractText;
        }

        private void stripHeader()
        {
            // Removes header from Image data
            int headerEndPosition = -1;
            byte toFind1 = 0xFF;
            byte toFind2 = 0xDA;

            for (int i = 0; i < inputData.Length - 1; i++)
            {
                bool found = true;
                if (inputData[i] != toFind1)
                {
                    found = false;
                }
                if (inputData[i + 1] != toFind2)
                {
                    found = false;
                }
                if (found == true)
                {
                    headerEndPosition = i;
                }
            }

            if (headerEndPosition >= 0)
            {
                System.Windows.Forms.MessageBox.Show("JPEG Start of Scan marker found at: " + headerEndPosition.ToString());
                headerData = inputData.Take(headerEndPosition).ToArray();
                imageData = inputData.Skip(headerEndPosition).ToArray();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("JPEG Start of Scan marker could not be found");
            }


        }

        public void extractData()
        {
            stripHeader();
            // Add check to see if image to be hidden is small enough
            //completeData = carrierData;
            List<bool> outData = new List<bool>();
            try
            {
                for (int i = 0; i <= imageData.Length; i++)
                {
                    //Break byte into bits
                    BitArray bits = new BitArray(imageData[i]);
                    int lastBit = (bits.Length - 1);
                    //Sets last bit in byte to bit of hidden data
                    if (bits[lastBit] == true)
                    {
                        outData.Add(true);
                    }
                    else
                    {
                        outData.Add(false);
                    }
                    //Collect together bits back to byte
                }
                BitArray outBits = new BitArray(outData.Count);
                for (int i = 0; i < outData.Count; i++)
                {
                    outBits[i] = outData[i];
                }
                extractText = outBits.ToString();


                //extracted = carrierData;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
            
    }
}
