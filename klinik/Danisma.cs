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
    public partial class Danisma : Form
    {
        public Danisma()
        {
            InitializeComponent();
        }
        vtclass vt = new vtclass();
        public void homePage_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
        private void Danisma_Load(object sender, EventArgs e)
        {
            cbbolum.DataSource = vt.verial("*","bolumler","0","0");
            cbbolum.ValueMember = "bolum_id";
            cbbolum.DisplayMember = "bolum_ad";

            cbbolum0.DataSource = vt.verial("*","bolumler","0","0");
            cbbolum0.ValueMember = "bolum_id";
            cbbolum0.DisplayMember = "bolum_ad";

            cbsaat.DisplayMember = "Text";
            cbsaat.ValueMember = "Value";
            var items = new[] {
                new { Text = "10:00", Value = "1" },
                new { Text = "10:30", Value = "2" },
                new { Text = "11:00", Value = "3" },
                new { Text = "11:30", Value = "4" },
                new { Text = "12:00", Value = "5" },
                new { Text = "13:00", Value = "6" },
                new { Text = "13:30", Value = "7" }
            };
            cbsaat.DataSource = items;

            cbhastacins.DisplayMember = "Text";
            cbhastacins.ValueMember = "Value";
            var cins = new[]
            {
                new { Text = "Kadın", Value = "1" },
                new { Text = "Erkek", Value = "0" }
            };
            cbhastacins.DataSource = cins;

            dgvRandevu.DataSource = vt.verial("muayene.muayene_id as ID, muayene.muayene_tarih as Tarih, muayene.muayene_saat as Saat, bolumler.bolum_ad as Bölüm,hasta.hasta_tc, hasta.hasta_ad as HastaAdı, hasta.hasta_soyad as HastaSoyad", "muayene", "INNER JOIN hasta ON hasta.hasta_id=muayene.hasta_id INNER JOIN bolumler ON bolumler.bolum_id=muayene.bolumID", "0");
            dgvdanisma.DataSource = vt.verial("doktor.dr_id as ID, bolumler.bolum_ad as Bölüm,doktor.dr_ad as Ad,doktor.dr_soyad as Soyad,doktor.dr_tc as TC,doktor.dr_tel as Telefon", "doktor", "INNER JOIN bolumler ON bolumler.bolum_id=doktor.bolumID", "0");
            dgvhasta.DataSource = vt.verial("hasta_id as ID,  hasta_ad as Ad,hasta_soyad as Soyad,hasta_tc as TC,hasta_dogum as Dogum_Tarihi", "hasta", "0", "0");
        }


        private void btndoktorekle_Click(object sender, EventArgs e)
        {
            if (tbdrtc.TextLength<11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneden az olamaz");
            }
            else
            {
                if (int.Parse(vt.verial("Count(dr_tc)", "doktor", "0", "dr_tc ='" + tbdrtc.Text + "'").Rows[0][0].ToString()) > 0)
                {
                    MessageBox.Show("Bu doktor sisteme kayıtlı!");
                }
                else
                {
                    if (tbdradi.Text != "" && tbdrsoyadi.Text != "" && tbdrtc.Text != "" && tbdrtel.Text != "" && tbdremail.Text != "")
                    {
                        vt.veriekle("doktor", tbdradi.Text, tbdrsoyadi.Text, tbdrtc.Text, dtdr.Value.Date.ToString("yyyy-MM-dd").ToString(), tbdrtel.Text, tbdremail.Text, cbbolum.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("Boş Alanları Doldurunuz...");
                    }
                    dgvdanisma.DataSource = vt.verial("doktor.dr_id as ID, bolumler.bolum_ad as Bölüm,doktor.dr_ad as Ad,doktor.dr_soyad as Soyad,doktor.dr_tc as TC,doktor.dr_tel as Telefon", "doktor", "INNER JOIN bolumler ON bolumler.bolum_id=doktor.bolumID", "0");
                }
            }
        }

        private void btnhastaekle_Click(object sender, EventArgs e)
        {
            if (tbhastatc.TextLength < 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneden az olamaz");
            }
            else
            {
                if (int.Parse(vt.verial("Count(hasta_tc)", "hasta", "0", "hasta_tc ='" + tbhastatc.Text + "'").Rows[0][0].ToString()) > 0)
                {
                    MessageBox.Show("Bu hasta sisteme kayıtlı!");
                }
                else
                {
                    vt.veriekle("hasta", tbhastaad.Text, tbhastasoyad.Text, tbhastatc.Text, dthasta.Value.Date.ToString("yyyy-MM-dd").ToString(), rtadres.Text, cbhastacins.SelectedValue, tbhastaanne.Text, tbhastababa.Text, tbhastatel.Text);
                    dgvhasta.DataSource = vt.verial("hasta_id as ID,  hasta_ad as Ad,hasta_soyad as Soyad,hasta_tc as TC,hasta_dogum as Dogum_Tarihi", "hasta", "0", "0");
                }
            }
        }

        private void btn_randevuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (vt.verial("Count(hasta_tc)", "hasta","0","hasta_tc='"+tb_hastaTc.Text+"'").Rows[0][0].ToString() == "1")
                {
                    if (vt.verial("Count(muayene_id)", "muayene", "0", "muayene_saat = '"+cbsaat.Text.ToString()+ "' AND muayene_tarih = '"+dtRandevu.Value.Date.ToString("yyyy-MM-dd").ToString()+ "' AND bolumID = '"+cbbolum0.SelectedValue+"'").Rows[0][0].ToString()!="0")
                    {
                        MessageBox.Show("Bu tarih ve saatte kayıt mevcuttur");
                    }
                    else
                    {
                        vt.veriekle("muayene", dtRandevu.Value.Date.ToString("yyyy-MM-dd").ToString(), cbsaat.Text.ToString(), cbbolum0.SelectedValue, (vt.verial("hasta_id", "hasta", "0", "hasta_tc='" + tb_hastaTc.Text + "'").Rows[0][0].ToString()));
                        dgvRandevu.DataSource = vt.verial("muayene.muayene_id as ID, muayene.muayene_tarih as Tarih, muayene.muayene_saat as Saat, bolumler.bolum_ad as Bölüm,hasta.hasta_tc, hasta.hasta_ad as HastaAdı, hasta.hasta_soyad as HastaSoyad", "muayene", "INNER JOIN hasta ON hasta.hasta_id=muayene.hasta_id INNER JOIN bolumler ON bolumler.bolum_id=muayene.bolumID", "0");
                    }
                }
                else
                {
                    MessageBox.Show("Sisteme Hastayı Kaydedin...");
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void btn_randevuSil_Click(object sender, EventArgs e)
        {
            if (dgvRandevu.CurrentRow != null)
            {
                vt.verisil("muayene", "muayene_id", dgvRandevu.CurrentRow.Cells[0].Value.ToString());
                dgvRandevu.DataSource = vt.verial("muayene.muayene_id as ID, muayene.muayene_tarih as Tarih, muayene.muayene_saat as Saat, bolumler.bolum_ad as Bölüm,hasta.hasta_tc, hasta.hasta_ad as HastaAdı, hasta.hasta_soyad as HastaSoyad", "muayene", "INNER JOIN hasta ON hasta.hasta_id=muayene.hasta_id INNER JOIN bolumler ON bolumler.bolum_id=muayene.bolumID", "0");
            }
            else
            {
                MessageBox.Show("İlk önce silinecek kaydı seçin...");
            }
        }

        private void hastaSil_Click(object sender, EventArgs e)
        {
            if (dgvhasta.CurrentRow != null)
            {
                if (tbhastatc.TextLength < 11)
                {
                    MessageBox.Show("TC kimlik numarası 11 haneden az olamaz");
                }
                else
                {
                    try
                    {
                        vt.verisil("muayene","hasta_id", dgvhasta.CurrentRow.Cells[0].Value.ToString());
                        vt.verisil("recete","hasta_id", dgvhasta.CurrentRow.Cells[0].Value.ToString());
                        vt.verisil("tahlil","hasta_id", dgvhasta.CurrentRow.Cells[0].Value.ToString());
                        vt.verisil("hasta", "hasta_id", dgvhasta.CurrentRow.Cells[0].Value.ToString());
                        dgvhasta.DataSource = vt.verial("hasta_id as ID,  hasta_ad as Ad,hasta_soyad as Soyad,hasta_tc as TC,hasta_dogum as Dogum_Tarihi", "hasta", "0", "0");
                    }
                    catch (Exception h)
                    {
                        MessageBox.Show("Hata ile karşılaşıldı...");
                        MessageBox.Show(h.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("İlk önce silinecek kaydı seçin...");
            }
        }

        private void doktorSil_Click(object sender, EventArgs e)
        {
            if (dgvdanisma.CurrentRow != null)
            {
                vt.verisil("doktor", "dr_id", dgvdanisma.CurrentRow.Cells[0].Value.ToString());
                dgvdanisma.DataSource = vt.verial("doktor.dr_id as ID, bolumler.bolum_ad as Bölüm,doktor.dr_ad as Ad,doktor.dr_soyad as Soyad,doktor.dr_tc as TC,doktor.dr_tel as Telefon", "doktor", "INNER JOIN bolumler ON bolumler.bolum_id=doktor.bolumID", "0");
            }
            else
            {
                MessageBox.Show("İlk önce silinecek kaydı seçin...");
            }
        }

        private void btn_randevuGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvRandevu.CurrentRow != null)
            {
                if (int.Parse(vt.verial("Count(hasta_tc)", "hasta", "0", "hasta_tc ='" + tb_hastaTc.Text + "'").Rows[0][0].ToString()) > 0)
                {
                    vt.kayitGuncelle("muayene", "muayene_id", dgvRandevu.CurrentRow.Cells[0].Value.ToString(), dtRandevu.Value.Date.ToString("yyyy-MM-dd").ToString(), cbsaat.Text.ToString(), cbbolum0.SelectedValue, (vt.verial("hasta_id", "hasta", "0", "hasta_tc='" + tb_hastaTc.Text + "'").Rows[0][0].ToString()));
                    dgvRandevu.DataSource = vt.verial("muayene.muayene_id as ID, muayene.muayene_tarih as Tarih, muayene.muayene_saat as Saat, bolumler.bolum_ad as Bölüm,hasta.hasta_tc, hasta.hasta_ad as HastaAdı, hasta.hasta_soyad as HastaSoyad", "muayene", "INNER JOIN hasta ON hasta.hasta_id=muayene.hasta_id INNER JOIN bolumler ON bolumler.bolum_id=muayene.bolumID", "0");
                }
                else
                {
                    MessageBox.Show("Bu hasta sisteme kayıtlı değil!");
                }
            }
            else
            {
                MessageBox.Show("İlk önce güncellenecek kaydı seçin ve bilgileri doldurun");
            }
        }

        private void hastaGuncel_Click(object sender, EventArgs e)
        {
            if (dgvhasta.CurrentRow != null)
            {
                if (int.Parse(vt.verial("Count(hasta_tc)", "hasta", "0", "hasta_tc ='" + tbhastatc.Text + "'").Rows[0][0].ToString()) > 0)
                {
                    vt.kayitGuncelle("hasta", "hasta_id", dgvhasta.CurrentRow.Cells[0].Value.ToString(), tbhastaad.Text, tbhastasoyad.Text, tbhastatc.Text, dthasta.Value.Date.ToString("yyyy-MM-dd").ToString(), rtadres.Text, cbhastacins.SelectedValue, tbhastaanne.Text, tbhastababa.Text, tbhastatel.Text);
                    dgvhasta.DataSource = vt.verial("hasta_id as ID,  hasta_ad as Ad,hasta_soyad as Soyad,hasta_tc as TC,hasta_dogum as Dogum_Tarihi", "hasta", "0", "0");
                }
                else
                {
                    MessageBox.Show("Bu hasta sisteme kayıtlı değil!");
                }
            }
            else
            {
                MessageBox.Show("İlk önce güncellenecek kaydı seçin ve bilgileri doldurun");
            }
        }

        private void doktorGuncel_Click(object sender, EventArgs e)
        {

            if (dgvdanisma.CurrentRow != null)
            {
                if (int.Parse(vt.verial("Count(dr_tc)", "doktor", "0", "dr_tc ='" + tbdrtc.Text + "'").Rows[0][0].ToString()) > 0)
                {
                    vt.kayitGuncelle("doktor", "dr_id", dgvdanisma.CurrentRow.Cells[0].Value.ToString(), tbdradi.Text, tbdrsoyadi.Text, tbdrtc.Text, dtdr.Value.Date.ToString("yyyy-MM-dd").ToString(), tbdrtel.Text, tbdremail.Text, cbbolum.SelectedValue);
                    dgvdanisma.DataSource = vt.verial("doktor.dr_id as ID, bolumler.bolum_ad as Bölüm,doktor.dr_ad as Ad,doktor.dr_soyad as Soyad,doktor.dr_tc as TC,doktor.dr_tel as Telefon", "doktor", "INNER JOIN bolumler ON bolumler.bolum_id=doktor.bolumID", "0");
                }
                else
                {
                    MessageBox.Show("Bu hasta sisteme kayıtlı değil!");
                }
            }
            else
            {
                MessageBox.Show("İlk önce güncellenecek kaydı seçin ve bilgileri doldurun");
            }
        }

        private void dgvRandevu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_hastaTc.Text = dgvRandevu.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvhasta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbhastaad.Text = dgvhasta.CurrentRow.Cells[1].Value.ToString();
            tbhastasoyad.Text = dgvhasta.CurrentRow.Cells[2].Value.ToString();
            tbhastatc.Text = dgvhasta.CurrentRow.Cells[3].Value.ToString();
            dthasta.Text = dgvhasta.CurrentRow.Cells[4].Value.ToString();

            rtadres.Text = vt.verial("hasta_adres","hasta","0",("hasta_id='"+ dgvhasta.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
            cbhastacins.Text = "";
            //if ((vt.verial("hasta_cins", "hasta", "0", ("hasta_id='" + dgvhasta.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString()) == "1")
            //{ cbhastacins.SelectedIndex = 0; }
            //else
            //{ cbhastacins.SelectedIndex = 1; }
            tbhastaanne.Text = vt.verial("hasta_anne", "hasta", "0", ("hasta_id='" + dgvhasta.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
            tbhastababa.Text = vt.verial("hasta_baba", "hasta", "0", ("hasta_id='" + dgvhasta.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
            tbhastatel.Text = vt.verial("hasta_tel", "hasta", "0", ("hasta_id='" + dgvhasta.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
        }

        private void dgvdanisma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbdradi.Text = vt.verial("dr_ad", "doktor", "0", ("dr_id='" + dgvdanisma.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
            tbdrsoyadi.Text = vt.verial("dr_soyad", "doktor", "0", ("dr_id='" + dgvdanisma.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
            tbdrtc.Text = vt.verial("dr_tc", "doktor", "0", ("dr_id='" + dgvdanisma.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
            dtdr.Text = vt.verial("dr_dogum", "doktor", "0", ("dr_id='" + dgvdanisma.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
            tbdrtel.Text = vt.verial("dr_tel", "doktor", "0", ("dr_id='" + dgvdanisma.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
            tbdremail.Text = vt.verial("dr_email", "doktor", "0", ("dr_id='" + dgvdanisma.CurrentRow.Cells[0].Value.ToString() + "'")).Rows[0][0].ToString();
            cbbolum.Text = "";
        }

        private void btnhastalistele_Click(object sender, EventArgs e)
        {
            dgvtahlil.DataSource = vt.verial("tahlil.tahlil_id as ID,tahlil.tahlil_tarih as Tarih,tahlil.tahlil_sonuc as Sonuc, hasta.hasta_tc as TC, hasta.hasta_ad as Ad,hasta.hasta_soyad as Soyad", "tahlil", "INNER JOIN hasta ON hasta.hasta_id = tahlil.hasta_id","0");
            dgvtahlil.Columns[2].Width = 300;
        }
    }
}
