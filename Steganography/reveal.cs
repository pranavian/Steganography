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
        private byte[] imageData;
        private byte[] headerData;
        System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();

        //methods

        public void setInput(string input)
        {
            try
            {
                // Converts an image to a byte array
                inputData = File.ReadAllBytes(input);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Warning: Image byte conversion failed!");
            }
        }

        private void stripHeader()
        {
            // Removes header from Image data
            int headerEndPosition = -1;
            byte toFind1 = 0xFF;
            byte toFind2 = 0xDA;

            for (int i = inputData.Length - 2; i > 0; i--)
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

        public string extractData()
        {
            stripHeader();
            // Add check to see if image to be hidden is small enough
            try
            {
                //List<int> outData = new List<int>();
                

                ///////
                List<byte> outData = new List<byte>();
                int bitcount = 0; // tracks how many bits are in the byte-maker
                byte outByte = 0; // bits to be added to byte
                foreach (byte x in imageData)
                {
                    BitArray bits = new BitArray(new byte[] { x });
                    bool finalBit = bits.Get(bits.Length -1);
                    outByte *= 2;
                    if(finalBit == true)
                    {
                        outByte++;
                    }
                    bitcount++;
                    if (bitcount == 8) // checks if enough bits to make a byte. If so, adds byte and resets byte-maker
                    {
                        outData.Add(outByte); // adds complete bits to a byte
                        bitcount = 0; // resets counter
                        outByte = 0; // resets byte-maker
                    }
                }
                byte[] extracted = outData.ToArray(); // converts list to array
                return ascii.GetString(extracted, 0, extracted.Length);
                //extracted = carrierData;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
        }
            
    }
}
