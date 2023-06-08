using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace NecoExtraBoTelefonNefunguje
{
    public partial class Custom : Form
    {
        OpenFileDialog openImageFile;

        public Custom()
        {
            InitializeComponent();
            SetUpApp();
        }

        private void SetUpApp()
        {
            pictureBox1.Controls.Add(textBottom);
            pictureBox1.Controls.Add(textTop);

            textBottom.Location = new Point(0, 0);
            textTop.Location = new Point(0, 350);

            pictureBox1.SendToBack();
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
                    try
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        pictureBox1.ImageLocation = selectedFilePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Obrázek nelze nahrát" + ex.Message);
                    }

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ChangeTextTop(object sender, EventArgs e)
        {
            textTop.Text = textBox1.Text;
        }

        private void ChangeTextBottom(object sender, EventArgs e)
        {
            textBottom.Text = textBox2.Text;
        }

        private void ChangeTextColour(object sender, EventArgs e)
        {
            Button barvy = sender as Button;

            textTop.ForeColor = barvy.BackColor;
            textBottom.ForeColor = barvy.BackColor;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "brambor";
            saveFileDialog.DefaultExt = ".jpg";
            saveFileDialog.Filter = "JPG Image | *.jpg";
            saveFileDialog.ValidateNames = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int sirka = Convert.ToInt32(pictureBox1.Width);
                int vyska = Convert.ToInt32(pictureBox1.Height);
                Bitmap bitmap = new Bitmap(sirka, vyska);
                pictureBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, sirka, vyska));
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void Meme_Load(object sender, EventArgs e)
        {

        }
    }
}
