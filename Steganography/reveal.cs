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
                byte[] newbytes = new byte[imageData.Length];
                int j = 0;
                for (int i = imageData.Length -1; i >= 0; i--) // reverses the order of the bytes to signify last bytes first
                {
                    newbytes[j] = imageData[i];
                    j++;
                }

                string listBits = ""; // creates empty container for bits
                List<byte> outData = new List<byte>();
                const byte LeastSignificantBit = 1; //storage for constant value of Least Significant Bit for use in bitwise operations
                for (int i = 0; i < newbytes.Length; i++) // creates string list of bits for use
                { 
                    int b = newbytes[i] & LeastSignificantBit;
                    if(b == 1)
                    {
                        listBits += "1"; // adds string '1' to list of bits
                    }
                    else
                    {
                        listBits += "0";
                    }
                }

                
                bool cont = true;
                while(cont) // goes through list of bits converts to seperate strings of 8 bits (a byte)
                {
                    string toAdd = "";
                    byte b = 00;
                    toAdd = listBits.Substring(0, 8); // copies 8 bits
                    for(int i = (toAdd.Length -1); i >= 0; i--) // goes through each bit
                    {
                        b <<= 1; // Bitshift left to create new bit on end
                        if (toAdd[i] == '1')
                        {
                            b |= 1; // if next bit is 1, set new bit in byte to be 1
                        }
                        else
                        {
                            b &= 254; // if next bit is 0, set new bit in byte to be 0
                        }
                        outData.Add(b); // adds created byte to list of data pulled from image
                    }
                    listBits = listBits.Remove(0, 8); // removes 8 bits just added to compiled list
                    if (listBits.Length <=7) // checks if there is 8 more bits to turn into byte
                    {
                        break;
                    }
                }
                
                return ascii.GetString(outData.ToArray());

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
        }
            
    }
}
