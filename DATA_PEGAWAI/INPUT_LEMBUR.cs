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
    public partial class INPUT_LEMBUR : Form
    {
        string lokasi = "";
        double hasillembur;
        sqlconnection con = new sqlconnection();
        public INPUT_LEMBUR()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             lokasi = "";
            OpenFileDialog dOpen = new OpenFileDialog();
            dOpen.Filter = "Excel File (*.xls *.xlsx)|*.xls;*.xlsx;";
            dOpen.InitialDirectory = @"C:\";
            if (dOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lokasi = dOpen.FileName;
                textBox1.Text = lokasi;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nmfile = textBox1.Text;
                string tanggal_lembur = dateTimePicker1.Value.ToString("ddMMyyyy");
                string no_peg = textBox1.Text;

                string checknopeg = "select no_pegawai from pegawai where no_pegawai = '" + no_peg + "'";
                DataTable checkno = con.openTable(checknopeg);
                if (checkno.Rows.Count == 0)
                {
                    MessageBox.Show("Nomor pegawai tidak ada atau salah");
                    return;
                }
                string jml_lembur = txtJml_Lembur.Text;

                




                if (nmfile == "" || tanggal_lembur == "" || no_peg == "" || jml_lembur == "")
                {
                    MessageBox.Show("Masih ada data yang belum di isi, Mohon di lengkapi");
                    return;
                }

                string qry = "insert into lembur ([dokumen_lembur],[tanggal],[no_pegawai],[jml_lembur]) values ('" + nmfile + "','" + tanggal_lembur + "','" + no_peg +"','" + jml_lembur +"')";
                con.executeQuery(qry);

                //UPDATE UANG LEMBUR KE TABEL PEGAWAI
                int hitunglembur = Convert.ToInt32(jml_lembur);
                
                string kueri = "select * from pegawai where no_pegawai = '" + no_peg + "'";
                DataTable dtpeg = con.openTable(kueri);
                string sgapok = dtpeg.Rows[0]["Gaji_Pokok"].ToString();
                int gapok = Convert.ToInt32(sgapok);
                string smakan = dtpeg.Rows[0]["Uang_Makan"].ToString();
                int makan = Convert.ToInt32(smakan);
                string stransport = dtpeg.Rows[0]["Uang_Transport"].ToString();
                int transport = Convert.ToInt32(stransport);
                

                for (int a = 1; a <= hitunglembur; a++)
                {
                    if (a == 1)
                    {
                        hasillembur = (gapok + makan + transport) / 173 * 1.5;
                    }
                    else
                    {
                        hasillembur = (gapok + makan + transport) / 173 * 2;
                    }
                }

                string qryupd = "update pegawai set Uang_Lembur = '" + hasillembur + "' where no_pegawai = '" + no_peg + "'";
                con.executeQuery(qryupd);

                MessageBox.Show("Data Lembur Berhasil di Input");

                txtJml_Lembur.Clear();
                txtNo_Pegawai.Clear();
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code : " + ex.ToString());
            }
        }
    }
}
