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
    public partial class MAIN_MENU : Form
    {
        public MAIN_MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            INPUT_LEMBUR obj = new INPUT_LEMBUR();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CREATE_SLIP obj = new CREATE_SLIP();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            REPORT obj = new REPORT();
            obj.Show();
        }
    }
}
