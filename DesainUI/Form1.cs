using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesainUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelutama.Visible = false;

        }

        public Panel PnlContiner
        {
            get { return panelHalaman; }
            set { panelHalaman = value; }
        }

        private void btn_MenuUtama_Click(object sender, EventArgs e)
        {
            panelutama.Visible = true;
            panelPembuka.Visible = false;
            panelDeskripsi.Visible = false;
            btn_MenuUtama.Width = 135;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelPembuka.Visible = true;
            panelDeskripsi.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelPembuka.Visible = false;
            panelDeskripsi.Visible = true;
        }

        private void covid_halaman_Click(object sender, EventArgs e)
        {
            DataCov1 dc = new DataCov1();
            panelHalaman.Controls.Add(dc);
        }
    }
}
