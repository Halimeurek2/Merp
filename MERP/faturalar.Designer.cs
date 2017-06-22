namespace MERP
{
    partial class faturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faturalar));
            this.btn_ftr_sil = new System.Windows.Forms.Button();
            this.btn_ftr_duzenle = new System.Windows.Forms.Button();
            this.dgw_ftr_list = new System.Windows.Forms.DataGridView();
            this.txt_firma = new System.Windows.Forms.TextBox();
            this.txt_ftr_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.baslik = new System.Windows.Forms.Label();
            this.txt_tip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ftr_list)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ftr_sil
            // 
            this.btn_ftr_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ftr_sil.BackColor = System.Drawing.Color.Red;
            this.btn_ftr_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ftr_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ftr_sil.Location = new System.Drawing.Point(789, 661);
            this.btn_ftr_sil.Name = "btn_ftr_sil";
            this.btn_ftr_sil.Size = new System.Drawing.Size(87, 36);
            this.btn_ftr_sil.TabIndex = 17;
            this.btn_ftr_sil.Text = "SİL";
            this.btn_ftr_sil.UseVisualStyleBackColor = false;
            this.btn_ftr_sil.Click += new System.EventHandler(this.btn_ftr_sil_Click);
            // 
            // btn_ftr_duzenle
            // 
            this.btn_ftr_duzenle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ftr_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ftr_duzenle.Location = new System.Drawing.Point(461, 661);
            this.btn_ftr_duzenle.Name = "btn_ftr_duzenle";
            this.btn_ftr_duzenle.Size = new System.Drawing.Size(87, 36);
            this.btn_ftr_duzenle.TabIndex = 16;
            this.btn_ftr_duzenle.Text = "DÜZENLE";
            this.btn_ftr_duzenle.UseVisualStyleBackColor = true;
            this.btn_ftr_duzenle.Click += new System.EventHandler(this.btn_ftr_duzenle_Click);
            // 
            // dgw_ftr_list
            // 
            this.dgw_ftr_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_ftr_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ftr_list.Location = new System.Drawing.Point(16, 159);
            this.dgw_ftr_list.Name = "dgw_ftr_list";
            this.dgw_ftr_list.Size = new System.Drawing.Size(1335, 475);
            this.dgw_ftr_list.TabIndex = 15;
            this.dgw_ftr_list.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_ftr_list_RowHeaderMouseClick);
            // 
            // txt_firma
            // 
            this.txt_firma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_firma.Location = new System.Drawing.Point(597, 96);
            this.txt_firma.Name = "txt_firma";
            this.txt_firma.Size = new System.Drawing.Size(268, 22);
            this.txt_firma.TabIndex = 14;
            this.txt_firma.TextChanged += new System.EventHandler(this.txt_firma_TextChanged);
            // 
            // txt_ftr_no
            // 
            this.txt_ftr_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ftr_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ftr_no.Location = new System.Drawing.Point(270, 96);
            this.txt_ftr_no.Name = "txt_ftr_no";
            this.txt_ftr_no.Size = new System.Drawing.Size(213, 22);
            this.txt_ftr_no.TabIndex = 13;
            this.txt_ftr_no.TextChanged += new System.EventHandler(this.txt_ftr_no_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(514, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Firma Adı :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(188, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "Fatura No : ";
            // 
            // baslik
            // 
            this.baslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(614, 23);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(156, 29);
            this.baslik.TabIndex = 10;
            this.baslik.Text = "FATURALAR";
            // 
            // txt_tip
            // 
            this.txt_tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tip.Location = new System.Drawing.Point(987, 96);
            this.txt_tip.Name = "txt_tip";
            this.txt_tip.Size = new System.Drawing.Size(90, 22);
            this.txt_tip.TabIndex = 19;
            this.txt_tip.TextChanged += new System.EventHandler(this.txt_tip_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(910, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fatura Tipi :";
            // 
            // faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 707);
            this.Controls.Add(this.txt_tip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ftr_sil);
            this.Controls.Add(this.btn_ftr_duzenle);
            this.Controls.Add(this.dgw_ftr_list);
            this.Controls.Add(this.txt_firma);
            this.Controls.Add(this.txt_ftr_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.baslik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "faturalar";
            this.Text = "Faturalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.faturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ftr_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ftr_sil;
        private System.Windows.Forms.Button btn_ftr_duzenle;
        private System.Windows.Forms.DataGridView dgw_ftr_list;
        private System.Windows.Forms.TextBox txt_firma;
        private System.Windows.Forms.TextBox txt_ftr_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.TextBox txt_tip;
        private System.Windows.Forms.Label label4;
    }
}