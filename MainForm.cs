using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Steganography
{
    
    public partial class MainForm : Form
    
    {
       
        public void SplashStart()
        {
            Application.Run(new SplashScreen());        
        }
        #region Fields
        private readonly Encrypt_importer _importer;
        private readonly Decrypt_exporter _exporter;
        #endregion

        #region Properties

        public Bitmap Bmp;
        public Stopwatch Sw;
        public int ImageWidth, ImageHeight;

        public ProgressBar ImpProgressBar
        {
            get { return ImportProgressBar; }
        }
        public int ImportProgressBarValue
        {
            set { ImportProgressBar.Value = value; }
        }
        public int ImportProgressBarMaximum
        {
            set { ImportProgressBar.Maximum = value; }
        }

        public ProgressBar ExpProgressBar
        {
            get { return ExportProgressBar; }
        }
        public int ExportProgressBarValue
        {
            set { ExportProgressBar.Value = value; }
        }
        public int ExportProgressBarMaximum
        {
            set { ExportProgressBar.Maximum = value; }
        }

        public Image ImportPictureBoxImage
        {
            get { return ImportPictureBox.Image; }
            set { ImportPictureBox.Image = value; }
        }
        public Image DecryptPictureBoxImage
        {
            get { return ExportPictureBox.Image; }
            set { ExportPictureBox.Image = value; }
        }

        public string ImportTextBoxText
        {
            get { return EncryptTextBox.Text; }
            set { EncryptTextBox.Text = value; }
        }
        public string ImportWidthLabelText
        {
            get { return ImportWidthLabel.Text; }
            set { ImportWidthLabel.Text = value; }
        }
        public string ImportHeightLabelText
        {
            get { return ImportHeightLabel.Text; }
            set { ImportHeightLabel.Text = value; }
        }
        public string ImportFormatLabelText
        {
            get { return ImportFormatLabel.Text; }
            set { ImportFormatLabel.Text = value; }
        }
        public string ImportPixelsLabelText
        {
            get { return ImportPixelsLabel.Text; }
            set { ImportPixelsLabel.Text = value; }
        }
        public string ImportMaxLengthLabelText
        {
            get { return ImportMaxLengthLabel.Text; }
            set { ImportMaxLengthLabel.Text = value; }
        }
        public string ImportedTextLengtLabelText
        {
            get { return ImportedTextLengtLabel.Text; }
            set { ImportedTextLengtLabel.Text = value; }
        }
        public string ImportDurationLabelText
        {
            get { return ImportDurationLabel.Text; }
            set { ImportDurationLabel.Text = value; }
        }

        public string ExportTextBoxText
        {
            get { return ExportTextBox.Text; }
            set { ExportTextBox.Text = value; }
        }
        public string ExportWidthLabelText
        {
            get { return ExportWidthLabel.Text; }
            set { ExportWidthLabel.Text = value; }
        }
        public string ExportHeightLabelText
        {
            get { return ExportHeightLabel.Text; }
            set { ExportHeightLabel.Text = value; }
        }
        public string ExportFormatLabelText
        {
            get { return ExportFormatLabel.Text; }
            set { ExportFormatLabel.Text = value; }
        }
        public string ExportPixelsLabelText
        {
            get { return ExportPixelsLabel.Text; }
            set { ExportPixelsLabel.Text = value; }
        }
        public string ExportMaxLengthLabelText
        {
            get { return ExportMaxLengthLabel.Text; }
            set { ExportMaxLengthLabel.Text = value; }
        }
        public string ExportedTextLengtLabelText
        {
            get { return ExportedTextLengtLabel.Text; }
            set { ExportedTextLengtLabel.Text = value; }
        }
        public string ExportDurationLabelText
        {
            get { return ExportDurationLabel.Text; }
            set { ExportDurationLabel.Text = value; }
        }

        public bool ImportTickPictureBoxVisible
        {
            set { ImportTickPictureBox.Visible = value; }
        }
        public bool ExportTickPictureBoxVisible
        {
            set { ExportTickPictureBox.Visible = value; }
        }
        #endregion

        #region Ctor

        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            _exporter = new Decrypt_exporter(this);
            _importer = new Encrypt_importer(this);
        }

        #endregion

        #region Button Click Events
        private void OpenFileEncryptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = CommonConstants.OpenFileFilter;
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportPictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
                Bmp = new Bitmap(ImportPictureBox.Image);
                _importer.SetEncryptedImageInfo();
            }
        }
        private void OpenFileDecryptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = CommonConstants.OpenFileFilter;
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportPictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
                _exporter.SetExportedImageInfo();
            }
        }
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (EncryptTextBox.TextLength > 0)
            {
                _importer.import();
            }
            else
            {
                MessageBox.Show("Enter text before!", CommonConstants.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (ExportWidthLabel.Text != "-")
            {
                _exporter.export();
            }
            else
            {
                MessageBox.Show("Open an image file before!", CommonConstants.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void ExportPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = CommonConstants.SaveDialogFilter;
            saveFileDialog.Title = CommonConstants.SaveDialogTitle;
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != string.Empty)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        Bmp.Save(saveFileDialog.FileName);
                        break;
                    case 2:
                        Bmp.Save(saveFileDialog.FileName);
                        break;
                    case 3:
                        System.IO.FileStream fs2 = (System.IO.FileStream)saveFileDialog.OpenFile();
                        Bmp.Save(fs2, System.Drawing.Imaging.ImageFormat.Bmp);
                        fs2.Close();
                        break;
                }
            }
        }
        #endregion

        private void ImportProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImportTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {

        }

        private void EnFileBrowse_btn_Click(object sender, EventArgs e)
        {

        }

        private void EnImageBrowse_btn_Click(object sender, EventArgs e)
        {

        }

        private void EnFile_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt_File_btn_Click(object sender, EventArgs e)
        {
            form3 open = new form3();
            open.Show();
        }
    }
}