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
        private string filePath;
        private string outputFilePath;
        private string mediumFilePath;
        private string hiddenFilePath = "";
        private bool isImageSelected = false;


        StegHide hideObject = new StegHide(); // Object that writes to Steganographic file
        StegReveal revealObject = new StegReveal(); // Object that reads from Steganographic file
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
                    isImageSelected = true;
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
            string str = Input_Textbox.Text;
            bool flag = false;
            foreach(char x  in str)
            {
                if(char.IsDigit(x) || char.IsNumber(x)) // Checks if characters is a number. Throws up issue. 
                {
                    flag = true;
                }
            }
            if(!flag) // checks incorrect input flag is set to no invalid characters
            {
                int hiddenFileType = 1;
                hideObject.setHiddenText(str); // Sets hidden text to Text Box
                hideObject.startSteg(outputFilePath, hiddenFileType); // Triggers the byte adjustments

                // Sets up environment to show Image 
                Post_Image_Holder.ImageLocation = outputFilePath;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Invalid characters in text");
            }
            
            
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
            Progress.Value = 40;
            if (isImageSelected)
            {
                revealObject.stripHeader();
                Progress.Value = 50;
                byte[] data = revealObject.reverseOrder();
                Progress.Value = 60;
                string listBits = revealObject.getBits(data);
                Progress.Value = 80;
                byte[] data2 = revealObject.extractData(data, listBits);
                Progress.Value = 100;
                Output_TextBox.Text = revealObject.decodeUTF(data2);
                Progress.Value = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No image selected!");
                Progress.Value = 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
                    Exif_List.Items.Clear();
                    exifFilePath = openFileDialog1.FileName;
                    Exif_Picture.ImageLocation = exifFilePath;
                    exifObject.extractExif(exifFilePath);
                    int[] IDs = exifObject.returnIDs();
                    string[] values = exifObject.returnValues();
                    changeIds(IDs, values);
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

        private void changeIds(int[] input, string[] values)
        {
            for (int i = 0; i < input.Length; i++)
            {
                ListViewItem itm = new ListViewItem();
                bool replaced = false;
                if (input[i] == 270)
                {
                    itm.Text = "Image Description";
                    replaced = true;
                }
                if (input[i] == 271)
                {
                    itm.Text = "Camera Make";
                    replaced = true;
                }
                if (input[i] == 272)
                {
                    itm.Text = "Camera Model";
                    replaced = true;
                }
                if (input[i] == 305)
                {
                    itm.Text = "Software Used";
                    replaced = true;
                }
                if (input[i] == 306)
                {
                    itm.Text = "Last Edit Time/Date";
                    replaced = true;
                }
                if (input[i] == 315)
                {
                    itm.Text = "Artist";
                    replaced = true;
                }
                if (input[i] == 800)
                {
                    itm.Text = "Image Title";
                    replaced = true;
                }
                if (input[i] == 20496)
                {
                    itm.Text = "Jpeg Quality";
                    replaced = true;
                }
                if (input[i] == 33432)
                {
                    itm.Text = "Copyright";
                    replaced = true;
                }
                if (input[i] == 36864)
                {
                    itm.Text = "Exif Version";
                    replaced = true;
                }
                if (input[i] == 36867)
                {
                    itm.Text = "Creation Date/Time";
                    replaced = true;
                }
                if (input[i] == 37387)
                {
                    itm.Text = "Focal Length";
                    replaced = true;
                }
                if (input[i] == 37389)
                {
                    itm.Text = "User Comment";
                    replaced = true;
                }
                if (input[i] == 42036)
                {
                    itm.Text = "Focal Length / Aperture";
                    replaced = true;
                }

                if (replaced)
                {
                    itm.SubItems.Add(values[i].ToString());
                    Exif_List.Items.Add(itm);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.Show();
        }
    }
}
