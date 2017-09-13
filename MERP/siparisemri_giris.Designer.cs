namespace MERP
{
    partial class siparisemri_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisemri_giris));
            this.cmb_paraBirimi = new System.Windows.Forms.ComboBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_talepKisi = new System.Windows.Forms.TextBox();
            this.txt_siparisNo = new System.Windows.Forms.TextBox();
            this.txt_tedarikci = new System.Windows.Forms.TextBox();
            this.cmb_prjno = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_mlz_brmFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_temin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_vade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rcb_aciklama = new System.Windows.Forms.RichTextBox();
            this.date_teslim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_paraBirimi
            // 
            this.cmb_paraBirimi.FormattingEnabled = true;
            this.cmb_paraBirimi.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "CHF",
            "TRY"});
            this.cmb_paraBirimi.Location = new System.Drawing.Point(421, 237);
            this.cmb_paraBirimi.Name = "cmb_paraBirimi";
            this.cmb_paraBirimi.Size = new System.Drawing.Size(128, 21);
            this.cmb_paraBirimi.TabIndex = 21;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(612, 311);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(123, 39);
            this.btn_kayit.TabIndex = 15;
            this.btn_kayit.Text = "KAYDET";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_stf_kayit_Click);
            // 
            // txt_talepKisi
            // 
            this.txt_talepKisi.Location = new System.Drawing.Point(475, 146);
            this.txt_talepKisi.Name = "txt_talepKisi";
            this.txt_talepKisi.Size = new System.Drawing.Size(205, 20);
            this.txt_talepKisi.TabIndex = 12;
            // 
            // txt_siparisNo
            // 
            this.txt_siparisNo.Location = new System.Drawing.Point(475, 100);
            this.txt_siparisNo.Name = "txt_siparisNo";
            this.txt_siparisNo.Size = new System.Drawing.Size(205, 20);
            this.txt_siparisNo.TabIndex = 11;
            // 
            // txt_tedarikci
            // 
            this.txt_tedarikci.Location = new System.Drawing.Point(123, 149);
            this.txt_tedarikci.Name = "txt_tedarikci";
            this.txt_tedarikci.Size = new System.Drawing.Size(205, 20);
            this.txt_tedarikci.TabIndex = 8;
            // 
            // cmb_prjno
            // 
            this.cmb_prjno.FormattingEnabled = true;
            this.cmb_prjno.Location = new System.Drawing.Point(123, 103);
            this.cmb_prjno.Name = "cmb_prjno";
            this.cmb_prjno.Size = new System.Drawing.Size(205, 21);
            this.cmb_prjno.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SİPARİŞİ OLUŞTURAN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROJE NO : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SATINALMA SİPARİŞ NO : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TEDARİKÇİ : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "SİPARİŞ EMRİ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(334, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "PARA BİRİMİ : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "FİYAT : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "SİPARİŞ TARİHİ : ";
            // 
            // txt_mlz_brmFiyat
            // 
            this.txt_mlz_brmFiyat.Location = new System.Drawing.Point(123, 238);
            this.txt_mlz_brmFiyat.Name = "txt_mlz_brmFiyat";
            this.txt_mlz_brmFiyat.Size = new System.Drawing.Size(205, 20);
            this.txt_mlz_brmFiyat.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "TEMİN TARİHİ : ";
            // 
            // date_temin
            // 
            this.date_temin.Location = new System.Drawing.Point(475, 193);
            this.date_temin.Name = "date_temin";
            this.date_temin.Size = new System.Drawing.Size(205, 20);
            this.date_temin.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "VADE : ";
            // 
            // txt_vade
            // 
            this.txt_vade.Location = new System.Drawing.Point(621, 239);
            this.txt_vade.Name = "txt_vade";
            this.txt_vade.Size = new System.Drawing.Size(99, 20);
            this.txt_vade.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "ACIKLAMA : ";
            // 
            // rcb_aciklama
            // 
            this.rcb_aciklama.Location = new System.Drawing.Point(109, 285);
            this.rcb_aciklama.Name = "rcb_aciklama";
            this.rcb_aciklama.Size = new System.Drawing.Size(490, 80);
            this.rcb_aciklama.TabIndex = 28;
            this.rcb_aciklama.Text = "";
            // 
            // date_teslim
            // 
            this.date_teslim.Location = new System.Drawing.Point(123, 192);
            this.date_teslim.Name = "date_teslim";
            this.date_teslim.Size = new System.Drawing.Size(205, 20);
            this.date_teslim.TabIndex = 29;
            // 
            // siparisemri_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 381);
            this.Controls.Add(this.date_teslim);
            this.Controls.Add(this.rcb_aciklama);
            this.Controls.Add(this.txt_talepKisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.txt_vade);
            this.Controls.Add(this.txt_siparisNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tedarikci);
            this.Controls.Add(this.date_temin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_prjno);
            this.Controls.Add(this.txt_mlz_brmFiyat);
            this.Controls.Add(this.cmb_paraBirimi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "siparisemri_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Emri Giriş";
            this.Load += new System.EventHandler(this.satinalma_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_paraBirimi;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox txt_talepKisi;
        private System.Windows.Forms.TextBox txt_siparisNo;
        private System.Windows.Forms.TextBox txt_tedarikci;
        private System.Windows.Forms.ComboBox cmb_prjno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_mlz_brmFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_temin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_vade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rcb_aciklama;
        private System.Windows.Forms.TextBox date_teslim;
    }
}