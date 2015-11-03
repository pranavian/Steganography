﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Steganography
{
    class StegReveal
    {
        // variables
        byte[] inputData;
        //byte[] extracted;
        string extractText;

        //methods

        public void setInput(Image input)
        {
            inImageToByte(input);
        }

        private void inImageToByte(Image input)
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

        public void extractData()
        {
            extractText = "test extract";
        }
    }
}