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
    public partial class CREATE_SLIP : Form
    {
        sqlconnection con = new sqlconnection();

        public CREATE_SLIP()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nopeg = txtNo_Pegawai.Text;
                string query = "select * from pegawai where no_pegawai = '" + nopeg + "'";
                DataTable dtpeg = con.openTable(query);

                string nomor = dtpeg.Rows[0]["No_Pegawai"].ToString();
                string nmpeg = dtpeg.Rows[0]["Nm_Pegawai"].ToString();
                string tglmsk = dtpeg.Rows[0]["Tgl_Masuk"].ToString();
                string jkelamin = dtpeg.Rows[0]["Jenis_kelamin"].ToString();
                string stat = dtpeg.Rows[0]["Status"].ToString();
                int gp = Convert.ToInt32(dtpeg.Rows[0]["Gaji_Pokok"].ToString());
                int makan = Convert.ToInt32(dtpeg.Rows[0]["Uang_Makan"].ToString());
                int transport = Convert.ToInt32(dtpeg.Rows[0]["Uang_Transport"].ToString());
                int lembur = Convert.ToInt32(dtpeg.Rows[0]["Uang_lembur"].ToString());
                int niltunj = Convert.ToInt32(dtpeg.Rows[0]["Nilai_Tunjangan"].ToString());

                int totalgaji = gp + makan + transport + lembur + niltunj;


                txtNopeg.Text = nomor.ToString();
                txtNm_pegawai.Text = nmpeg.ToString();
                txtTgl_Masuk.Text = tglmsk.ToString();
                txtJenis_Kelamin.Text = jkelamin.ToString();
                txtStatus.Text = stat.ToString();
                txtGajiPokok.Text = gp.ToString();
                txtUang_Makan.Text = makan.ToString();
                txtTransport.Text = transport.ToString();
                txtLembur.Text = lembur.ToString();
                txtTunjangan.Text = niltunj.ToString();
                txttotalgaji.Text = totalgaji.ToString();


                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code " + ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNo_Pegawai.Clear();
            txtNopeg.Clear();
            txtNm_pegawai.Clear();
            txtTgl_Masuk.Clear();
            txtJenis_Kelamin.Clear();
            txtStatus.Clear();
            txtGajiPokok.Clear();
            txtUang_Makan.Clear();
            txtTransport.Clear();
            txtLembur.Clear();
            txtTunjangan.Clear();
            txttotalgaji.Clear();

            button2.Enabled = false;
        }
    }
}
