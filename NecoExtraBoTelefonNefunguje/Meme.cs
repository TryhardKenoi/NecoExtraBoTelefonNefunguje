using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NecoExtraBoTelefonNefunguje
{
    public partial class Meme : Form
    {
        public Meme()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    pictureBox1.ImageLocation = selectedFilePath;
                    Console.WriteLine(selectedFilePath);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
