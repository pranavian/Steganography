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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Item 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Item 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item 3",
            "sub item 1"}, -1);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Menu_Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Post_Image_Holder = new System.Windows.Forms.PictureBox();
            this.Pre_Image_Holder = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TextTab = new System.Windows.Forms.TabPage();
            this.Text_Box_Label = new System.Windows.Forms.Label();
            this.Input_Textbox = new System.Windows.Forms.RichTextBox();
            this.ImageTab = new System.Windows.Forms.TabPage();
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
            this.View_Large_Button = new System.Windows.Forms.Button();
            this.Reveal_Picture_Box = new System.Windows.Forms.PictureBox();
            this.Reveal_Image_Button = new System.Windows.Forms.Button();
            this.Stegomedium_Picture_Holder = new System.Windows.Forms.PictureBox();
            this.File_Path_Label = new System.Windows.Forms.Label();
            this.Reveal_Carrier_File_Button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Save_Key_Button = new System.Windows.Forms.Button();
            this.Key_Label = new System.Windows.Forms.Label();
            this.Encryption_Key_Textbox = new System.Windows.Forms.TextBox();
            this.None_Radio = new System.Windows.Forms.RadioButton();
            this.RSA_Radio = new System.Windows.Forms.RadioButton();
            this.RC2_Radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DES_Radio = new System.Windows.Forms.RadioButton();
            this.AES_Radio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.End_LSB_Option = new System.Windows.Forms.RadioButton();
            this.Front_LSB_Option = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Exif_Picture = new System.Windows.Forms.PictureBox();
            this.Exif_List = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Select_Exif_Image = new System.Windows.Forms.Button();
            this.Menu_Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Post_Image_Holder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pre_Image_Holder)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TextTab.SuspendLayout();
            this.ImageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hidden_Placeholder)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reveal_Picture_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stegomedium_Picture_Holder)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exif_Picture)).BeginInit();
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
            this.Menu_Tabs.Controls.Add(this.tabPage4);
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
            this.tabControl1.Controls.Add(this.TextTab);
            this.tabControl1.Controls.Add(this.ImageTab);
            this.tabControl1.Location = new System.Drawing.Point(7, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 227);
            this.tabControl1.TabIndex = 14;
            // 
            // TextTab
            // 
            this.TextTab.Controls.Add(this.Text_Box_Label);
            this.TextTab.Controls.Add(this.Input_Textbox);
            this.TextTab.Location = new System.Drawing.Point(4, 22);
            this.TextTab.Name = "TextTab";
            this.TextTab.Padding = new System.Windows.Forms.Padding(3);
            this.TextTab.Size = new System.Drawing.Size(192, 201);
            this.TextTab.TabIndex = 0;
            this.TextTab.Text = "Hide Text";
            this.TextTab.UseVisualStyleBackColor = true;
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
            // ImageTab
            // 
            this.ImageTab.Controls.Add(this.Hidden_Placeholder);
            this.ImageTab.Controls.Add(this.Choose_Hidden_Image_Button);
            this.ImageTab.Location = new System.Drawing.Point(4, 22);
            this.ImageTab.Name = "ImageTab";
            this.ImageTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImageTab.Size = new System.Drawing.Size(192, 201);
            this.ImageTab.TabIndex = 1;
            this.ImageTab.Text = "Hide Image";
            this.ImageTab.UseVisualStyleBackColor = true;
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
            this.tabPage7.Controls.Add(this.View_Large_Button);
            this.tabPage7.Controls.Add(this.Reveal_Picture_Box);
            this.tabPage7.Controls.Add(this.Reveal_Image_Button);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(478, 147);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Reveal Image";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // View_Large_Button
            // 
            this.View_Large_Button.Location = new System.Drawing.Point(385, 4);
            this.View_Large_Button.Name = "View_Large_Button";
            this.View_Large_Button.Size = new System.Drawing.Size(87, 23);
            this.View_Large_Button.TabIndex = 6;
            this.View_Large_Button.Text = "View Large";
            this.View_Large_Button.UseVisualStyleBackColor = true;
            this.View_Large_Button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Reveal_Picture_Box
            // 
            this.Reveal_Picture_Box.Location = new System.Drawing.Point(6, 32);
            this.Reveal_Picture_Box.Name = "Reveal_Picture_Box";
            this.Reveal_Picture_Box.Size = new System.Drawing.Size(466, 109);
            this.Reveal_Picture_Box.TabIndex = 5;
            this.Reveal_Picture_Box.TabStop = false;
            // 
            // Reveal_Image_Button
            // 
            this.Reveal_Image_Button.Enabled = false;
            this.Reveal_Image_Button.Location = new System.Drawing.Point(6, 3);
            this.Reveal_Image_Button.Name = "Reveal_Image_Button";
            this.Reveal_Image_Button.Size = new System.Drawing.Size(124, 23);
            this.Reveal_Image_Button.TabIndex = 4;
            this.Reveal_Image_Button.Text = "Reveal Image";
            this.Reveal_Image_Button.UseVisualStyleBackColor = true;
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
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(495, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Save_Key_Button);
            this.panel3.Controls.Add(this.Key_Label);
            this.panel3.Controls.Add(this.Encryption_Key_Textbox);
            this.panel3.Controls.Add(this.None_Radio);
            this.panel3.Controls.Add(this.RSA_Radio);
            this.panel3.Controls.Add(this.RC2_Radio);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.DES_Radio);
            this.panel3.Controls.Add(this.AES_Radio);
            this.panel3.Location = new System.Drawing.Point(11, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 98);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Save_Key_Button
            // 
            this.Save_Key_Button.Location = new System.Drawing.Point(377, 67);
            this.Save_Key_Button.Name = "Save_Key_Button";
            this.Save_Key_Button.Size = new System.Drawing.Size(97, 23);
            this.Save_Key_Button.TabIndex = 12;
            this.Save_Key_Button.Text = "Save Key";
            this.Save_Key_Button.UseVisualStyleBackColor = true;
            this.Save_Key_Button.Click += new System.EventHandler(this.Save_Key_Button_Click);
            // 
            // Key_Label
            // 
            this.Key_Label.AutoSize = true;
            this.Key_Label.Location = new System.Drawing.Point(4, 50);
            this.Key_Label.Name = "Key_Label";
            this.Key_Label.Size = new System.Drawing.Size(81, 13);
            this.Key_Label.TabIndex = 11;
            this.Key_Label.Text = "Encryption Key:";
            // 
            // Encryption_Key_Textbox
            // 
            this.Encryption_Key_Textbox.Enabled = false;
            this.Encryption_Key_Textbox.Location = new System.Drawing.Point(9, 69);
            this.Encryption_Key_Textbox.Name = "Encryption_Key_Textbox";
            this.Encryption_Key_Textbox.Size = new System.Drawing.Size(362, 20);
            this.Encryption_Key_Textbox.TabIndex = 10;
            // 
            // None_Radio
            // 
            this.None_Radio.AutoSize = true;
            this.None_Radio.Checked = true;
            this.None_Radio.Location = new System.Drawing.Point(10, 21);
            this.None_Radio.Name = "None_Radio";
            this.None_Radio.Size = new System.Drawing.Size(51, 17);
            this.None_Radio.TabIndex = 9;
            this.None_Radio.TabStop = true;
            this.None_Radio.Text = "None";
            this.None_Radio.UseVisualStyleBackColor = true;
            this.None_Radio.CheckedChanged += new System.EventHandler(this.None_Radio_CheckedChanged);
            // 
            // RSA_Radio
            // 
            this.RSA_Radio.AutoSize = true;
            this.RSA_Radio.Enabled = false;
            this.RSA_Radio.Location = new System.Drawing.Point(324, 20);
            this.RSA_Radio.Name = "RSA_Radio";
            this.RSA_Radio.Size = new System.Drawing.Size(47, 17);
            this.RSA_Radio.TabIndex = 8;
            this.RSA_Radio.Text = "RSA";
            this.RSA_Radio.UseVisualStyleBackColor = true;
            this.RSA_Radio.CheckedChanged += new System.EventHandler(this.RSA_Radio_CheckedChanged);
            // 
            // RC2_Radio
            // 
            this.RC2_Radio.AutoSize = true;
            this.RC2_Radio.Enabled = false;
            this.RC2_Radio.Location = new System.Drawing.Point(246, 21);
            this.RC2_Radio.Name = "RC2_Radio";
            this.RC2_Radio.Size = new System.Drawing.Size(46, 17);
            this.RC2_Radio.TabIndex = 7;
            this.RC2_Radio.Text = "RC2";
            this.RC2_Radio.UseVisualStyleBackColor = true;
            this.RC2_Radio.CheckedChanged += new System.EventHandler(this.RC2_Radio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encryption Algorithm:";
            // 
            // DES_Radio
            // 
            this.DES_Radio.AutoSize = true;
            this.DES_Radio.Enabled = false;
            this.DES_Radio.Location = new System.Drawing.Point(166, 20);
            this.DES_Radio.Name = "DES_Radio";
            this.DES_Radio.Size = new System.Drawing.Size(47, 17);
            this.DES_Radio.TabIndex = 5;
            this.DES_Radio.Text = "DES";
            this.DES_Radio.UseVisualStyleBackColor = true;
            this.DES_Radio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AES_Radio
            // 
            this.AES_Radio.AutoSize = true;
            this.AES_Radio.Location = new System.Drawing.Point(88, 21);
            this.AES_Radio.Name = "AES_Radio";
            this.AES_Radio.Size = new System.Drawing.Size(46, 17);
            this.AES_Radio.TabIndex = 4;
            this.AES_Radio.Text = "AES";
            this.AES_Radio.UseVisualStyleBackColor = true;
            this.AES_Radio.CheckedChanged += new System.EventHandler(this.AES_Radio_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.End_LSB_Option);
            this.panel2.Controls.Add(this.Front_LSB_Option);
            this.panel2.Location = new System.Drawing.Point(11, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 49);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Steganography Algorithm:";
            // 
            // End_LSB_Option
            // 
            this.End_LSB_Option.AutoSize = true;
            this.End_LSB_Option.Location = new System.Drawing.Point(90, 23);
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
            this.Front_LSB_Option.Location = new System.Drawing.Point(12, 24);
            this.Front_LSB_Option.Name = "Front_LSB_Option";
            this.Front_LSB_Option.Size = new System.Drawing.Size(72, 17);
            this.Front_LSB_Option.TabIndex = 0;
            this.Front_LSB_Option.TabStop = true;
            this.Front_LSB_Option.Text = "Front LSB";
            this.Front_LSB_Option.UseVisualStyleBackColor = true;
            this.Front_LSB_Option.CheckedChanged += new System.EventHandler(this.Front_LSB_Option_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Exif_Picture);
            this.tabPage4.Controls.Add(this.Exif_List);
            this.tabPage4.Controls.Add(this.Select_Exif_Image);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(495, 333);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "EXIF Viewer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Exif_Picture
            // 
            this.Exif_Picture.Location = new System.Drawing.Point(8, 37);
            this.Exif_Picture.Name = "Exif_Picture";
            this.Exif_Picture.Size = new System.Drawing.Size(236, 288);
            this.Exif_Picture.TabIndex = 2;
            this.Exif_Picture.TabStop = false;
            // 
            // Exif_List
            // 
            this.Exif_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewItem3.Tag = "";
            this.Exif_List.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.Exif_List.Location = new System.Drawing.Point(253, 7);
            this.Exif_List.Name = "Exif_List";
            this.Exif_List.Size = new System.Drawing.Size(233, 318);
            this.Exif_List.TabIndex = 1;
            this.Exif_List.UseCompatibleStateImageBehavior = false;
            this.Exif_List.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Exif Type";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Exif Value";
            this.columnHeader2.Width = 130;
            // 
            // Select_Exif_Image
            // 
            this.Select_Exif_Image.Location = new System.Drawing.Point(8, 7);
            this.Select_Exif_Image.Name = "Select_Exif_Image";
            this.Select_Exif_Image.Size = new System.Drawing.Size(236, 23);
            this.Select_Exif_Image.TabIndex = 0;
            this.Select_Exif_Image.Text = "Select Image";
            this.Select_Exif_Image.UseVisualStyleBackColor = true;
            this.Select_Exif_Image.Click += new System.EventHandler(this.Select_Exif_Image_Click);
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
            this.TextTab.ResumeLayout(false);
            this.TextTab.PerformLayout();
            this.ImageTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hidden_Placeholder)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Reveal_Picture_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stegomedium_Picture_Holder)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exif_Picture)).EndInit();
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
        private System.Windows.Forms.TabPage TextTab;
        private System.Windows.Forms.Label Text_Box_Label;
        private System.Windows.Forms.RichTextBox Input_Textbox;
        private System.Windows.Forms.TabPage ImageTab;
        private System.Windows.Forms.PictureBox Hidden_Placeholder;
        private System.Windows.Forms.Button Choose_Hidden_Image_Button;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox Output_TextBox;
        private System.Windows.Forms.Button Reveal_Button;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button View_Large_Button;
        private System.Windows.Forms.PictureBox Reveal_Picture_Box;
        private System.Windows.Forms.Button Reveal_Image_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton DES_Radio;
        private System.Windows.Forms.RadioButton AES_Radio;
        private System.Windows.Forms.RadioButton RSA_Radio;
        private System.Windows.Forms.RadioButton RC2_Radio;
        private System.Windows.Forms.RadioButton None_Radio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Key_Label;
        private System.Windows.Forms.TextBox Encryption_Key_Textbox;
        private System.Windows.Forms.Button Save_Key_Button;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView Exif_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Select_Exif_Image;
        private System.Windows.Forms.PictureBox Exif_Picture;
    }
}

