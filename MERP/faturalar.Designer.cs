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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ftr_list)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ftr_sil
            // 
            this.btn_ftr_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ftr_sil.BackColor = System.Drawing.Color.Red;
            this.btn_ftr_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ftr_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ftr_sil.Location = new System.Drawing.Point(724, 668);
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
            this.btn_ftr_duzenle.Location = new System.Drawing.Point(533, 668);
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
            this.tableLayoutPanel1.SetColumnSpan(this.dgw_ftr_list, 9);
            this.dgw_ftr_list.Location = new System.Drawing.Point(3, 154);
            this.dgw_ftr_list.Name = "dgw_ftr_list";
            this.dgw_ftr_list.Size = new System.Drawing.Size(1356, 487);
            this.dgw_ftr_list.TabIndex = 15;
            this.dgw_ftr_list.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_ftr_list_RowHeaderMouseClick);
            // 
            // txt_firma
            // 
            this.txt_firma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_firma.Location = new System.Drawing.Point(131, 96);
            this.txt_firma.Name = "txt_firma";
            this.txt_firma.Size = new System.Drawing.Size(248, 22);
            this.txt_firma.TabIndex = 14;
            this.txt_firma.TextChanged += new System.EventHandler(this.txt_firma_TextChanged);
            // 
            // txt_ftr_no
            // 
            this.txt_ftr_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ftr_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ftr_no.Location = new System.Drawing.Point(648, 96);
            this.txt_ftr_no.Name = "txt_ftr_no";
            this.txt_ftr_no.Size = new System.Drawing.Size(239, 22);
            this.txt_ftr_no.TabIndex = 13;
            this.txt_ftr_no.TextChanged += new System.EventHandler(this.txt_ftr_no_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Firma Adı :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(512, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "Fatura No : ";
            // 
            // baslik
            // 
            this.baslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baslik.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.baslik, 8);
            this.baslik.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(641, 0);
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
            this.txt_tip.Location = new System.Drawing.Point(1116, 96);
            this.txt_tip.Name = "txt_tip";
            this.txt_tip.Size = new System.Drawing.Size(243, 22);
            this.txt_tip.TabIndex = 19;
            this.txt_tip.TextChanged += new System.EventHandler(this.txt_tip_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1003, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fatura Tipi :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.Controls.Add(this.baslik, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_ftr_sil, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_firma, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgw_ftr_list, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_tip, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_ftr_no, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label22, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_ftr_duzenle, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.12782F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1362, 707);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "faturalar";
            this.Text = "Faturalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.faturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ftr_list)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}