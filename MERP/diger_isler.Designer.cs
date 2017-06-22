namespace MERP
{
    partial class diger_isler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diger_isler));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_bekleme = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_pasif = new System.Windows.Forms.DataGridView();
            this.btn_prj_sil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dg_biten = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dg_aktif = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bekleme)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pasif)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_biten)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_aktif)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dg_bekleme);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 117);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BEKLEMEDE İŞLER";
            // 
            // dg_bekleme
            // 
            this.dg_bekleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bekleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_bekleme.Location = new System.Drawing.Point(3, 16);
            this.dg_bekleme.Name = "dg_bekleme";
            this.dg_bekleme.Size = new System.Drawing.Size(767, 98);
            this.dg_bekleme.TabIndex = 1;
            this.dg_bekleme.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_bekleme_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dg_pasif);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PASİF İŞLER";
            // 
            // dg_pasif
            // 
            this.dg_pasif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pasif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_pasif.Location = new System.Drawing.Point(3, 16);
            this.dg_pasif.Name = "dg_pasif";
            this.dg_pasif.Size = new System.Drawing.Size(767, 86);
            this.dg_pasif.TabIndex = 0;
            this.dg_pasif.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_pasif_RowHeaderMouseClick);
            // 
            // btn_prj_sil
            // 
            this.btn_prj_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_prj_sil.BackColor = System.Drawing.Color.Red;
            this.btn_prj_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_prj_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_prj_sil.Location = new System.Drawing.Point(356, 626);
            this.btn_prj_sil.Name = "btn_prj_sil";
            this.btn_prj_sil.Size = new System.Drawing.Size(87, 36);
            this.btn_prj_sil.TabIndex = 41;
            this.btn_prj_sil.Text = "SİL";
            this.btn_prj_sil.UseVisualStyleBackColor = false;
            this.btn_prj_sil.Click += new System.EventHandler(this.btn_prj_sil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dg_biten);
            this.groupBox3.Location = new System.Drawing.Point(12, 517);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 103);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BİTEN İŞLER";
            // 
            // dg_biten
            // 
            this.dg_biten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_biten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_biten.Location = new System.Drawing.Point(3, 16);
            this.dg_biten.Name = "dg_biten";
            this.dg_biten.Size = new System.Drawing.Size(764, 84);
            this.dg_biten.TabIndex = 0;
            this.dg_biten.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_biten_RowHeaderMouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dg_aktif);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(773, 91);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AKTİF İŞLER";
            // 
            // dg_aktif
            // 
            this.dg_aktif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_aktif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_aktif.Location = new System.Drawing.Point(3, 16);
            this.dg_aktif.Name = "dg_aktif";
            this.dg_aktif.Size = new System.Drawing.Size(767, 72);
            this.dg_aktif.TabIndex = 0;
            this.dg_aktif.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_aktif_RowHeaderMouseClick);
            // 
            // diger_isler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 665);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_prj_sil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diger_isler";
            this.Text = "Diğer İşler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.diger_isler_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_bekleme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_pasif)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_biten)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_aktif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_bekleme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_pasif;
        private System.Windows.Forms.Button btn_prj_sil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_biten;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dg_aktif;
    }
}