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
        string hiddenFilePath = "";
        string encryptionKey;

        StegHide hideObject = new StegHide(); // Object that writes to Steganographic file
        StegReveal revealObject = new StegReveal(); // Object that reads from Steganographic file
        Encrypt encryption = new Encrypt(); // Object that offers encryption and decryption
        exif exifObject = new exif(); // Object that extracts and shows Exif data
        MemoryStream stream = new MemoryStream();

        public Stego()
        {
            InitializeComponent();
        }

        private byte[] imageToByte(Image input)
        {
            try
            {
                stream.Flush();
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
                    hideObject.setCarrier(filePath);
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
                    revealObject.setInput(mediumFilePath);
                    
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
        } // Set StegoMedium File

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void File_Path_Label_Click(object sender, EventArgs e)
        {

        }

        private void Create_Image_Button_Click(object sender, EventArgs e)
        {
            /* if (AES_Radio.Checked) // Checks which Encryption settings have been applied
            {
                if (Encryption_Key_Textbox.Text != "")
                {
                    encryption.setKey(encryptionKey);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No Encryption key provided. Using default key of 'password'.");
                encryption.setKey("password");
            } 

            //string encryptedText = encryption.EncryptAES(inText);
            //string decryptedText = encryption.DecryptAES(encryptedText);
            //System.Windows.Forms.MessageBox.Show("Encrypted Text: " + encryptedText + ". Decrypted Text: " + decryptedText);
            //}*/

            int hiddenFileType = 1;
            //if(hidden is text or hidden is image)
            //{
            //    hiddenFileType = 1;
            //}
            //else
            ///{
            //    hiddenFileType = 2;
            //}

            hideObject.setHiddenText(Input_Textbox.Text);
            hideObject.startSteg(outputFilePath, hiddenFileType); // Triggers the byte adjustments

           // Sets up environment to show Image 
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
                hideObject.setHiddenImage(hiddenFilePath);
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
            Output_TextBox.Text = revealObject.extractData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Encryption_Key_Textbox.Enabled = true;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AES_Radio_CheckedChanged(object sender, EventArgs e)
        {
            Encryption_Key_Textbox.Enabled = true;
            Key_Label.Enabled = true;
        }

        private void RC2_Radio_CheckedChanged(object sender, EventArgs e)
        {
            Encryption_Key_Textbox.Enabled = true;
            Key_Label.Enabled = true;
        }

        private void RSA_Radio_CheckedChanged(object sender, EventArgs e)
        {
            Encryption_Key_Textbox.Enabled = true;
            Key_Label.Enabled = true;
        }

        private void None_Radio_CheckedChanged(object sender, EventArgs e)
        {
            Encryption_Key_Textbox.Enabled = false;
            Key_Label.Enabled = true;
        }

        private void Save_Key_Button_Click(object sender, EventArgs e)
        {
            //encryptionKey = Encryption_Key_Textbox.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Select_Exif_Image_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                // Checks file is a jpeg
                string exifFilePath;
                if (openFileDialog1.FileName.EndsWith(".jpg") || openFileDialog1.FileName.EndsWith(".jpeg"))
                {
                    exifFilePath = openFileDialog1.FileName;
                    byte[] imageForExif = imageToByte(Image.FromFile(exifFilePath)); // opens file from file system to Byte Array
                    exifObject.extractExif(imageForExif);
                    
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("File must be jpeg format");
                }
            }
            catch (Exception t)
            {
                System.Windows.Forms.MessageBox.Show(t.Message);
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
