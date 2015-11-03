using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Steganography
{
    public partial class Stego : Form
    {
        string filePath;
        string outputFilePath;
        string mediumFilePath;
        string hiddenFilePath;
        Image img;
        Image img2;
        StegHide hideObject = new StegHide();
        StegReveal revealObject = new StegReveal();

        public Stego()
        {
            InitializeComponent();
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void Choose_File_Button_Click(object sender, EventArgs e)
        {
                        
        }

        private void Save_Location_Button_Click(object sender, EventArgs e)
        {

        }

        private void Choose_File_Button_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                // Checks file is a jpeg
                if (openFileDialog1.FileName.EndsWith(".jpg") || openFileDialog1.FileName.EndsWith(".jpeg"))
                {
                    // Sets up environment by showing image etc.
                    filePath = openFileDialog1.FileName;
                    Save_Location_Button.Enabled = true;
                    Pre_Image_Holder.ImageLocation = filePath;
                    // Sets image instance to the chosen image
                    hideObject.setCarrier(Image.FromFile(filePath));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("File must be jpeg format");
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("File could not be opened");
                return;
            }
        }

        private void Save_Location_Button_Click_1(object sender, EventArgs e)
        {
            // Displays file save dialog
            saveFileDialog1.ShowDialog();
            outputFilePath = saveFileDialog1.FileName;
            Create_Image_Button.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName.EndsWith(".jpg") || openFileDialog1.FileName.EndsWith(".jpeg"))
                {
                    // Set up environment to show photo
                    mediumFilePath = openFileDialog1.FileName;
                    File_Path_Label.Text = mediumFilePath;
                    Reveal_Button.Enabled = true;
                    Output_TextBox.Enabled = true;
                    Stegomedium_Picture_Holder.ImageLocation = mediumFilePath;
                    Reveal_Button.Enabled = true;
                    Output_TextBox.Enabled = true;

                    // Open image to Byte Array
                    revealObject.setInput(Image.FromFile(mediumFilePath));
                    
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("To continue, please select a JPEG file");
                    return;
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error: File could not be opened");
            }
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void File_Path_Label_Click(object sender, EventArgs e)
        {

        }

        private void Create_Image_Button_Click(object sender, EventArgs e)
        {
            int optionChecked;
            if(End_LSB_Option.Checked)
            {
                optionChecked = 2;
            }
            else
            {
                optionChecked = 1;
            }
            hideObject.startSteg(optionChecked, outputFilePath);
            // Saves image file to specified location
            //try
            //{
                
            //    System.Windows.Forms.MessageBox.Show("Image saved");
            //}
            //catch
            //{
            //    System.Windows.Forms.MessageBox.Show("Image could not be saved");
            //}
            // Sets up environment to show image
            Post_Image_Holder.ImageLocation = outputFilePath;
            
        }

        private void End_LSB_Option_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Front_LSB_Option_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Choose_Hidden_Image_Button_Click(object sender, EventArgs e)
        {
            // Shows dialog to select which file to open
            openFileDialog1.ShowDialog();
            // Checks image is a jpeg
            if (openFileDialog1.FileName.EndsWith(".jpg") || openFileDialog1.FileName.EndsWith(".jpeg"))
            {
                // Sets up environment to show image
                hiddenFilePath = openFileDialog1.FileName;
                Hidden_Placeholder.ImageLocation = hiddenFilePath;
                // Sets image instance to image from file
                img = Image.FromFile(hiddenFilePath);
                hideObject.setHidden(img);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File must be jpeg format");
            }

        }

        private void Hidden_Placeholder_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Reveal_Button_Click(object sender, EventArgs e)
        {
            revealObject.extractData();
            Output_TextBox.Text = revealObject.getText();
        }
    }
}
