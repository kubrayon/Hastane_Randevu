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
    public partial class Doktor : Form
    {
        public string doktorTc = "";
        public string doktorID = "";
        public Doktor(string dr_Tc)
        {
            InitializeComponent();
            doktorTc = dr_Tc;
            doktorID = vt.verial("dr_id", "doktor","0", ("dr_tc='"+ doktorTc +"'")).Rows[0][0].ToString();
        }
        vtclass vt = new vtclass();
        private void Doktor_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(doktorTc);
            cbhastarecete.DataSource = vt.verial("hasta.hasta_id as hasta,muayene.hasta_id,muayene.bolumID,hasta.hasta_tc","hasta", "INNER JOIN muayene ON muayene.hasta_id=hasta.hasta_id", "muayene.bolumID=(select doktor.bolumID from doktor where doktor.dr_id='"+doktorID+"')");
            cbhastarecete.ValueMember = "hasta";
            cbhastarecete.DisplayMember = "hasta_tc";

            doktorRandevu.DataSource = vt.verial("muayene.muayene_id as ID,muayene.muayene_tarih as Tarih,muayene.muayene_saat as Saat,hasta.hasta_ad,hasta.hasta_soyad,hasta.hasta_tc", "muayene", "INNER JOIN hasta ON hasta.hasta_id=muayene.hasta_id", "bolumID='" + (vt.verial("bolumID","doktor","0","dr_tc='"+doktorTc+"'").Rows[0][0].ToString()) + "'");
            dgvrecete.DataSource = vt.verial("recete.recete_id as ID,hasta.hasta_tc as TC, recete.recete_acıklama as Açıklama, hasta.hasta_ad as Ad,hasta.hasta_soyad as Soyad", "recete", "INNER JOIN hasta ON hasta.hasta_id=recete.hasta_id", "0");
            dgvrecete.Columns[2].Width = 300;
        }

        private void btn_randevuYenile_Click(object sender, EventArgs e)
        {
            doktorRandevu.DataSource = vt.verial("muayene.muayene_id as ID,muayene.muayene_tarih as Tarih,muayene.muayene_saat as Saat,hasta.hasta_ad,hasta.hasta_soyad,hasta.hasta_tc", "muayene", "INNER JOIN hasta ON hasta.hasta_id=muayene.hasta_id", "bolumID='" + (vt.verial("bolumID", "doktor", "0", "dr_tc='" + doktorTc + "'").Rows[0][0].ToString()) + "'");
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btn_receteEkle_Click(object sender, EventArgs e)
        {
            vt.veriekle("recete",rtaciklama.Text,doktorID,cbhastarecete.SelectedValue);
            dgvrecete.DataSource = vt.verial("recete.recete_id as ID,hasta.hasta_tc as TC, recete.recete_acıklama as Açıklama, hasta.hasta_ad as Ad,hasta.hasta_soyad as Soyad", "recete", "INNER JOIN hasta ON hasta.hasta_id=recete.hasta_id", "0");
        }

        private void btn_receteSil_Click(object sender, EventArgs e)
        {
            if (dgvrecete.CurrentRow != null)
            {
                vt.verisil("recete", "recete_id", dgvrecete.CurrentRow.Cells[0].Value.ToString());
                dgvrecete.DataSource = vt.verial("recete.recete_id as ID,hasta.hasta_tc as TC, recete.recete_acıklama as Açıklama, hasta.hasta_ad as Ad,hasta.hasta_soyad as Soyad", "recete", "INNER JOIN hasta ON hasta.hasta_id=recete.hasta_id", "0");
            }
        }

        private void btnhastalistele_Click(object sender, EventArgs e)
        {
            dgvhastalistele.DataSource = vt.verial("*", "hasta", "0", "0");
        }

        private void btntahlil_Click(object sender, EventArgs e)
        {
            if (tbtahlil.Text!="")
            {
                dgvtahlil.DataSource = vt.verial("tahlil.tahlil_id as ID,tahlil.tahlil_tarih as Tarih,tahlil.tahlil_sonuc as Sonuc, hasta.hasta_tc as TC, hasta.hasta_ad as Ad,hasta.hasta_soyad as Soyad", "tahlil", "INNER JOIN hasta ON hasta.hasta_id = tahlil.hasta_id", "hasta.hasta_id=(select hasta_id from hasta where hasta_tc='" + tbtahlil.Text + "')");
            }
            else
            {
                MessageBox.Show("Hasta TC numarasını doğru giriniz...");
            }
        }

        private void btn_randevuSil_Click(object sender, EventArgs e)
        {
            vt.verisil("muayene", "muayene_id", doktorRandevu.CurrentRow.Cells[0].Value.ToString());
            doktorRandevu.DataSource = vt.verial("muayene.muayene_id as ID,muayene.muayene_tarih as Tarih,muayene.muayene_saat as Saat,hasta.hasta_ad,hasta.hasta_soyad,hasta.hasta_tc", "muayene", "INNER JOIN hasta ON hasta.hasta_id=muayene.hasta_id", "bolumID='" + (vt.verial("bolumID", "doktor", "0", "dr_tc='" + doktorTc + "'").Rows[0][0].ToString()) + "'");
        }

        private void randevu_Click(object sender, EventArgs e)
        {

        }
    }
}
