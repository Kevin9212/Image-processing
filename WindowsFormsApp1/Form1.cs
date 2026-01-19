using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public struct ImageOptions
        {
            public double rotateAngle;
            public int ReflectX;
            public int ReflectY;
            public int Thresholding;
            public int GrayScale;
            public double ShearX;
            public double ShearY;
            public int PepperNoisePercent;
            public int k_size;
            public int Histogram;
            public int CannyLow;
            public int CannyHigh;
        };
        [DllImport("imgFunc.dll", CallingConvention = CallingConvention.Cdecl,
                            CharSet = CharSet.Ansi)]
        static extern void showImage(string filename,ref ImageOptions options);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = ofDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRotate.Text))
            {
                textBoxRotate.Text = 0.ToString();
            }
            if (string.IsNullOrEmpty(textBoxShearX.Text))
            {
                textBoxShearX.Text = 0.ToString();  
            }
            if (string.IsNullOrEmpty(textBoxShearY.Text))
            {
                textBoxShearY.Text = 0.ToString();
            }
            if (string.IsNullOrEmpty(textBoxPepperNoisePercent.Text))
            {
                textBoxPepperNoisePercent.Text = 0.ToString();
            }
            if (string.IsNullOrEmpty(comboBoxK_size.SelectedItem?.ToString()))
            {
                comboBoxK_size.SelectedIndex = 0;
            }
            if ( string.IsNullOrEmpty(textBoxCannyHigh.Text) || int.Parse(textBoxCannyLow.Text) > int.Parse(textBoxCannyHigh.Text))
            {
                textBoxCannyLow.Text = 0.ToString();
                textBoxCannyHigh.Text = 0.ToString();
            }
            ImageOptions options = new ImageOptions
            {
                rotateAngle = int.Parse(textBoxRotate.Text),
                ReflectY = checkBoxReflectY.Checked ? 1 : 0,
                ReflectX = checkBoxReflectX.Checked ? 1 : 0,
                Thresholding = checkBoxThresholding.Checked ? 1 : 0,
                GrayScale = checkBoxGrayScale.Checked ? 1 : 0,
                ShearX = double.Parse(textBoxShearX.Text),
                ShearY = double.Parse(textBoxShearY.Text),
                PepperNoisePercent = int.Parse(textBoxPepperNoisePercent.Text),
                k_size = int.Parse(comboBoxK_size.SelectedItem.ToString()),
                Histogram = checkBoxHistogram.Checked ? 1 : 0,
                CannyLow = int.Parse(textBoxCannyLow.Text),
                CannyHigh = int.Parse(textBoxCannyHigh.Text),
            };
            showImage(tbFileName.Text,ref options);
        }

        

        private void checkBoxReflectX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxThresholding_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
