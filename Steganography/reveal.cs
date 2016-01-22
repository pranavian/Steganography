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
        string imageType;
        System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
        System.Text.UTF8Encoding utf = new System.Text.UTF8Encoding();

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

        public void stripHeader()
        {
            // Removes header from Image data
            int headerEndPosition = -1;
            byte toFind1 = 0xFF;
            byte toFind2 = 0xDA;

            string bytes = "";
            for (int i = 6; i < 9; i++) // finds EXIF or JFIF signature, skipping JPEG signature
            {
                bytes += inputData[i].ToString();
            }

            if (bytes == "69120105")
            {
                imageType = "EXIF";
            }
            else
            {
                imageType = "JFIF";
            }

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
            if (headerEndPosition < 0 )
            {
                System.Windows.Forms.MessageBox.Show("SoS marker could not be found");
            }

            if (headerEndPosition >= 0)
            {
                headerData = inputData.Take(headerEndPosition).ToArray();
                imageData = inputData.Skip(headerEndPosition).ToArray();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("JPEG Start of Scan marker could not be found");
            }


        }

        public string decodeUTF(byte[] input)
        {
            
            List<string> text = new List<string>();
            string finalText = utf.GetString(input);
            int endPoint = -1;
            for (int i = 0; i < finalText.Length; i++)
            {
                char myChar = finalText[i];
                if (myChar > 122 || myChar < 48)
                {
                    finalText.Remove(i, 1);
                }
                if(myChar=='[' && finalText[i+1] ==']')
                {
                    endPoint = i;
                }
            }
            if(endPoint > -1)
            {
                finalText = finalText.Remove(endPoint, (finalText.Length - endPoint));
            }
            
            finalText = finalText.Replace('_', ' ');
            finalText = finalText.Replace('{', '.');
            finalText = finalText.Replace('}', ',');
            return finalText;
        }

        public byte[] reverseOrder()
        {
                byte[] newbytes = new byte[imageData.Length];
                /*int j = 0;
                for (int i = imageData.Length - 1; i >= 0; i=-2) // reverses the order of the bytes to signify last bytes first
                {
                    newbytes[j] = imageData[i];
                    j++;
                }*/
                return imageData.ToArray();
        }

        public string getBits(byte[] newbytes)
        {
            string listBits = ""; // creates empty container for bits
            const byte LeastSignificantBit = 1; //storage for constant value of Least Significant Bit for use in bitwise operations
            if (imageType == "EXIF") // Checks if jpeg is EXIF JPEG
            {
                for (int i = 2; i < 2040; i++) // creates string list of bits for use
                {
                    Console.Out.WriteLine(i.ToString() + "/" + newbytes.Length.ToString());
                    int b = newbytes[i] & LeastSignificantBit;
                    if (b == 1)
                    {
                        listBits += "1"; // adds string '1' to list of bits
                    }
                    else
                    {
                        listBits += "0";
                    }
                }
            }
            else
            {
                int imageLength = newbytes.Length;
                for (int i = 23; i < 2040; i++) // creates string list of bits for use
                {
                    if(i > (newbytes.Length -1))
                    {
                        break;
                    }
                    Console.Out.WriteLine(i.ToString() + "/" + newbytes.Length.ToString());
                    int b = newbytes[i] & LeastSignificantBit;
                    if (b == 1)
                    {
                        listBits += "1"; // adds string '1' to list of bits
                    }
                    else
                    {
                        listBits += "0";
                    }
                }
            }
            return listBits;
        }

        public byte[] extractData(byte[] newbytes, string listBits)
        {
            // Add check to see if image to be hidden is small enough
            try
            {
                List<byte> outData = new List<byte>();
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

                List<byte> nData = new List<byte>();
                for (int i = 7; i < outData.Count; i+=8)
                {
                    nData.Add(outData[i]);
                }

                return nData.ToArray();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
        }
            
    }
}
