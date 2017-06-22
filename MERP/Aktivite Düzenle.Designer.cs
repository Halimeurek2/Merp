namespace MERP
{
    partial class Aktivite_Düzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aktivite_Düzenle));
            this.lbl_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.date_olusturma = new System.Windows.Forms.DateTimePicker();
            this.cmb_rapor_edilecek = new System.Windows.Forms.ComboBox();
            this.rcb_acıklama = new System.Windows.Forms.RichTextBox();
            this.cmb_statu = new System.Windows.Forms.ComboBox();
            this.cmb_oncelik = new System.Windows.Forms.ComboBox();
            this.cmb_prj_no = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.date_bitis = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(478, 31);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 56;
            this.lbl_id.Text = "ID";
            this.lbl_id.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(127, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 29);
            this.label8.TabIndex = 55;
            this.label8.Text = "AKTİVİTE DÜZENLE";
            // 
            // date_olusturma
            // 
            this.date_olusturma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_olusturma.Location = new System.Drawing.Point(184, 470);
            this.date_olusturma.Name = "date_olusturma";
            this.date_olusturma.Size = new System.Drawing.Size(241, 22);
            this.date_olusturma.TabIndex = 54;
            // 
            // cmb_rapor_edilecek
            // 
            this.cmb_rapor_edilecek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_rapor_edilecek.FormattingEnabled = true;
            this.cmb_rapor_edilecek.Items.AddRange(new object[] {
            "M. Emin İLKMEN",
            "Z. Burak MERCAN",
            "Kemal BERKKAN",
            "MÜŞTERİ"});
            this.cmb_rapor_edilecek.Location = new System.Drawing.Point(184, 411);
            this.cmb_rapor_edilecek.Name = "cmb_rapor_edilecek";
            this.cmb_rapor_edilecek.Size = new System.Drawing.Size(241, 27);
            this.cmb_rapor_edilecek.TabIndex = 53;
            // 
            // rcb_acıklama
            // 
            this.rcb_acıklama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcb_acıklama.Location = new System.Drawing.Point(184, 247);
            this.rcb_acıklama.Name = "rcb_acıklama";
            this.rcb_acıklama.Size = new System.Drawing.Size(348, 145);
            this.rcb_acıklama.TabIndex = 52;
            this.rcb_acıklama.Text = "";
            // 
            // cmb_statu
            // 
            this.cmb_statu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_statu.FormattingEnabled = true;
            this.cmb_statu.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF",
            "BİTTİ",
            "BEKLEMEDE"});
            this.cmb_statu.Location = new System.Drawing.Point(184, 187);
            this.cmb_statu.Name = "cmb_statu";
            this.cmb_statu.Size = new System.Drawing.Size(241, 27);
            this.cmb_statu.TabIndex = 51;
            // 
            // cmb_oncelik
            // 
            this.cmb_oncelik.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_oncelik.FormattingEnabled = true;
            this.cmb_oncelik.Items.AddRange(new object[] {
            "ÇOK ACİL",
            "ACİL",
            "NORMAL",
            "BİR ARA YAPARSIN"});
            this.cmb_oncelik.Location = new System.Drawing.Point(184, 135);
            this.cmb_oncelik.Name = "cmb_oncelik";
            this.cmb_oncelik.Size = new System.Drawing.Size(241, 27);
            this.cmb_oncelik.TabIndex = 50;
            // 
            // cmb_prj_no
            // 
            this.cmb_prj_no.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_prj_no.FormattingEnabled = true;
            this.cmb_prj_no.Location = new System.Drawing.Point(184, 83);
            this.cmb_prj_no.Name = "cmb_prj_no";
            this.cmb_prj_no.Size = new System.Drawing.Size(241, 27);
            this.cmb_prj_no.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Oluşturulan Tarih : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Rapor Edilecek : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Açıklama : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Statu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Öncelik :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Proje No :";
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_duzenle.Location = new System.Drawing.Point(239, 573);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(74, 46);
            this.btn_duzenle.TabIndex = 59;
            this.btn_duzenle.Text = "DÜZENLE";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // date_bitis
            // 
            this.date_bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_bitis.Location = new System.Drawing.Point(184, 524);
            this.date_bitis.Name = "date_bitis";
            this.date_bitis.Size = new System.Drawing.Size(241, 22);
            this.date_bitis.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 57;
            this.label7.Text = "Bitiş Tarih :";
            // 
            // Aktivite_Düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 625);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.date_bitis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.date_olusturma);
            this.Controls.Add(this.cmb_rapor_edilecek);
            this.Controls.Add(this.rcb_acıklama);
            this.Controls.Add(this.cmb_statu);
            this.Controls.Add(this.cmb_oncelik);
            this.Controls.Add(this.cmb_prj_no);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aktivite_Düzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktivite Düzenle";
            this.Load += new System.EventHandler(this.Aktivite_Düzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_olusturma;
        private System.Windows.Forms.ComboBox cmb_rapor_edilecek;
        private System.Windows.Forms.RichTextBox rcb_acıklama;
        private System.Windows.Forms.ComboBox cmb_statu;
        private System.Windows.Forms.ComboBox cmb_oncelik;
        private System.Windows.Forms.ComboBox cmb_prj_no;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.DateTimePicker date_bitis;
        private System.Windows.Forms.Label label7;
    }
}