namespace Steganography
{
    partial class form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EncryptTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CanSave_lbl = new System.Windows.Forms.Label();
            this.ImageWidth_lbl = new System.Windows.Forms.Label();
            this.ImageSize_lbl = new System.Windows.Forms.Label();
            this.ImageHeight_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.En_fileBrowse_btn = new System.Windows.Forms.Button();
            this.En_imageBrowse_btn = new System.Windows.Forms.Button();
            this.En_fileBrowse_txtbox = new System.Windows.Forms.TextBox();
            this.En_Image_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DecryptTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.DeSaveFileBrowse_btn = new System.Windows.Forms.Button();
            this.DeLoadImageBrowse_btn = new System.Windows.Forms.Button();
            this.DeSaveFile_tbx = new System.Windows.Forms.TextBox();
            this.DeLoadImage_tbx = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Close_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.EncryptTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DecryptTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.toolStripStatusLabel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EncryptTabPage);
            this.tabControl1.Controls.Add(this.DecryptTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 20);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 194);
            this.tabControl1.TabIndex = 0;
            // 
            // EncryptTabPage
            // 
            this.EncryptTabPage.BackColor = System.Drawing.Color.Linen;
            this.EncryptTabPage.Controls.Add(this.groupBox2);
            this.EncryptTabPage.Controls.Add(this.groupBox1);
            this.EncryptTabPage.Location = new System.Drawing.Point(4, 24);
            this.EncryptTabPage.Name = "EncryptTabPage";
            this.EncryptTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EncryptTabPage.Size = new System.Drawing.Size(744, 166);
            this.EncryptTabPage.TabIndex = 0;
            this.EncryptTabPage.Text = "Encrypt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CanSave_lbl);
            this.groupBox2.Controls.Add(this.ImageWidth_lbl);
            this.groupBox2.Controls.Add(this.ImageSize_lbl);
            this.groupBox2.Controls.Add(this.ImageHeight_lbl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(517, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Info:";
            // 
            // CanSave_lbl
            // 
            this.CanSave_lbl.AutoSize = true;
            this.CanSave_lbl.Location = new System.Drawing.Point(95, 98);
            this.CanSave_lbl.Name = "CanSave_lbl";
            this.CanSave_lbl.Size = new System.Drawing.Size(31, 13);
            this.CanSave_lbl.TabIndex = 8;
            this.CanSave_lbl.Text = "none";
            // 
            // ImageWidth_lbl
            // 
            this.ImageWidth_lbl.AutoSize = true;
            this.ImageWidth_lbl.Location = new System.Drawing.Point(95, 80);
            this.ImageWidth_lbl.Name = "ImageWidth_lbl";
            this.ImageWidth_lbl.Size = new System.Drawing.Size(31, 13);
            this.ImageWidth_lbl.TabIndex = 7;
            this.ImageWidth_lbl.Text = "none";
            // 
            // ImageSize_lbl
            // 
            this.ImageSize_lbl.AutoSize = true;
            this.ImageSize_lbl.Location = new System.Drawing.Point(95, 26);
            this.ImageSize_lbl.Name = "ImageSize_lbl";
            this.ImageSize_lbl.Size = new System.Drawing.Size(31, 13);
            this.ImageSize_lbl.TabIndex = 6;
            this.ImageSize_lbl.Text = "none";
            // 
            // ImageHeight_lbl
            // 
            this.ImageHeight_lbl.AutoSize = true;
            this.ImageHeight_lbl.Location = new System.Drawing.Point(95, 56);
            this.ImageHeight_lbl.Name = "ImageHeight_lbl";
            this.ImageHeight_lbl.Size = new System.Drawing.Size(31, 13);
            this.ImageHeight_lbl.TabIndex = 5;
            this.ImageHeight_lbl.Text = "none";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Canvas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Width :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Height :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Size :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Encrypt_btn);
            this.groupBox1.Controls.Add(this.En_fileBrowse_btn);
            this.groupBox1.Controls.Add(this.En_imageBrowse_btn);
            this.groupBox1.Controls.Add(this.En_fileBrowse_txtbox);
            this.groupBox1.Controls.Add(this.En_Image_txtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt_btn.Location = new System.Drawing.Point(163, 93);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.Encrypt_btn.TabIndex = 6;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // En_fileBrowse_btn
            // 
            this.En_fileBrowse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.En_fileBrowse_btn.Location = new System.Drawing.Point(317, 58);
            this.En_fileBrowse_btn.Name = "En_fileBrowse_btn";
            this.En_fileBrowse_btn.Size = new System.Drawing.Size(75, 23);
            this.En_fileBrowse_btn.TabIndex = 5;
            this.En_fileBrowse_btn.Text = "Browse";
            this.En_fileBrowse_btn.UseVisualStyleBackColor = true;
            this.En_fileBrowse_btn.Click += new System.EventHandler(this.En_fileBrowse_btn_Click);
            // 
            // En_imageBrowse_btn
            // 
            this.En_imageBrowse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.En_imageBrowse_btn.Image = global::Steganography.Properties.Resources.picture__plus;
            this.En_imageBrowse_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.En_imageBrowse_btn.Location = new System.Drawing.Point(317, 23);
            this.En_imageBrowse_btn.Name = "En_imageBrowse_btn";
            this.En_imageBrowse_btn.Size = new System.Drawing.Size(75, 23);
            this.En_imageBrowse_btn.TabIndex = 4;
            this.En_imageBrowse_btn.Text = "  Browse";
            this.En_imageBrowse_btn.UseVisualStyleBackColor = true;
            this.En_imageBrowse_btn.Click += new System.EventHandler(this.En_imageBrowse_btn_Click);
            // 
            // En_fileBrowse_txtbox
            // 
            this.En_fileBrowse_txtbox.Location = new System.Drawing.Point(94, 56);
            this.En_fileBrowse_txtbox.Name = "En_fileBrowse_txtbox";
            this.En_fileBrowse_txtbox.Size = new System.Drawing.Size(195, 20);
            this.En_fileBrowse_txtbox.TabIndex = 3;
            // 
            // En_Image_txtbox
            // 
            this.En_Image_txtbox.Location = new System.Drawing.Point(94, 23);
            this.En_Image_txtbox.Name = "En_Image_txtbox";
            this.En_Image_txtbox.Size = new System.Drawing.Size(195, 20);
            this.En_Image_txtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Load File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load Image";
            // 
            // DecryptTabPage
            // 
            this.DecryptTabPage.BackColor = System.Drawing.Color.Linen;
            this.DecryptTabPage.Controls.Add(this.groupBox3);
            this.DecryptTabPage.Controls.Add(this.groupBox4);
            this.DecryptTabPage.Location = new System.Drawing.Point(4, 24);
            this.DecryptTabPage.Name = "DecryptTabPage";
            this.DecryptTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DecryptTabPage.Size = new System.Drawing.Size(744, 166);
            this.DecryptTabPage.TabIndex = 1;
            this.DecryptTabPage.Text = "Decrypt";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(524, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 136);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Info:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "none";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "none";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(95, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "none";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "none";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Canvas :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Width :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Height :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Size :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Decrypt_btn);
            this.groupBox4.Controls.Add(this.DeSaveFileBrowse_btn);
            this.groupBox4.Controls.Add(this.DeLoadImageBrowse_btn);
            this.groupBox4.Controls.Add(this.DeSaveFile_tbx);
            this.groupBox4.Controls.Add(this.DeLoadImage_tbx);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Location = new System.Drawing.Point(22, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 136);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt_btn.Location = new System.Drawing.Point(163, 93);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.Decrypt_btn.TabIndex = 6;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // DeSaveFileBrowse_btn
            // 
            this.DeSaveFileBrowse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeSaveFileBrowse_btn.Location = new System.Drawing.Point(317, 58);
            this.DeSaveFileBrowse_btn.Name = "DeSaveFileBrowse_btn";
            this.DeSaveFileBrowse_btn.Size = new System.Drawing.Size(75, 23);
            this.DeSaveFileBrowse_btn.TabIndex = 5;
            this.DeSaveFileBrowse_btn.Text = "Browse";
            this.DeSaveFileBrowse_btn.UseVisualStyleBackColor = true;
            this.DeSaveFileBrowse_btn.Click += new System.EventHandler(this.DeSaveFileBrowse_btn_Click);
            // 
            // DeLoadImageBrowse_btn
            // 
            this.DeLoadImageBrowse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeLoadImageBrowse_btn.Image = global::Steganography.Properties.Resources.picture__plus;
            this.DeLoadImageBrowse_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DeLoadImageBrowse_btn.Location = new System.Drawing.Point(317, 21);
            this.DeLoadImageBrowse_btn.Name = "DeLoadImageBrowse_btn";
            this.DeLoadImageBrowse_btn.Size = new System.Drawing.Size(75, 23);
            this.DeLoadImageBrowse_btn.TabIndex = 4;
            this.DeLoadImageBrowse_btn.Text = "  Browse";
            this.DeLoadImageBrowse_btn.UseVisualStyleBackColor = true;
            this.DeLoadImageBrowse_btn.Click += new System.EventHandler(this.DeLoadImageBrowse_btn_Click);
            // 
            // DeSaveFile_tbx
            // 
            this.DeSaveFile_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeSaveFile_tbx.Location = new System.Drawing.Point(94, 56);
            this.DeSaveFile_tbx.Name = "DeSaveFile_tbx";
            this.DeSaveFile_tbx.Size = new System.Drawing.Size(195, 20);
            this.DeSaveFile_tbx.TabIndex = 3;
            // 
            // DeLoadImage_tbx
            // 
            this.DeLoadImage_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeLoadImage_tbx.Location = new System.Drawing.Point(94, 23);
            this.DeLoadImage_tbx.Name = "DeLoadImage_tbx";
            this.DeLoadImage_tbx.Size = new System.Drawing.Size(195, 20);
            this.DeLoadImage_tbx.TabIndex = 2;
            this.DeLoadImage_tbx.Text = " load encrypted image";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Save File To :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(19, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Load Image :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Image Preview";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp|All files(*.*)|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "Bitmap Files (*.bmp)|*.bmp|All files(*.*)|*.*";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripStatusLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripStatusLabel1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(0, 546);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(765, 25);
            this.toolStripStatusLabel1.TabIndex = 3;
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Ready";
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(665, 511);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(75, 23);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(765, 571);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.toolStripStatusLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr.STEGANORK";
            this.tabControl1.ResumeLayout(false);
            this.EncryptTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DecryptTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStripStatusLabel1.ResumeLayout(false);
            this.toolStripStatusLabel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EncryptTabPage;
        private System.Windows.Forms.TabPage DecryptTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox En_fileBrowse_txtbox;
        private System.Windows.Forms.TextBox En_Image_txtbox;
        private System.Windows.Forms.Button En_fileBrowse_btn;
        private System.Windows.Forms.Button En_imageBrowse_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Encrypt_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CanSave_lbl;
        private System.Windows.Forms.Label ImageWidth_lbl;
        private System.Windows.Forms.Label ImageSize_lbl;
        private System.Windows.Forms.Label ImageHeight_lbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Decrypt_btn;
        private System.Windows.Forms.Button DeSaveFileBrowse_btn;
        private System.Windows.Forms.Button DeLoadImageBrowse_btn;
        private System.Windows.Forms.TextBox DeSaveFile_tbx;
        private System.Windows.Forms.TextBox DeLoadImage_tbx;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStrip toolStripStatusLabel1;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}