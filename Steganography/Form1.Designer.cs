namespace Steganography
{
    partial class Stego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Menu_Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Post_Image_Holder = new System.Windows.Forms.PictureBox();
            this.Pre_Image_Holder = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Text_Box_Label = new System.Windows.Forms.Label();
            this.Input_Textbox = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Hidden_Placeholder = new System.Windows.Forms.PictureBox();
            this.Choose_Hidden_Image_Button = new System.Windows.Forms.Button();
            this.Create_Image_Button = new System.Windows.Forms.Button();
            this.Save_Location_Button = new System.Windows.Forms.Button();
            this.Choose_File_Button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Output_TextBox = new System.Windows.Forms.RichTextBox();
            this.Reveal_Button = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.Stegomedium_Picture_Holder = new System.Windows.Forms.PictureBox();
            this.File_Path_Label = new System.Windows.Forms.Label();
            this.Reveal_Carrier_File_Button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.End_LSB_Option = new System.Windows.Forms.RadioButton();
            this.Front_LSB_Option = new System.Windows.Forms.RadioButton();
            this.Menu_Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Post_Image_Holder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pre_Image_Holder)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hidden_Placeholder)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stegomedium_Picture_Holder)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // Menu_Tabs
            // 
            this.Menu_Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_Tabs.Controls.Add(this.tabPage1);
            this.Menu_Tabs.Controls.Add(this.tabPage2);
            this.Menu_Tabs.Controls.Add(this.tabPage3);
            this.Menu_Tabs.Location = new System.Drawing.Point(1, 2);
            this.Menu_Tabs.Name = "Menu_Tabs";
            this.Menu_Tabs.SelectedIndex = 0;
            this.Menu_Tabs.Size = new System.Drawing.Size(503, 359);
            this.Menu_Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.tabControl1);
            this.tabPage1.Controls.Add(this.Create_Image_Button);
            this.tabPage1.Controls.Add(this.Save_Location_Button);
            this.tabPage1.Controls.Add(this.Choose_File_Button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Steganography Hide";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Post_Image_Holder);
            this.panel1.Controls.Add(this.Pre_Image_Holder);
            this.panel1.Location = new System.Drawing.Point(208, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 324);
            this.panel1.TabIndex = 15;
            // 
            // Post_Image_Holder
            // 
            this.Post_Image_Holder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Post_Image_Holder.BackColor = System.Drawing.Color.Gainsboro;
            this.Post_Image_Holder.Location = new System.Drawing.Point(5, 169);
            this.Post_Image_Holder.Name = "Post_Image_Holder";
            this.Post_Image_Holder.Size = new System.Drawing.Size(275, 150);
            this.Post_Image_Holder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Post_Image_Holder.TabIndex = 11;
            this.Post_Image_Holder.TabStop = false;
            // 
            // Pre_Image_Holder
            // 
            this.Pre_Image_Holder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pre_Image_Holder.BackColor = System.Drawing.Color.Gainsboro;
            this.Pre_Image_Holder.Location = new System.Drawing.Point(5, 6);
            this.Pre_Image_Holder.Name = "Pre_Image_Holder";
            this.Pre_Image_Holder.Size = new System.Drawing.Size(275, 153);
            this.Pre_Image_Holder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pre_Image_Holder.TabIndex = 10;
            this.Pre_Image_Holder.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(7, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 227);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Text_Box_Label);
            this.tabPage4.Controls.Add(this.Input_Textbox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 201);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Hide Text";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Text_Box_Label
            // 
            this.Text_Box_Label.AutoSize = true;
            this.Text_Box_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Box_Label.Location = new System.Drawing.Point(6, 3);
            this.Text_Box_Label.Name = "Text_Box_Label";
            this.Text_Box_Label.Size = new System.Drawing.Size(86, 17);
            this.Text_Box_Label.TabIndex = 15;
            this.Text_Box_Label.Text = "Text to hide:";
            // 
            // Input_Textbox
            // 
            this.Input_Textbox.Location = new System.Drawing.Point(9, 23);
            this.Input_Textbox.Name = "Input_Textbox";
            this.Input_Textbox.Size = new System.Drawing.Size(175, 172);
            this.Input_Textbox.TabIndex = 14;
            this.Input_Textbox.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Hidden_Placeholder);
            this.tabPage5.Controls.Add(this.Choose_Hidden_Image_Button);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 201);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Hide Image";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Hidden_Placeholder
            // 
            this.Hidden_Placeholder.Location = new System.Drawing.Point(7, 63);
            this.Hidden_Placeholder.Name = "Hidden_Placeholder";
            this.Hidden_Placeholder.Size = new System.Drawing.Size(179, 135);
            this.Hidden_Placeholder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hidden_Placeholder.TabIndex = 1;
            this.Hidden_Placeholder.TabStop = false;
            this.Hidden_Placeholder.Click += new System.EventHandler(this.Hidden_Placeholder_Click);
            // 
            // Choose_Hidden_Image_Button
            // 
            this.Choose_Hidden_Image_Button.Location = new System.Drawing.Point(6, 6);
            this.Choose_Hidden_Image_Button.Name = "Choose_Hidden_Image_Button";
            this.Choose_Hidden_Image_Button.Size = new System.Drawing.Size(180, 50);
            this.Choose_Hidden_Image_Button.TabIndex = 0;
            this.Choose_Hidden_Image_Button.Text = "Choose Image to Hide";
            this.Choose_Hidden_Image_Button.UseVisualStyleBackColor = true;
            this.Choose_Hidden_Image_Button.Click += new System.EventHandler(this.Choose_Hidden_Image_Button_Click);
            // 
            // Create_Image_Button
            // 
            this.Create_Image_Button.Enabled = false;
            this.Create_Image_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Create_Image_Button.Location = new System.Drawing.Point(7, 303);
            this.Create_Image_Button.Name = "Create_Image_Button";
            this.Create_Image_Button.Size = new System.Drawing.Size(188, 23);
            this.Create_Image_Button.TabIndex = 9;
            this.Create_Image_Button.Text = "Create Stegomedium";
            this.Create_Image_Button.UseVisualStyleBackColor = true;
            this.Create_Image_Button.Click += new System.EventHandler(this.Create_Image_Button_Click);
            // 
            // Save_Location_Button
            // 
            this.Save_Location_Button.Enabled = false;
            this.Save_Location_Button.Location = new System.Drawing.Point(7, 42);
            this.Save_Location_Button.Name = "Save_Location_Button";
            this.Save_Location_Button.Size = new System.Drawing.Size(196, 23);
            this.Save_Location_Button.TabIndex = 8;
            this.Save_Location_Button.Text = "Choose Destination";
            this.Save_Location_Button.UseVisualStyleBackColor = true;
            this.Save_Location_Button.Click += new System.EventHandler(this.Save_Location_Button_Click_1);
            // 
            // Choose_File_Button
            // 
            this.Choose_File_Button.Location = new System.Drawing.Point(7, 13);
            this.Choose_File_Button.Name = "Choose_File_Button";
            this.Choose_File_Button.Size = new System.Drawing.Size(196, 23);
            this.Choose_File_Button.TabIndex = 7;
            this.Choose_File_Button.Text = "Choose Carrier File";
            this.Choose_File_Button.UseVisualStyleBackColor = true;
            this.Choose_File_Button.Click += new System.EventHandler(this.Choose_File_Button_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.Stegomedium_Picture_Holder);
            this.tabPage2.Controls.Add(this.File_Path_Label);
            this.tabPage2.Controls.Add(this.Reveal_Carrier_File_Button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(495, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Steganography Reveal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(8, 154);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(486, 173);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.Output_TextBox);
            this.tabPage6.Controls.Add(this.Reveal_Button);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(478, 147);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Reveal Text";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Output_TextBox
            // 
            this.Output_TextBox.Enabled = false;
            this.Output_TextBox.Location = new System.Drawing.Point(6, 32);
            this.Output_TextBox.Name = "Output_TextBox";
            this.Output_TextBox.Size = new System.Drawing.Size(466, 104);
            this.Output_TextBox.TabIndex = 4;
            this.Output_TextBox.Text = "";
            // 
            // Reveal_Button
            // 
            this.Reveal_Button.Enabled = false;
            this.Reveal_Button.Location = new System.Drawing.Point(6, 3);
            this.Reveal_Button.Name = "Reveal_Button";
            this.Reveal_Button.Size = new System.Drawing.Size(124, 23);
            this.Reveal_Button.TabIndex = 3;
            this.Reveal_Button.Text = "Reveal Message";
            this.Reveal_Button.UseVisualStyleBackColor = true;
            this.Reveal_Button.Click += new System.EventHandler(this.Reveal_Button_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(478, 147);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Reveal Image";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Stegomedium_Picture_Holder
            // 
            this.Stegomedium_Picture_Holder.BackColor = System.Drawing.Color.LightGray;
            this.Stegomedium_Picture_Holder.Location = new System.Drawing.Point(8, 36);
            this.Stegomedium_Picture_Holder.Name = "Stegomedium_Picture_Holder";
            this.Stegomedium_Picture_Holder.Size = new System.Drawing.Size(483, 111);
            this.Stegomedium_Picture_Holder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Stegomedium_Picture_Holder.TabIndex = 5;
            this.Stegomedium_Picture_Holder.TabStop = false;
            // 
            // File_Path_Label
            // 
            this.File_Path_Label.AutoSize = true;
            this.File_Path_Label.Location = new System.Drawing.Point(133, 11);
            this.File_Path_Label.Name = "File_Path_Label";
            this.File_Path_Label.Size = new System.Drawing.Size(85, 13);
            this.File_Path_Label.TabIndex = 4;
            this.File_Path_Label.Text = "No File Selected";
            this.File_Path_Label.Click += new System.EventHandler(this.File_Path_Label_Click);
            // 
            // Reveal_Carrier_File_Button
            // 
            this.Reveal_Carrier_File_Button.Location = new System.Drawing.Point(7, 6);
            this.Reveal_Carrier_File_Button.Name = "Reveal_Carrier_File_Button";
            this.Reveal_Carrier_File_Button.Size = new System.Drawing.Size(124, 23);
            this.Reveal_Carrier_File_Button.TabIndex = 0;
            this.Reveal_Carrier_File_Button.Text = "Choose Carrier File";
            this.Reveal_Carrier_File_Button.UseVisualStyleBackColor = true;
            this.Reveal_Carrier_File_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.End_LSB_Option);
            this.tabPage3.Controls.Add(this.Front_LSB_Option);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(495, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Steganography Algorithm:";
            // 
            // End_LSB_Option
            // 
            this.End_LSB_Option.AutoSize = true;
            this.End_LSB_Option.Location = new System.Drawing.Point(101, 23);
            this.End_LSB_Option.Name = "End_LSB_Option";
            this.End_LSB_Option.Size = new System.Drawing.Size(67, 17);
            this.End_LSB_Option.TabIndex = 1;
            this.End_LSB_Option.Text = "End LSB";
            this.End_LSB_Option.UseVisualStyleBackColor = true;
            this.End_LSB_Option.CheckedChanged += new System.EventHandler(this.End_LSB_Option_CheckedChanged);
            // 
            // Front_LSB_Option
            // 
            this.Front_LSB_Option.AutoSize = true;
            this.Front_LSB_Option.Checked = true;
            this.Front_LSB_Option.Location = new System.Drawing.Point(23, 24);
            this.Front_LSB_Option.Name = "Front_LSB_Option";
            this.Front_LSB_Option.Size = new System.Drawing.Size(72, 17);
            this.Front_LSB_Option.TabIndex = 0;
            this.Front_LSB_Option.TabStop = true;
            this.Front_LSB_Option.Text = "Front LSB";
            this.Front_LSB_Option.UseVisualStyleBackColor = true;
            this.Front_LSB_Option.CheckedChanged += new System.EventHandler(this.Front_LSB_Option_CheckedChanged);
            // 
            // Stego
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(503, 361);
            this.Controls.Add(this.Menu_Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Stego";
            this.Text = "Steganography";
            this.Menu_Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Post_Image_Holder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pre_Image_Holder)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hidden_Placeholder)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stegomedium_Picture_Holder)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl Menu_Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox Post_Image_Holder;
        private System.Windows.Forms.PictureBox Pre_Image_Holder;
        private System.Windows.Forms.Button Create_Image_Button;
        private System.Windows.Forms.Button Save_Location_Button;
        private System.Windows.Forms.Button Choose_File_Button;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Reveal_Carrier_File_Button;
        private System.Windows.Forms.Label File_Path_Label;
        private System.Windows.Forms.PictureBox Stegomedium_Picture_Holder;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton End_LSB_Option;
        private System.Windows.Forms.RadioButton Front_LSB_Option;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label Text_Box_Label;
        private System.Windows.Forms.RichTextBox Input_Textbox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox Hidden_Placeholder;
        private System.Windows.Forms.Button Choose_Hidden_Image_Button;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox Output_TextBox;
        private System.Windows.Forms.Button Reveal_Button;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel1;
    }
}

