using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATA_PEGAWAI
{
    public partial class REPORT : Form
    {
        sqlconnection con = new sqlconnection();
        public REPORT()
        {
            InitializeComponent();
        }

        private void REPORT_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * from Pegawai";
                DataTable dtpegawai = con.openTable(qry);

                DataView dvtabel = new DataView();
                dvtabel = dtpegawai.DefaultView;
                this.dataGridView1.Visible = true;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dvtabel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code : " + ex.ToString());
            }
        }
        Bitmap bmp;
        private void button2_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
