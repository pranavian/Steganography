using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

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

        // Methods
        public void setHidden(Image input)
        {
            hiddenData = imageToByte(input);
        }

        public void setCarrier(Image input)
        {
            carrierData = imageToByte(input);
        }

        private void stripHeader()
        {
            // Removes header from Image data
            int headerEndPosition;
            bool positionFound = false;
            while (positionFound == false)
            {
                for (int i = 0; i < carrierData.Length; i++)
                {
                    if (carrierData[i] == 00)
                    {
                        headerEndPosition = i;
                        positionFound = true;
                    }
                }
            }

            headerData = carrierData;
            imageData = carrierData;
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
            //string toShow = "";
            //for (int i = 0; i < 30; i++)
            //{
            //    toShow += input[i].ToString();
            //}
            //System.Windows.Forms.MessageBox.Show(toShow);
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

        public void startSteg(int optionChecked, string filePath)
        {
            // Takes two byte arrays and outputs a single byte array based on options selected
            //stripHeader();
            if (optionChecked == 2)
            {
                completeData = carrierData;
            }
            else
            {
                completeData = carrierData;
            }
            completeImage = byteToImage(completeData);
            try
            {
                completeImage.Save(filePath);
                System.Windows.Forms.MessageBox.Show("file Saved");
            }
            catch
            {

                System.Windows.Forms.MessageBox.Show("file failed to Save!");
            }
            
        }

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
