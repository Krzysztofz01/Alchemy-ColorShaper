using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alchemy_ColorShaper2
{
    public partial class mainWindow : Form
    {
        private string selectedImageLocation = "";
        public mainWindow()
        {
            InitializeComponent();

            txtThreshold.Text = "Threshold - " + tbThreshold.Value.ToString();
            txtResolution.Text = "Resolution - " + tbResolution.Value.ToString();
            txtCompression.Text = "Compression - " + tbCompression.Value.ToString();
            txtAccuracy.Text = "Accuracy - " + tbAccuracy.Value.ToString();
        }

        private void BtnImportImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImageLocation = ofd.FileName;
                btnStartProcessing.Enabled = true;
            }
        }

        private void BtnStartProcessing_Click(object sender, EventArgs e)
        {
            //async
             Processing.legacy(
                new Bitmap(selectedImageLocation),
                Output.outputColors,
                tbThreshold.Value,
                tbResolution.Value,
                tbCompression.Value,
                tbAccuracy.Value);

            this.Hide();
            var ow = new outputWindow(selectedImageLocation);
            ow.ShowDialog();
            this.Close();
        }

        private void TbThreshold_Scroll(object sender, EventArgs e)
        {
            txtThreshold.Text = "Threshold - " + tbThreshold.Value.ToString();
        }

        private void TbResolution_Scroll(object sender, EventArgs e)
        {
            txtResolution.Text = "Resolution - " + tbResolution.Value.ToString();
        }

        private void TbCompression_Scroll(object sender, EventArgs e)
        {
            txtCompression.Text = "Compression - " + tbCompression.Value.ToString();
        }

        private void TbAccuracy_Scroll(object sender, EventArgs e)
        {
            txtAccuracy.Text = "Accuracy - " + tbAccuracy.Value.ToString();
        }
    }
}
