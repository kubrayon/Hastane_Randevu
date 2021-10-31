namespace klinik
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tc = new System.Windows.Forms.TextBox();
            this.btn_doktor = new System.Windows.Forms.Button();
            this.btn_danisma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klinik Otomasyonu Girişi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_tc
            // 
            this.tb_tc.Location = new System.Drawing.Point(323, 150);
            this.tb_tc.MaxLength = 11;
            this.tb_tc.Name = "tb_tc";
            this.tb_tc.Size = new System.Drawing.Size(189, 20);
            this.tb_tc.TabIndex = 1;
            // 
            // btn_doktor
            // 
            this.btn_doktor.BackColor = System.Drawing.Color.Silver;
            this.btn_doktor.Location = new System.Drawing.Point(192, 189);
            this.btn_doktor.Name = "btn_doktor";
            this.btn_doktor.Size = new System.Drawing.Size(125, 50);
            this.btn_doktor.TabIndex = 2;
            this.btn_doktor.Text = "Doktor Girişi";
            this.btn_doktor.UseVisualStyleBackColor = false;
            this.btn_doktor.Click += new System.EventHandler(this.btn_doktor_Click);
            // 
            // btn_danisma
            // 
            this.btn_danisma.BackColor = System.Drawing.Color.Silver;
            this.btn_danisma.Location = new System.Drawing.Point(387, 189);
            this.btn_danisma.Name = "btn_danisma";
            this.btn_danisma.Size = new System.Drawing.Size(125, 50);
            this.btn_danisma.TabIndex = 3;
            this.btn_danisma.Text = "Danışma Girişi";
            this.btn_danisma.UseVisualStyleBackColor = false;
            this.btn_danisma.Click += new System.EventHandler(this.btn_danisma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(192, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Tc Kimlik:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(129, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 151);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_danisma);
            this.Controls.Add(this.btn_doktor);
            this.Controls.Add(this.tb_tc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tc;
        private System.Windows.Forms.Button btn_doktor;
        private System.Windows.Forms.Button btn_danisma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

