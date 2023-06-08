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
    public partial class Choose : Form
    {
        public int obrazek;
        public Choose()
        {
            InitializeComponent();
        }

        private void Choose_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Index i = new Index();
            i.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je mi líto, ale na této funkci zatím pracuju. :)");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je mi líto, ale na této funkci zatím pracuju. :)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je mi líto, ale na této funkci zatím pracuju. :)");
        }
    }
}
