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
        private byte[] completeData;
        private Image completeImage;
        MemoryStream stream = new MemoryStream();
        System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();

        // Methods
        public void setHiddenImage(Image input)
        {
            // Sets Hidden Image instance as Byte Array
            hiddenData = imageToByte(input);
        }

        public void setHiddenText(string input)
        {
            hiddenData = ascii.GetBytes(input);
        }

        public void setCarrier(Image input)
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

            for (int i = 0; i < carrierData.Length -1 ; i++)
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

        private byte[] imageToByte(Image input)
        {
            try
            {
                // Converts an image to a byte array
                byte[] output;
                // Saves image to the stream as a Jpeg
                input.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Outputs contents of stream to an array
                output = stream.ToArray();
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

        public void startSteg(int optionChecked, string filePath, int hiddenType)
        {
            // Takes two byte arrays and outputs a single byte array based on options selected
            
            stripHeader();

            // Checks type of Steganography Algorithm selected
            if (optionChecked == 2)
            {
                // Add check to see if image to be hidden is small enough
                //completeData = carrierData;
                List<bool> bits = new List<bool>();
                foreach(byte x in imageData)
                {

                }

            }
            else
            {
                //XOR hidden to Front of imageData
                //completeData = carrierData;
            }
            
            // combine headerData and imageData into completeData 
            completeImage = byteToImage(completeData); // converts final byte array into an image


            // Saves image file to specified location
            try
            {
                completeImage.Save(filePath);
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            
        } // Needs Completing


        private void clearImages()
        {
            //Clears all data to be used again
            this.hiddenData = null;
            this.carrierData = null;
            this.headerData = null;
            this.imageData = null;
            this.completeData = null;
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
