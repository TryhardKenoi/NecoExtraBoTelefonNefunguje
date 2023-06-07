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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Meme meme = new Meme();
            meme.Show();
            this.Hide();
        }
    }
}
