namespace MERP
{
    partial class kesilen_fatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kesilen_fatura));
            this.txt_ftr_tutar = new System.Windows.Forms.TextBox();
            this.cmb_birim = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ftr_vade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date_alarm = new System.Windows.Forms.DateTimePicker();
            this.ck_alarm = new System.Windows.Forms.CheckBox();
            this.btn_ftr_ekle = new System.Windows.Forms.Button();
            this.txt_ftr_tarih = new System.Windows.Forms.TextBox();
            this.txt_fatura_no = new System.Windows.Forms.TextBox();
            this.cmb_projeNo = new System.Windows.Forms.ComboBox();
            this.rcb_acıklama = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_avans = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_ftr_tip = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_durum = new System.Windows.Forms.CheckBox();
            this.cmb_firma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_ftr_tutar
            // 
            this.txt_ftr_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ftr_tutar.Location = new System.Drawing.Point(106, 192);
            this.txt_ftr_tutar.Name = "txt_ftr_tutar";
            this.txt_ftr_tutar.Size = new System.Drawing.Size(157, 22);
            this.txt_ftr_tutar.TabIndex = 60;
            // 
            // cmb_birim
            // 
            this.cmb_birim.FormattingEnabled = true;
            this.cmb_birim.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "TRY",
            "CHF"});
            this.cmb_birim.Location = new System.Drawing.Point(367, 189);
            this.cmb_birim.Name = "cmb_birim";
            this.cmb_birim.Size = new System.Drawing.Size(187, 21);
            this.cmb_birim.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(305, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Birim : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fatura Tutarı : ";
            // 
            // txt_ftr_vade
            // 
            this.txt_ftr_vade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ftr_vade.Location = new System.Drawing.Point(105, 154);
            this.txt_ftr_vade.Name = "txt_ftr_vade";
            this.txt_ftr_vade.Size = new System.Drawing.Size(158, 22);
            this.txt_ftr_vade.TabIndex = 56;
            this.txt_ftr_vade.TextChanged += new System.EventHandler(this.txt_ftr_vade_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Vade : ";
            // 
            // date_alarm
            // 
            this.date_alarm.Location = new System.Drawing.Point(272, 157);
            this.date_alarm.Name = "date_alarm";
            this.date_alarm.Size = new System.Drawing.Size(196, 20);
            this.date_alarm.TabIndex = 54;
            // 
            // ck_alarm
            // 
            this.ck_alarm.AutoSize = true;
            this.ck_alarm.Location = new System.Drawing.Point(491, 155);
            this.ck_alarm.Name = "ck_alarm";
            this.ck_alarm.Size = new System.Drawing.Size(63, 17);
            this.ck_alarm.TabIndex = 53;
            this.ck_alarm.Text = "ALARM";
            this.ck_alarm.UseVisualStyleBackColor = true;
            // 
            // btn_ftr_ekle
            // 
            this.btn_ftr_ekle.Location = new System.Drawing.Point(448, 299);
            this.btn_ftr_ekle.Name = "btn_ftr_ekle";
            this.btn_ftr_ekle.Size = new System.Drawing.Size(106, 48);
            this.btn_ftr_ekle.TabIndex = 52;
            this.btn_ftr_ekle.Text = "KAYDET";
            this.btn_ftr_ekle.UseVisualStyleBackColor = true;
            this.btn_ftr_ekle.Click += new System.EventHandler(this.btn_ftr_ekle_Click);
            // 
            // txt_ftr_tarih
            // 
            this.txt_ftr_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ftr_tarih.Location = new System.Drawing.Point(367, 117);
            this.txt_ftr_tarih.Name = "txt_ftr_tarih";
            this.txt_ftr_tarih.Size = new System.Drawing.Size(187, 22);
            this.txt_ftr_tarih.TabIndex = 51;
            // 
            // txt_fatura_no
            // 
            this.txt_fatura_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fatura_no.Location = new System.Drawing.Point(105, 116);
            this.txt_fatura_no.Name = "txt_fatura_no";
            this.txt_fatura_no.Size = new System.Drawing.Size(158, 22);
            this.txt_fatura_no.TabIndex = 49;
            // 
            // cmb_projeNo
            // 
            this.cmb_projeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_projeNo.FormattingEnabled = true;
            this.cmb_projeNo.Location = new System.Drawing.Point(106, 76);
            this.cmb_projeNo.Name = "cmb_projeNo";
            this.cmb_projeNo.Size = new System.Drawing.Size(157, 24);
            this.cmb_projeNo.TabIndex = 48;
            // 
            // rcb_acıklama
            // 
            this.rcb_acıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcb_acıklama.Location = new System.Drawing.Point(106, 270);
            this.rcb_acıklama.Name = "rcb_acıklama";
            this.rcb_acıklama.Size = new System.Drawing.Size(331, 77);
            this.rcb_acıklama.TabIndex = 47;
            this.rcb_acıklama.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Açıklama : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(269, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Fatura Tarihi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(269, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Firma İsmi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Fatura No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Proje No : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "KESİLEN FATURALAR";
            // 
            // txt_avans
            // 
            this.txt_avans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_avans.Location = new System.Drawing.Point(106, 234);
            this.txt_avans.Name = "txt_avans";
            this.txt_avans.Size = new System.Drawing.Size(157, 22);
            this.txt_avans.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(14, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "Fatura Avans : ";
            // 
            // cmb_ftr_tip
            // 
            this.cmb_ftr_tip.FormattingEnabled = true;
            this.cmb_ftr_tip.Items.AddRange(new object[] {
            "Mekanik",
            "Elektronik",
            "Genel Giderler"});
            this.cmb_ftr_tip.Location = new System.Drawing.Point(367, 235);
            this.cmb_ftr_tip.Name = "cmb_ftr_tip";
            this.cmb_ftr_tip.Size = new System.Drawing.Size(187, 21);
            this.cmb_ftr_tip.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(269, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Fatura Tipi : ";
            // 
            // cb_durum
            // 
            this.cb_durum.AutoSize = true;
            this.cb_durum.Location = new System.Drawing.Point(17, 45);
            this.cb_durum.Name = "cb_durum";
            this.cb_durum.Size = new System.Drawing.Size(68, 17);
            this.cb_durum.TabIndex = 65;
            this.cb_durum.Text = "ÖDENDİ";
            this.cb_durum.UseVisualStyleBackColor = true;
            // 
            // cmb_firma
            // 
            this.cmb_firma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_firma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_firma.FormattingEnabled = true;
            this.cmb_firma.Location = new System.Drawing.Point(367, 76);
            this.cmb_firma.Name = "cmb_firma";
            this.cmb_firma.Size = new System.Drawing.Size(187, 21);
            this.cmb_firma.TabIndex = 68;
            // 
            // kesilen_fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 357);
            this.Controls.Add(this.cmb_firma);
            this.Controls.Add(this.cb_durum);
            this.Controls.Add(this.cmb_ftr_tip);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_avans);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_ftr_tutar);
            this.Controls.Add(this.cmb_birim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ftr_vade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_alarm);
            this.Controls.Add(this.ck_alarm);
            this.Controls.Add(this.btn_ftr_ekle);
            this.Controls.Add(this.txt_ftr_tarih);
            this.Controls.Add(this.txt_fatura_no);
            this.Controls.Add(this.cmb_projeNo);
            this.Controls.Add(this.rcb_acıklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kesilen_fatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Giriş";
            this.Load += new System.EventHandler(this.kesilen_fatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ftr_tutar;
        private System.Windows.Forms.ComboBox cmb_birim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ftr_vade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_alarm;
        private System.Windows.Forms.CheckBox ck_alarm;
        private System.Windows.Forms.Button btn_ftr_ekle;
        private System.Windows.Forms.TextBox txt_ftr_tarih;
        private System.Windows.Forms.TextBox txt_fatura_no;
        private System.Windows.Forms.ComboBox cmb_projeNo;
        private System.Windows.Forms.RichTextBox rcb_acıklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_avans;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmb_ftr_tip;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.CheckBox cb_durum;
        public System.Windows.Forms.ComboBox cmb_firma;
    }
}