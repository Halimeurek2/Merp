namespace MERP
{
    partial class siparisemri_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisemri_list));
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tedarikci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_projeNo = new System.Windows.Forms.ComboBox();
            this.btn_ftr_sil = new System.Windows.Forms.Button();
            this.btn_ftr_duzenle = new System.Windows.Forms.Button();
            this.dgw_stf_list = new System.Windows.Forms.DataGridView();
            this.txt_satınalma_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_stf_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(516, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "SATINALMA TALEP FORMU";
            // 
            // txt_tedarikci
            // 
            this.txt_tedarikci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tedarikci.Location = new System.Drawing.Point(1004, 100);
            this.txt_tedarikci.Name = "txt_tedarikci";
            this.txt_tedarikci.Size = new System.Drawing.Size(268, 22);
            this.txt_tedarikci.TabIndex = 31;
            this.txt_tedarikci.TextChanged += new System.EventHandler(this.txt_tedarikci_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(903, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tedarikçi : ";
            // 
            // cmb_projeNo
            // 
            this.cmb_projeNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_projeNo.FormattingEnabled = true;
            this.cmb_projeNo.Location = new System.Drawing.Point(222, 102);
            this.cmb_projeNo.Name = "cmb_projeNo";
            this.cmb_projeNo.Size = new System.Drawing.Size(143, 21);
            this.cmb_projeNo.TabIndex = 29;
            this.cmb_projeNo.SelectedIndexChanged += new System.EventHandler(this.cmb_projeNo_SelectedIndexChanged);
            // 
            // btn_ftr_sil
            // 
            this.btn_ftr_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ftr_sil.BackColor = System.Drawing.Color.Red;
            this.btn_ftr_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ftr_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ftr_sil.Location = new System.Drawing.Point(841, 615);
            this.btn_ftr_sil.Name = "btn_ftr_sil";
            this.btn_ftr_sil.Size = new System.Drawing.Size(87, 36);
            this.btn_ftr_sil.TabIndex = 28;
            this.btn_ftr_sil.Text = "SİL";
            this.btn_ftr_sil.UseVisualStyleBackColor = false;
            this.btn_ftr_sil.Click += new System.EventHandler(this.btn_ftr_sil_Click);
            // 
            // btn_ftr_duzenle
            // 
            this.btn_ftr_duzenle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ftr_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ftr_duzenle.Location = new System.Drawing.Point(437, 615);
            this.btn_ftr_duzenle.Name = "btn_ftr_duzenle";
            this.btn_ftr_duzenle.Size = new System.Drawing.Size(87, 36);
            this.btn_ftr_duzenle.TabIndex = 27;
            this.btn_ftr_duzenle.Text = "DÜZENLE";
            this.btn_ftr_duzenle.UseVisualStyleBackColor = true;
            this.btn_ftr_duzenle.Click += new System.EventHandler(this.btn_ftr_duzenle_Click);
            // 
            // dgw_stf_list
            // 
            this.dgw_stf_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_stf_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_stf_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_stf_list.Location = new System.Drawing.Point(15, 152);
            this.dgw_stf_list.Name = "dgw_stf_list";
            this.dgw_stf_list.Size = new System.Drawing.Size(1335, 447);
            this.dgw_stf_list.TabIndex = 26;
            this.dgw_stf_list.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_stf_list_RowHeaderMouseClick);
            // 
            // txt_satınalma_no
            // 
            this.txt_satınalma_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_satınalma_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_satınalma_no.Location = new System.Drawing.Point(563, 102);
            this.txt_satınalma_no.Name = "txt_satınalma_no";
            this.txt_satınalma_no.Size = new System.Drawing.Size(268, 22);
            this.txt_satınalma_no.TabIndex = 25;
            this.txt_satınalma_no.TextChanged += new System.EventHandler(this.txt_stf_marka_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(434, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Satın Alma No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(126, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Proje No : ";
            // 
            // siparisemri_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 676);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tedarikci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_projeNo);
            this.Controls.Add(this.btn_ftr_sil);
            this.Controls.Add(this.btn_ftr_duzenle);
            this.Controls.Add(this.dgw_stf_list);
            this.Controls.Add(this.txt_satınalma_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "siparisemri_list";
            this.Text = "Satın Alma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.satinalma_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_stf_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tedarikci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_projeNo;
        private System.Windows.Forms.Button btn_ftr_sil;
        private System.Windows.Forms.Button btn_ftr_duzenle;
        private System.Windows.Forms.DataGridView dgw_stf_list;
        private System.Windows.Forms.TextBox txt_satınalma_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}