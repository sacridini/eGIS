using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace espaçoGIS
{
    public partial class espacoGIS : Form
    {

        public espacoGIS()
        {
            // Splash Screen
            //Thread threadSplashScreen = new Thread(new ThreadStart(SplashScreen));
            //threadSplashScreen.Start();
            //Thread.Sleep(4000);
            InitializeComponent();
            //threadSplashScreen.Abort();
        }

        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void espacoGIS_Load(object sender, EventArgs e)
        {
             
        }

        public void LoadForm(Form frm)
        {
            // Método de criação de novas Forms
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.BringToFront();
            frm.Show();
        }

        private void carregarGIS_btn_Click(object sender, EventArgs e)
        {
            // Carrega página
            LoadForm(new espaço());
        }

        private void PostGisFunctions_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new ConexaoDB());
        }

        private void sTAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new stArea());
        }

        private void sqlQuery_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new sqlQuery());
        }

        private void tutorial_btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Tutorial());
        }

        private void sToolBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new atmcorr());
        }
    }
}
