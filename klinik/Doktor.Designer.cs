namespace klinik
{
    partial class Doktor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.randevu = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_randevuYenile = new System.Windows.Forms.Button();
            this.btn_randevuSil = new System.Windows.Forms.Button();
            this.doktorRandevu = new System.Windows.Forms.DataGridView();
            this.recete = new System.Windows.Forms.TabPage();
            this.btn_receteSil = new System.Windows.Forms.Button();
            this.btn_receteEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvrecete = new System.Windows.Forms.DataGridView();
            this.cbhastarecete = new System.Windows.Forms.ComboBox();
            this.rtaciklama = new System.Windows.Forms.RichTextBox();
            this.tahlil = new System.Windows.Forms.TabPage();
            this.tbtahlil = new System.Windows.Forms.TextBox();
            this.dgvtahlil = new System.Windows.Forms.DataGridView();
            this.btntahlil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hastalar = new System.Windows.Forms.TabPage();
            this.btnhastalistele = new System.Windows.Forms.Button();
            this.dgvhastalistele = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.randevu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktorRandevu)).BeginInit();
            this.recete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecete)).BeginInit();
            this.tahlil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtahlil)).BeginInit();
            this.hastalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhastalistele)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.randevu);
            this.tabControl1.Controls.Add(this.recete);
            this.tabControl1.Controls.Add(this.tahlil);
            this.tabControl1.Controls.Add(this.hastalar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // randevu
            // 
            this.randevu.BackColor = System.Drawing.Color.PowderBlue;
            this.randevu.Controls.Add(this.button5);
            this.randevu.Controls.Add(this.btn_randevuYenile);
            this.randevu.Controls.Add(this.btn_randevuSil);
            this.randevu.Controls.Add(this.doktorRandevu);
            this.randevu.Location = new System.Drawing.Point(4, 22);
            this.randevu.Name = "randevu";
            this.randevu.Padding = new System.Windows.Forms.Padding(3);
            this.randevu.Size = new System.Drawing.Size(720, 392);
            this.randevu.TabIndex = 0;
            this.randevu.Text = "Randevular";
            this.randevu.Click += new System.EventHandler(this.randevu_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::klinik.Properties.Resources.home;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(664, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.homePage_Click);
            // 
            // btn_randevuYenile
            // 
            this.btn_randevuYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_randevuYenile.BackColor = System.Drawing.Color.Silver;
            this.btn_randevuYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevuYenile.Location = new System.Drawing.Point(137, 335);
            this.btn_randevuYenile.Name = "btn_randevuYenile";
            this.btn_randevuYenile.Size = new System.Drawing.Size(125, 50);
            this.btn_randevuYenile.TabIndex = 5;
            this.btn_randevuYenile.Text = "Randevuları Yenile";
            this.btn_randevuYenile.UseVisualStyleBackColor = false;
            this.btn_randevuYenile.Click += new System.EventHandler(this.btn_randevuYenile_Click);
            // 
            // btn_randevuSil
            // 
            this.btn_randevuSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_randevuSil.BackColor = System.Drawing.Color.Red;
            this.btn_randevuSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevuSil.Location = new System.Drawing.Point(6, 335);
            this.btn_randevuSil.Name = "btn_randevuSil";
            this.btn_randevuSil.Size = new System.Drawing.Size(125, 50);
            this.btn_randevuSil.TabIndex = 3;
            this.btn_randevuSil.Text = "Randevuyu Sil";
            this.btn_randevuSil.UseVisualStyleBackColor = false;
            this.btn_randevuSil.Click += new System.EventHandler(this.btn_randevuSil_Click);
            // 
            // doktorRandevu
            // 
            this.doktorRandevu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doktorRandevu.BackgroundColor = System.Drawing.Color.White;
            this.doktorRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doktorRandevu.Location = new System.Drawing.Point(3, 6);
            this.doktorRandevu.Name = "doktorRandevu";
            this.doktorRandevu.Size = new System.Drawing.Size(711, 323);
            this.doktorRandevu.TabIndex = 0;
            // 
            // recete
            // 
            this.recete.BackColor = System.Drawing.Color.PowderBlue;
            this.recete.Controls.Add(this.btn_receteSil);
            this.recete.Controls.Add(this.btn_receteEkle);
            this.recete.Controls.Add(this.label2);
            this.recete.Controls.Add(this.label1);
            this.recete.Controls.Add(this.dgvrecete);
            this.recete.Controls.Add(this.cbhastarecete);
            this.recete.Controls.Add(this.rtaciklama);
            this.recete.Location = new System.Drawing.Point(4, 22);
            this.recete.Name = "recete";
            this.recete.Padding = new System.Windows.Forms.Padding(3);
            this.recete.Size = new System.Drawing.Size(720, 392);
            this.recete.TabIndex = 1;
            this.recete.Text = "ReçeteYaz";
            // 
            // btn_receteSil
            // 
            this.btn_receteSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_receteSil.BackColor = System.Drawing.Color.Red;
            this.btn_receteSil.Location = new System.Drawing.Point(509, 298);
            this.btn_receteSil.Name = "btn_receteSil";
            this.btn_receteSil.Size = new System.Drawing.Size(125, 50);
            this.btn_receteSil.TabIndex = 7;
            this.btn_receteSil.Text = "Reçeteyi Sil";
            this.btn_receteSil.UseVisualStyleBackColor = false;
            this.btn_receteSil.Click += new System.EventHandler(this.btn_receteSil_Click);
            // 
            // btn_receteEkle
            // 
            this.btn_receteEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_receteEkle.BackColor = System.Drawing.Color.Silver;
            this.btn_receteEkle.Location = new System.Drawing.Point(359, 298);
            this.btn_receteEkle.Name = "btn_receteEkle";
            this.btn_receteEkle.Size = new System.Drawing.Size(125, 50);
            this.btn_receteEkle.TabIndex = 5;
            this.btn_receteEkle.Text = "Reçeteyi Kaydet";
            this.btn_receteEkle.UseVisualStyleBackColor = false;
            this.btn_receteEkle.Click += new System.EventHandler(this.btn_receteEkle_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(362, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reçete Açıklaması";
            // 
            // dgvrecete
            // 
            this.dgvrecete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrecete.BackgroundColor = System.Drawing.Color.White;
            this.dgvrecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrecete.Location = new System.Drawing.Point(9, 6);
            this.dgvrecete.Name = "dgvrecete";
            this.dgvrecete.Size = new System.Drawing.Size(705, 190);
            this.dgvrecete.TabIndex = 2;
            // 
            // cbhastarecete
            // 
            this.cbhastarecete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbhastarecete.FormattingEnabled = true;
            this.cbhastarecete.Location = new System.Drawing.Point(359, 252);
            this.cbhastarecete.Name = "cbhastarecete";
            this.cbhastarecete.Size = new System.Drawing.Size(275, 21);
            this.cbhastarecete.TabIndex = 1;
            // 
            // rtaciklama
            // 
            this.rtaciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtaciklama.Location = new System.Drawing.Point(9, 252);
            this.rtaciklama.MaxLength = 500;
            this.rtaciklama.Name = "rtaciklama";
            this.rtaciklama.Size = new System.Drawing.Size(344, 96);
            this.rtaciklama.TabIndex = 0;
            this.rtaciklama.Text = "";
            // 
            // tahlil
            // 
            this.tahlil.BackColor = System.Drawing.Color.PowderBlue;
            this.tahlil.Controls.Add(this.tbtahlil);
            this.tahlil.Controls.Add(this.dgvtahlil);
            this.tahlil.Controls.Add(this.btntahlil);
            this.tahlil.Controls.Add(this.label3);
            this.tahlil.Location = new System.Drawing.Point(4, 22);
            this.tahlil.Name = "tahlil";
            this.tahlil.Size = new System.Drawing.Size(720, 392);
            this.tahlil.TabIndex = 2;
            this.tahlil.Text = "Tahliller";
            // 
            // tbtahlil
            // 
            this.tbtahlil.Location = new System.Drawing.Point(76, 11);
            this.tbtahlil.MaxLength = 11;
            this.tbtahlil.Name = "tbtahlil";
            this.tbtahlil.Size = new System.Drawing.Size(172, 20);
            this.tbtahlil.TabIndex = 9;
            // 
            // dgvtahlil
            // 
            this.dgvtahlil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtahlil.BackgroundColor = System.Drawing.Color.White;
            this.dgvtahlil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtahlil.Location = new System.Drawing.Point(10, 56);
            this.dgvtahlil.Name = "dgvtahlil";
            this.dgvtahlil.Size = new System.Drawing.Size(707, 318);
            this.dgvtahlil.TabIndex = 8;
            // 
            // btntahlil
            // 
            this.btntahlil.BackColor = System.Drawing.Color.Silver;
            this.btntahlil.Location = new System.Drawing.Point(254, 3);
            this.btntahlil.Name = "btntahlil";
            this.btntahlil.Size = new System.Drawing.Size(125, 50);
            this.btntahlil.TabIndex = 7;
            this.btntahlil.Text = "Tahlilleri Getir";
            this.btntahlil.UseVisualStyleBackColor = false;
            this.btntahlil.Click += new System.EventHandler(this.btntahlil_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta :";
            // 
            // hastalar
            // 
            this.hastalar.BackColor = System.Drawing.Color.PowderBlue;
            this.hastalar.Controls.Add(this.btnhastalistele);
            this.hastalar.Controls.Add(this.dgvhastalistele);
            this.hastalar.Location = new System.Drawing.Point(4, 22);
            this.hastalar.Name = "hastalar";
            this.hastalar.Size = new System.Drawing.Size(720, 392);
            this.hastalar.TabIndex = 3;
            this.hastalar.Text = "Hastalar";
            // 
            // btnhastalistele
            // 
            this.btnhastalistele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnhastalistele.BackColor = System.Drawing.Color.Silver;
            this.btnhastalistele.Location = new System.Drawing.Point(3, 339);
            this.btnhastalistele.Name = "btnhastalistele";
            this.btnhastalistele.Size = new System.Drawing.Size(125, 50);
            this.btnhastalistele.TabIndex = 8;
            this.btnhastalistele.Text = "Hastaları Listele";
            this.btnhastalistele.UseVisualStyleBackColor = false;
            this.btnhastalistele.Click += new System.EventHandler(this.btnhastalistele_Click);
            // 
            // dgvhastalistele
            // 
            this.dgvhastalistele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvhastalistele.BackgroundColor = System.Drawing.Color.White;
            this.dgvhastalistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhastalistele.Location = new System.Drawing.Point(3, 3);
            this.dgvhastalistele.Name = "dgvhastalistele";
            this.dgvhastalistele.Size = new System.Drawing.Size(717, 330);
            this.dgvhastalistele.TabIndex = 0;
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "Doktor";
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            this.tabControl1.ResumeLayout(false);
            this.randevu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doktorRandevu)).EndInit();
            this.recete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecete)).EndInit();
            this.tahlil.ResumeLayout(false);
            this.tahlil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtahlil)).EndInit();
            this.hastalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhastalistele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage randevu;
        private System.Windows.Forms.DataGridView doktorRandevu;
        private System.Windows.Forms.TabPage recete;
        private System.Windows.Forms.TabPage tahlil;
        private System.Windows.Forms.TabPage hastalar;
        private System.Windows.Forms.Button btn_randevuYenile;
        private System.Windows.Forms.Button btn_randevuSil;
        private System.Windows.Forms.Button btn_receteSil;
        private System.Windows.Forms.Button btn_receteEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvrecete;
        private System.Windows.Forms.ComboBox cbhastarecete;
        private System.Windows.Forms.RichTextBox rtaciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvtahlil;
        private System.Windows.Forms.Button btntahlil;
        private System.Windows.Forms.Button btnhastalistele;
        private System.Windows.Forms.DataGridView dgvhastalistele;
        private System.Windows.Forms.TextBox tbtahlil;
        private System.Windows.Forms.Button button5;
    }
}