namespace MERP
{
    partial class proje_duzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proje_duzenle));
            this.lbl_birim = new System.Windows.Forms.Label();
            this.btn_harcamalar = new System.Windows.Forms.Button();
            this.lbl_harcamalar = new System.Windows.Forms.Label();
            this.cmb_birim = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_prjDZN = new System.Windows.Forms.Button();
            this.dtp_bitis = new System.Windows.Forms.DateTimePicker();
            this.dtp_baslangıc = new System.Windows.Forms.DateTimePicker();
            this.txt_musteri = new System.Windows.Forms.TextBox();
            this.txt_proje_no = new System.Windows.Forms.TextBox();
            this.txt_butce = new System.Windows.Forms.TextBox();
            this.txt_proje_adi = new System.Windows.Forms.TextBox();
            this.rcb_aciklama = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_vade = new System.Windows.Forms.TextBox();
            this.ck_prj = new System.Windows.Forms.CheckBox();
            this.ck_seri = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_birim
            // 
            this.lbl_birim.AutoSize = true;
            this.lbl_birim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_birim.Location = new System.Drawing.Point(114, 178);
            this.lbl_birim.Name = "lbl_birim";
            this.lbl_birim.Size = new System.Drawing.Size(41, 16);
            this.lbl_birim.TabIndex = 88;
            this.lbl_birim.Text = "Birim ";
            // 
            // btn_harcamalar
            // 
            this.btn_harcamalar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_harcamalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_harcamalar.Location = new System.Drawing.Point(582, 237);
            this.btn_harcamalar.Name = "btn_harcamalar";
            this.btn_harcamalar.Size = new System.Drawing.Size(119, 56);
            this.btn_harcamalar.TabIndex = 86;
            this.btn_harcamalar.Text = "Harcamalar ve Ödemeler";
            this.btn_harcamalar.UseVisualStyleBackColor = false;
            this.btn_harcamalar.Click += new System.EventHandler(this.btn_harcamalar_Click);
            // 
            // lbl_harcamalar
            // 
            this.lbl_harcamalar.AutoSize = true;
            this.lbl_harcamalar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_harcamalar.Location = new System.Drawing.Point(21, 178);
            this.lbl_harcamalar.Name = "lbl_harcamalar";
            this.lbl_harcamalar.Size = new System.Drawing.Size(95, 16);
            this.lbl_harcamalar.TabIndex = 85;
            this.lbl_harcamalar.Text = "Harcamalar  -  ";
            // 
            // cmb_birim
            // 
            this.cmb_birim.FormattingEnabled = true;
            this.cmb_birim.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "TRY",
            "CHF"});
            this.cmb_birim.Location = new System.Drawing.Point(289, 143);
            this.cmb_birim.Name = "cmb_birim";
            this.cmb_birim.Size = new System.Drawing.Size(117, 21);
            this.cmb_birim.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(240, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 82;
            this.label9.Text = "Birim : ";
            // 
            // btn_prjDZN
            // 
            this.btn_prjDZN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_prjDZN.Location = new System.Drawing.Point(701, 237);
            this.btn_prjDZN.Name = "btn_prjDZN";
            this.btn_prjDZN.Size = new System.Drawing.Size(119, 56);
            this.btn_prjDZN.TabIndex = 81;
            this.btn_prjDZN.Text = "DÜZENLE";
            this.btn_prjDZN.UseVisualStyleBackColor = true;
            this.btn_prjDZN.Click += new System.EventHandler(this.btn_prjDZN_Click);
            // 
            // dtp_bitis
            // 
            this.dtp_bitis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_bitis.Location = new System.Drawing.Point(544, 175);
            this.dtp_bitis.Name = "dtp_bitis";
            this.dtp_bitis.Size = new System.Drawing.Size(258, 23);
            this.dtp_bitis.TabIndex = 80;
            // 
            // dtp_baslangıc
            // 
            this.dtp_baslangıc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_baslangıc.Location = new System.Drawing.Point(544, 141);
            this.dtp_baslangıc.Name = "dtp_baslangıc";
            this.dtp_baslangıc.Size = new System.Drawing.Size(259, 23);
            this.dtp_baslangıc.TabIndex = 79;
            // 
            // txt_musteri
            // 
            this.txt_musteri.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteri.Location = new System.Drawing.Point(544, 107);
            this.txt_musteri.Name = "txt_musteri";
            this.txt_musteri.Size = new System.Drawing.Size(258, 23);
            this.txt_musteri.TabIndex = 78;
            // 
            // txt_proje_no
            // 
            this.txt_proje_no.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_proje_no.Location = new System.Drawing.Point(544, 73);
            this.txt_proje_no.Name = "txt_proje_no";
            this.txt_proje_no.Size = new System.Drawing.Size(258, 23);
            this.txt_proje_no.TabIndex = 77;
            // 
            // txt_butce
            // 
            this.txt_butce.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_butce.Location = new System.Drawing.Point(117, 141);
            this.txt_butce.Name = "txt_butce";
            this.txt_butce.Size = new System.Drawing.Size(117, 23);
            this.txt_butce.TabIndex = 76;
            // 
            // txt_proje_adi
            // 
            this.txt_proje_adi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_proje_adi.Location = new System.Drawing.Point(117, 107);
            this.txt_proje_adi.Name = "txt_proje_adi";
            this.txt_proje_adi.Size = new System.Drawing.Size(289, 23);
            this.txt_proje_adi.TabIndex = 75;
            // 
            // rcb_aciklama
            // 
            this.rcb_aciklama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcb_aciklama.Location = new System.Drawing.Point(117, 212);
            this.rcb_aciklama.Name = "rcb_aciklama";
            this.rcb_aciklama.Size = new System.Drawing.Size(459, 81);
            this.rcb_aciklama.TabIndex = 74;
            this.rcb_aciklama.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "Açıklama : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(431, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Müşteri : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(431, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "Proje Bitiş Tarihi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(406, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 70;
            this.label5.Text = "Proje Başlangıç Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Proje Bütçesi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(431, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Proje No : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Proje Adı : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(364, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 66;
            this.label4.Text = "PROJELER";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(740, 30);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 90;
            this.lbl_id.Text = "ID";
            this.lbl_id.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(193, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 92;
            this.label13.Text = "Vade(Gün) : ";
            // 
            // txt_vade
            // 
            this.txt_vade.Location = new System.Drawing.Point(289, 178);
            this.txt_vade.Name = "txt_vade";
            this.txt_vade.Size = new System.Drawing.Size(117, 20);
            this.txt_vade.TabIndex = 91;
            // 
            // ck_prj
            // 
            this.ck_prj.AutoSize = true;
            this.ck_prj.Location = new System.Drawing.Point(244, 73);
            this.ck_prj.Name = "ck_prj";
            this.ck_prj.Size = new System.Drawing.Size(50, 17);
            this.ck_prj.TabIndex = 98;
            this.ck_prj.Text = "Proje";
            this.ck_prj.UseVisualStyleBackColor = true;
            // 
            // ck_seri
            // 
            this.ck_seri.AutoSize = true;
            this.ck_seri.Location = new System.Drawing.Point(24, 73);
            this.ck_seri.Name = "ck_seri";
            this.ck_seri.Size = new System.Drawing.Size(77, 17);
            this.ck_seri.TabIndex = 97;
            this.ck_seri.Text = "Seri Üretim";
            this.ck_seri.UseVisualStyleBackColor = true;
            // 
            // proje_duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 322);
            this.Controls.Add(this.ck_prj);
            this.Controls.Add(this.ck_seri);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_vade);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_birim);
            this.Controls.Add(this.btn_harcamalar);
            this.Controls.Add(this.lbl_harcamalar);
            this.Controls.Add(this.cmb_birim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_prjDZN);
            this.Controls.Add(this.dtp_bitis);
            this.Controls.Add(this.dtp_baslangıc);
            this.Controls.Add(this.txt_musteri);
            this.Controls.Add(this.txt_proje_no);
            this.Controls.Add(this.txt_butce);
            this.Controls.Add(this.txt_proje_adi);
            this.Controls.Add(this.rcb_aciklama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "proje_duzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje Düzenle";
            this.Load += new System.EventHandler(this.proje_duzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_birim;
        public System.Windows.Forms.Button btn_harcamalar;
        public System.Windows.Forms.Label lbl_harcamalar;
        public System.Windows.Forms.ComboBox cmb_birim;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btn_prjDZN;
        public System.Windows.Forms.DateTimePicker dtp_bitis;
        public System.Windows.Forms.DateTimePicker dtp_baslangıc;
        public System.Windows.Forms.TextBox txt_musteri;
        public System.Windows.Forms.TextBox txt_proje_no;
        public System.Windows.Forms.TextBox txt_butce;
        public System.Windows.Forms.TextBox txt_proje_adi;
        public System.Windows.Forms.RichTextBox rcb_aciklama;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txt_vade;
        public System.Windows.Forms.CheckBox ck_prj;
        public System.Windows.Forms.CheckBox ck_seri;
    }
}