using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Collections;

namespace Steganography
{
    class StegHide
    {
        // Variables
        private byte[] hiddenData;
        private byte[] carrierData;
        private byte[] headerData;
        private byte[] imageData;
        //private byte[] completeData;
        private Image completeImage;
        MemoryStream stream = new MemoryStream();
        System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();

        // Methods
        public void setHiddenImage(string input)
        {
            // Sets Hidden Image instance as Byte Array
            hiddenData = imageToByte(input);
        }

        public void setHiddenText(string input)
        {
            try
            {
                string nInput = checkChars(input);
                hiddenData = ascii.GetBytes(nInput);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

        }

        public void setCarrier(string input)
        {
            // Sets Carrier Image instance as Byte Array
            carrierData = imageToByte(input);

            // Check JPEG type needed here

            //foreach(byte x in carrierData)
            //{
            //    byte[] JFIFSignature = {0xFF);
            //    if(x == )
            //}
        }

        private void stripHeader()
        {
            // Removes header from Image data
            int headerEndPosition = -1;
            byte toFind1 = 0xFF;
            byte toFind2 = 0xDA;

            for (int i = carrierData.Length -2; i > 0; i--)
            {
                bool found = true;
                if (carrierData[i] != toFind1)
                {
                    found = false;
                }
                if(carrierData[i+1] != toFind2)
                {
                    found = false;
                }
                if(found == true)
                {
                    headerEndPosition = i;
                }
            }

            if (headerEndPosition >= 0)
            {
                System.Windows.Forms.MessageBox.Show("JPEG Start of Scan marker found at: " + headerEndPosition.ToString());
                headerData = carrierData.Take(headerEndPosition).ToArray();
                imageData = carrierData.Skip(headerEndPosition).ToArray();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("JPEG Start of Scan marker could not be found");
            }
            

        }

        private byte[] imageToByte(string input)
        {
            try
            {
                // Converts an image to a byte array
                byte[] output = File.ReadAllBytes(input);

                // Saves image to the stream as a Jpeg
                //input.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Outputs contents of stream to an array
                //output = stream.ToArray();
                return output;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Warning: Image byte conversion failed!");
                return null;
            }
        }

        private Image byteToImage(byte[] input)
        {
            try
            {
                // Saves stream contents as image file
                return Image.FromStream(stream);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Image could not be created from stream");
                return null;
            }
           
        }

        public void startSteg(string filePath, int hiddenType)
        {
            // Takes two byte arrays and outputs a single byte array based on options selected

            stripHeader();
            // Add check to see if image to be hidden is small enough

            //List<byte> inData = new List<byte>();
            string listBits = ""; // creates empty container for bits
            const byte LeastSignificantBit = 1; //storage for constant value of Least Significant Bit for use in bitwise operations
            for (int i = 0; i < hiddenData.Length; i++) // creates string list of bits for use
            {
                for (int y = 0; y < 8; y++)
                {
                    int b = hiddenData[i] & LeastSignificantBit;
                    if (b == 1)
                    {
                        listBits += "1"; // adds string '1' to list of bits
                    }
                    else
                    {
                        listBits += "0";
                    }
                    hiddenData[i] >>= 1;
                }
            }
            int j = 0;
            for (int i = imageData.Length - 2; i > 0; i--) // sets image data to include hidden data
            {
                if (listBits[j] == '1')
                {
                    imageData[i] |= 1; // if next bit is 1, set new bit in byte to be 1
                }
                else
                {
                    imageData[i] &= 254; // if next bit is 0, set new bit in byte to be 0
                }
                j++;
                if(j >= listBits.Length)
                {
                    break;
                }
            }



            // combine headerData and imageData into completeData 
            byte[] completeData = new byte[headerData.Length + imageData.Length];
            Array.Copy(headerData, completeData, headerData.Length);
            Array.Copy(imageData, 0, completeData, headerData.Length, imageData.Length);
            File.WriteAllBytes(filePath, completeData); // writes final image to disk without invoking JPEG compression

            // Saves image file to specified location
            try
            {
                File.WriteAllBytes(filePath, completeData);
                System.Windows.Forms.MessageBox.Show("File saved successfully");
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            
        }

        private string checkChars(string input)
        {
            input = input.Replace(' ', '_');
            input = input.Replace('.', '{');
            input = input.Replace(',', '}');

            return input;
        }

        private void clearImages()
        {
            //Clears all data to be used again
            this.hiddenData = null;
            this.carrierData = null;
            this.headerData = null;
            this.imageData = null;
            this.completeImage = null;
        }

        public Image getComplete()
        {
            //Returns final stego-carrier with hidden data
            try
            {
                return completeImage;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("null value returned");
                return null;
            }
            
        }

    }
}
