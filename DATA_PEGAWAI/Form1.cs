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
    public partial class Form1 : Form
    {
        sqlconnection con = new sqlconnection();
        int nilai_tunjangan;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable Status = con.openTable("select Jenis_Status,Deskripsi,Nilai_Tunjangan from tblStatus order by jenis_status");
            for (int x = 0; x < Status.Rows.Count; x++)
            {
                cmbStatus.Items.Add(Status.Rows[x][1].ToString().Trim());
                
            }
            cmbStatus.SelectedIndex = -1;

            cmbJenisKelamin.Items.Add("L");
            cmbJenisKelamin.Items.Add("P");

            
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string no_peg = txtNo_Pegawai.Text;
                string nm_pegawai = txtNm_pegawai.Text;
                string tgl_masuk = dateTimePicker1.Value.ToString("ddMMyyyy");
                string jenis_kelamin = cmbJenisKelamin.Text;
                string status = cmbStatus.Text;
                int gaji_pokok = Convert.ToInt32(txtGaji_Pokok.Text);
                int uang_makan = Convert.ToInt32(txtUang_Makan.Text);
                int uang_transport = Convert.ToInt32(txtTransport.Text);


                string checktunjangan = "select Nilai_Tunjangan from tblStatus where deskripsi = '" + status + "'";
                DataTable nilaitunj = con.openTable(checktunjangan);

                txtNilai_Tunjangan.Text = nilaitunj.Rows[0][0].ToString();
                int tunjangan = Convert.ToInt32(txtNilai_Tunjangan.Text);

                if (no_peg == "" || nm_pegawai == "" || tgl_masuk == "" || jenis_kelamin == "" || status == "" || gaji_pokok == 0 || uang_makan == 0 || uang_transport == 0 || tunjangan == 0)
                {
                    MessageBox.Show("Data Pegawai Tidak Lengkap, Mohon di Lengkapi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string query = "insert into pegawai ([no_pegawai],[nm_pegawai],[tgl_masuk],[jenis_kelamin],[status],[gaji_pokok],[uang_makan],[uang_transport],[nilai_tunjangan]) , " +
                        "values ('" + no_peg + "', '" + nm_pegawai + "' , '" + tgl_masuk + "', '" + jenis_kelamin + "' , '" + status + "' , '" + gaji_pokok + "','" + uang_makan + "', " +
                        "'" + uang_transport + "','" + nilai_tunjangan + "')";
                    con.executeQuery(query);
                }

                MessageBox.Show("Data Pegawai Berhasil di Input");

                txtNo_Pegawai.Clear();
                txtNm_pegawai.Clear();
                txtGaji_Pokok.Clear();
                txtNilai_Tunjangan.Clear();
                txtTransport.Clear();
                txtUang_Makan.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code : " + ex.ToString());
                return;
            }
        }
    }
}
