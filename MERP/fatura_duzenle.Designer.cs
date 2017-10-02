namespace MERP
{
    partial class fatura_duzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fatura_duzenle));
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_ftr_tutar = new System.Windows.Forms.TextBox();
            this.cmb_birim = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ftr_vade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date_alarm = new System.Windows.Forms.DateTimePicker();
            this.ck_alarm = new System.Windows.Forms.CheckBox();
            this.btn_ftr_dzn = new System.Windows.Forms.Button();
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
            this.lbl_tip = new System.Windows.Forms.Label();
            this.txt_avans = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_ftr_tip = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_durum = new System.Windows.Forms.CheckBox();
            this.cmb_firma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(490, 27);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 62;
            this.lbl_id.Text = "ID";
            this.lbl_id.Visible = false;
            // 
            // txt_ftr_tutar
            // 
            this.txt_ftr_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ftr_tutar.Location = new System.Drawing.Point(105, 192);
            this.txt_ftr_tutar.Name = "txt_ftr_tutar";
            this.txt_ftr_tutar.Size = new System.Drawing.Size(157, 22);
            this.txt_ftr_tutar.TabIndex = 61;
            // 
            // cmb_birim
            // 
            this.cmb_birim.FormattingEnabled = true;
            this.cmb_birim.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "TRY",
            "CHF"});
            this.cmb_birim.Location = new System.Drawing.Point(366, 196);
            this.cmb_birim.Name = "cmb_birim";
            this.cmb_birim.Size = new System.Drawing.Size(187, 21);
            this.cmb_birim.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(313, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Birim : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Fatura Tutarı : ";
            // 
            // txt_ftr_vade
            // 
            this.txt_ftr_vade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ftr_vade.Location = new System.Drawing.Point(104, 154);
            this.txt_ftr_vade.Name = "txt_ftr_vade";
            this.txt_ftr_vade.Size = new System.Drawing.Size(158, 22);
            this.txt_ftr_vade.TabIndex = 57;
            this.txt_ftr_vade.TextChanged += new System.EventHandler(this.txt_ftr_vade_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Vade : ";
            // 
            // date_alarm
            // 
            this.date_alarm.Location = new System.Drawing.Point(271, 156);
            this.date_alarm.Name = "date_alarm";
            this.date_alarm.Size = new System.Drawing.Size(196, 20);
            this.date_alarm.TabIndex = 55;
            // 
            // ck_alarm
            // 
            this.ck_alarm.AutoSize = true;
            this.ck_alarm.Location = new System.Drawing.Point(490, 157);
            this.ck_alarm.Name = "ck_alarm";
            this.ck_alarm.Size = new System.Drawing.Size(63, 17);
            this.ck_alarm.TabIndex = 54;
            this.ck_alarm.Text = "ALARM";
            this.ck_alarm.UseVisualStyleBackColor = true;
            // 
            // btn_ftr_dzn
            // 
            this.btn_ftr_dzn.Location = new System.Drawing.Point(447, 299);
            this.btn_ftr_dzn.Name = "btn_ftr_dzn";
            this.btn_ftr_dzn.Size = new System.Drawing.Size(106, 48);
            this.btn_ftr_dzn.TabIndex = 53;
            this.btn_ftr_dzn.Text = "DUZENLE";
            this.btn_ftr_dzn.UseVisualStyleBackColor = true;
            this.btn_ftr_dzn.Click += new System.EventHandler(this.btn_ftr_dzn_Click);
            // 
            // txt_ftr_tarih
            // 
            this.txt_ftr_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ftr_tarih.Location = new System.Drawing.Point(366, 117);
            this.txt_ftr_tarih.Name = "txt_ftr_tarih";
            this.txt_ftr_tarih.Size = new System.Drawing.Size(187, 22);
            this.txt_ftr_tarih.TabIndex = 52;
            // 
            // txt_fatura_no
            // 
            this.txt_fatura_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fatura_no.Location = new System.Drawing.Point(104, 116);
            this.txt_fatura_no.Name = "txt_fatura_no";
            this.txt_fatura_no.Size = new System.Drawing.Size(158, 22);
            this.txt_fatura_no.TabIndex = 50;
            // 
            // cmb_projeNo
            // 
            this.cmb_projeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_projeNo.FormattingEnabled = true;
            this.cmb_projeNo.Location = new System.Drawing.Point(105, 76);
            this.cmb_projeNo.Name = "cmb_projeNo";
            this.cmb_projeNo.Size = new System.Drawing.Size(157, 24);
            this.cmb_projeNo.TabIndex = 49;
            // 
            // rcb_acıklama
            // 
            this.rcb_acıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcb_acıklama.Location = new System.Drawing.Point(122, 267);
            this.rcb_acıklama.Name = "rcb_acıklama";
            this.rcb_acıklama.Size = new System.Drawing.Size(313, 80);
            this.rcb_acıklama.TabIndex = 48;
            this.rcb_acıklama.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Açıklama : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(268, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Fatura Tarihi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(268, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Firma İsmi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Fatura No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Proje No : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(173, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "FATURA DÜZENLE";
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Location = new System.Drawing.Point(487, 43);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(22, 13);
            this.lbl_tip.TabIndex = 63;
            this.lbl_tip.Text = "Tip";
            this.lbl_tip.Visible = false;
            // 
            // txt_avans
            // 
            this.txt_avans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_avans.Location = new System.Drawing.Point(105, 230);
            this.txt_avans.Name = "txt_avans";
            this.txt_avans.Size = new System.Drawing.Size(157, 22);
            this.txt_avans.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 64;
            this.label10.Text = "Fatura Avans : ";
            // 
            // cmb_ftr_tip
            // 
            this.cmb_ftr_tip.FormattingEnabled = true;
            this.cmb_ftr_tip.Items.AddRange(new object[] {
            "Mekanik",
            "Elektronik",
            "Genel Giderler"});
            this.cmb_ftr_tip.Location = new System.Drawing.Point(366, 230);
            this.cmb_ftr_tip.Name = "cmb_ftr_tip";
            this.cmb_ftr_tip.Size = new System.Drawing.Size(187, 21);
            this.cmb_ftr_tip.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(268, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 66;
            this.label11.Text = "Fatura Tipi : ";
            // 
            // cb_durum
            // 
            this.cb_durum.AutoSize = true;
            this.cb_durum.Location = new System.Drawing.Point(16, 43);
            this.cb_durum.Name = "cb_durum";
            this.cb_durum.Size = new System.Drawing.Size(68, 17);
            this.cb_durum.TabIndex = 68;
            this.cb_durum.Text = "ÖDENDİ";
            this.cb_durum.UseVisualStyleBackColor = true;
            // 
            // cmb_firma
            // 
            this.cmb_firma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_firma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_firma.FormattingEnabled = true;
            this.cmb_firma.Location = new System.Drawing.Point(366, 76);
            this.cmb_firma.Name = "cmb_firma";
            this.cmb_firma.Size = new System.Drawing.Size(187, 21);
            this.cmb_firma.TabIndex = 69;
            // 
            // fatura_duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 360);
            this.Controls.Add(this.cmb_firma);
            this.Controls.Add(this.cb_durum);
            this.Controls.Add(this.cmb_ftr_tip);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_avans);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_ftr_tutar);
            this.Controls.Add(this.cmb_birim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ftr_vade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_alarm);
            this.Controls.Add(this.ck_alarm);
            this.Controls.Add(this.btn_ftr_dzn);
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
            this.Name = "fatura_duzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Düzenle";
            this.Load += new System.EventHandler(this.fatura_duzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.TextBox txt_ftr_tutar;
        public System.Windows.Forms.ComboBox cmb_birim;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_ftr_vade;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker date_alarm;
        public System.Windows.Forms.CheckBox ck_alarm;
        public System.Windows.Forms.Button btn_ftr_dzn;
        public System.Windows.Forms.TextBox txt_ftr_tarih;
        public System.Windows.Forms.TextBox txt_fatura_no;
        public System.Windows.Forms.ComboBox cmb_projeNo;
        public System.Windows.Forms.RichTextBox rcb_acıklama;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_tip;
        public System.Windows.Forms.TextBox txt_avans;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmb_ftr_tip;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.CheckBox cb_durum;
        public System.Windows.Forms.ComboBox cmb_firma;
    }
}