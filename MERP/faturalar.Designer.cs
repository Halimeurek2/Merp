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
            this.txt_firma = new System.Windows.Forms.TextBox();
            this.txt_ftr_no = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tip = new System.Windows.Forms.TextBox();
            this.dgw_ftr_list = new System.Windows.Forms.DataGridView();
            this.baslik = new System.Windows.Forms.Label();
            this.btn_ftr_duzenle = new System.Windows.Forms.Button();
            this.btn_ftr_sil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ftr_list)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_firma
            // 
            this.txt_firma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_firma.Location = new System.Drawing.Point(203, 43);
            this.txt_firma.Name = "txt_firma";
            this.txt_firma.Size = new System.Drawing.Size(241, 22);
            this.txt_firma.TabIndex = 14;
            this.txt_firma.TextChanged += new System.EventHandler(this.txt_firma_TextChanged);
            // 
            // txt_ftr_no
            // 
            this.txt_ftr_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ftr_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ftr_no.Location = new System.Drawing.Point(149, 43);
            this.txt_ftr_no.Name = "txt_ftr_no";
            this.txt_ftr_no.Size = new System.Drawing.Size(241, 22);
            this.txt_ftr_no.TabIndex = 13;
            this.txt_ftr_no.TextChanged += new System.EventHandler(this.txt_ftr_no_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(36, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "Fatura No : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Toplam :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Firma Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fatura Tipi :";
            // 
            // txt_tip
            // 
            this.txt_tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tip.Location = new System.Drawing.Point(190, 43);
            this.txt_tip.Name = "txt_tip";
            this.txt_tip.Size = new System.Drawing.Size(241, 22);
            this.txt_tip.TabIndex = 19;
            this.txt_tip.TextChanged += new System.EventHandler(this.txt_tip_TextChanged);
            // 
            // dgw_ftr_list
            // 
            this.dgw_ftr_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ftr_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_ftr_list.Location = new System.Drawing.Point(0, 0);
            this.dgw_ftr_list.Name = "dgw_ftr_list";
            this.dgw_ftr_list.Size = new System.Drawing.Size(1302, 404);
            this.dgw_ftr_list.TabIndex = 15;
            this.dgw_ftr_list.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_ftr_list_RowHeaderMouseClick);
            // 
            // baslik
            // 
            this.baslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(565, 7);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(156, 29);
            this.baslik.TabIndex = 10;
            this.baslik.Text = "FATURALAR";
            // 
            // btn_ftr_duzenle
            // 
            this.btn_ftr_duzenle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ftr_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ftr_duzenle.Location = new System.Drawing.Point(286, 8);
            this.btn_ftr_duzenle.Name = "btn_ftr_duzenle";
            this.btn_ftr_duzenle.Size = new System.Drawing.Size(87, 36);
            this.btn_ftr_duzenle.TabIndex = 29;
            this.btn_ftr_duzenle.Text = "DÜZENLE";
            this.btn_ftr_duzenle.UseVisualStyleBackColor = true;
            // 
            // btn_ftr_sil
            // 
            this.btn_ftr_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ftr_sil.BackColor = System.Drawing.Color.Red;
            this.btn_ftr_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ftr_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ftr_sil.Location = new System.Drawing.Point(281, 8);
            this.btn_ftr_sil.Name = "btn_ftr_sil";
            this.btn_ftr_sil.Size = new System.Drawing.Size(87, 36);
            this.btn_ftr_sil.TabIndex = 30;
            this.btn_ftr_sil.Text = "SİL";
            this.btn_ftr_sil.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.baslik);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 154);
            this.panel1.TabIndex = 31;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_tip);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1302, 100);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.TabIndex = 20;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txt_firma);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txt_ftr_no);
            this.splitContainer2.Panel2.Controls.Add(this.label22);
            this.splitContainer2.Size = new System.Drawing.Size(864, 100);
            this.splitContainer2.SplitterDistance = 447;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer3.Location = new System.Drawing.Point(0, 558);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btn_ftr_duzenle);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btn_ftr_sil);
            this.splitContainer3.Size = new System.Drawing.Size(1302, 50);
            this.splitContainer3.SplitterDistance = 652;
            this.splitContainer3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgw_ftr_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1302, 404);
            this.panel2.TabIndex = 33;
            // 
            // faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "faturalar";
            this.Text = "Faturalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.faturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ftr_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_firma;
        private System.Windows.Forms.TextBox txt_ftr_no;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tip;
        private System.Windows.Forms.DataGridView dgw_ftr_list;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Button btn_ftr_duzenle;
        private System.Windows.Forms.Button btn_ftr_sil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel2;
    }
}