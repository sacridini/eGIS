using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace espaçoGIS
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources._066;
        }

        private void proximo_btn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._066;
        }
    }
}
