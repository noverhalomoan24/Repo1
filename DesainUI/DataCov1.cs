using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DesainUI
{
    public partial class DataCov1 : UserControl
    {
        OpenFileDialog opd = new OpenFileDialog();
        
        public DataCov1()
        {
            InitializeComponent();
            label_urldata.Visible = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            label_urldata.Visible = true;
            opd.Title = "Open File CSV";
            opd.Filter = "CSV Files (*.csv)|*.csv";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                var reader = new StreamReader(opd.FileName);
                label_urldata.Text = "\""+opd.FileName.ToString()+"\"";
                data(opd.FileName.ToString());
            }
        }
        private void data(string path)
        {
            DataTable dt = new DataTable();

            string[] lines = System.IO.File.ReadAllLines(path);

            if(lines.Length>0)
            {
                string firstLine = lines[0];
                string[] headerlabel = firstLine.Split(',');
                foreach(string headerword in headerlabel)
                {
                    dt.Columns.Add(new DataColumn(headerword));
                }

                for(int r=1;r<lines.Length;r++)
                {
                    string[] dataword = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columns = 0;
                    foreach(string headerword in headerlabel)
                    {
                        
                        dr[headerword] = dataword[columns];
                        columns += 1;
                    }
                    dt.Rows.Add(dr);
                }
            }
            if(dt.Rows.Count>0)
            {
                dgv_tampil.DataSource = dt;
            }
        }
    }
}
