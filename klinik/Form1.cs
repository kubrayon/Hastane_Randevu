using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klinik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        vtclass vt = new vtclass();
        private void btn_doktor_Click(object sender, EventArgs e)
        {
            if ((vt.verial("Count(dr_tc)","doktor","0", ("dr_tc = '" + tb_tc.Text + "'")).Rows[0][0].ToString()) == "1")
            {
                Doktor dr = new Doktor(tb_tc.Text);
                this.Hide();
                dr.Show();
            }
            else
            {
                MessageBox.Show("Doktor bulunamadı...");
            }
        }

        private void btn_danisma_Click(object sender, EventArgs e)
        {
            Danisma dm = new Danisma();
            this.Hide();
            dm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
