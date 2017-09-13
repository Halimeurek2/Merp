namespace MERP
{
    partial class proje_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proje_list));
            this.btn_prj_sil = new System.Windows.Forms.Button();
            this.btn_prj_duzenle = new System.Windows.Forms.Button();
            this.dgw_prj_list = new System.Windows.Forms.DataGridView();
            this.txt_prjAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_projeNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_prj_list)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_prj_sil
            // 
            this.btn_prj_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_prj_sil.BackColor = System.Drawing.Color.Red;
            this.btn_prj_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_prj_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_prj_sil.Location = new System.Drawing.Point(745, 11);
            this.btn_prj_sil.Name = "btn_prj_sil";
            this.btn_prj_sil.Size = new System.Drawing.Size(87, 36);
            this.btn_prj_sil.TabIndex = 39;
            this.btn_prj_sil.Text = "SİL";
            this.btn_prj_sil.UseVisualStyleBackColor = false;
            this.btn_prj_sil.Click += new System.EventHandler(this.btn_prj_sil_Click);
            // 
            // btn_prj_duzenle
            // 
            this.btn_prj_duzenle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_prj_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_prj_duzenle.Location = new System.Drawing.Point(529, 11);
            this.btn_prj_duzenle.Name = "btn_prj_duzenle";
            this.btn_prj_duzenle.Size = new System.Drawing.Size(87, 36);
            this.btn_prj_duzenle.TabIndex = 38;
            this.btn_prj_duzenle.Text = "DÜZENLE";
            this.btn_prj_duzenle.UseVisualStyleBackColor = true;
            this.btn_prj_duzenle.Click += new System.EventHandler(this.btn_prj_duzenle_Click);
            // 
            // dgw_prj_list
            // 
            this.dgw_prj_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_prj_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_prj_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_prj_list.Location = new System.Drawing.Point(0, 0);
            this.dgw_prj_list.Name = "dgw_prj_list";
            this.dgw_prj_list.Size = new System.Drawing.Size(1362, 490);
            this.dgw_prj_list.TabIndex = 37;
            this.dgw_prj_list.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_prj_list_RowHeaderMouseClick);
            // 
            // txt_prjAdi
            // 
            this.txt_prjAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_prjAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_prjAdi.Location = new System.Drawing.Point(293, 16);
            this.txt_prjAdi.Name = "txt_prjAdi";
            this.txt_prjAdi.Size = new System.Drawing.Size(268, 22);
            this.txt_prjAdi.TabIndex = 36;
            this.txt_prjAdi.TextChanged += new System.EventHandler(this.txt_prjAdi_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(164, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Proje Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(188, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Proje No : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(585, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "PROJELER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Toplam :";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toplam.Location = new System.Drawing.Point(71, 10);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(16, 20);
            this.lbl_toplam.TabIndex = 41;
            this.lbl_toplam.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_toplam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 117);
            this.panel1.TabIndex = 42;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 68);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmb_projeNo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_prjAdi);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1362, 49);
            this.splitContainer1.SplitterDistance = 609;
            this.splitContainer1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgw_prj_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 490);
            this.panel2.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_prj_duzenle);
            this.panel3.Controls.Add(this.btn_prj_sil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 548);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1362, 59);
            this.panel3.TabIndex = 44;
            // 
            // cmb_projeNo
            // 
            this.cmb_projeNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_projeNo.FormattingEnabled = true;
            this.cmb_projeNo.Items.AddRange(new object[] {
            "Hepsi"});
            this.cmb_projeNo.Location = new System.Drawing.Point(303, 14);
            this.cmb_projeNo.Name = "cmb_projeNo";
            this.cmb_projeNo.Size = new System.Drawing.Size(192, 21);
            this.cmb_projeNo.TabIndex = 34;
            this.cmb_projeNo.SelectedIndexChanged += new System.EventHandler(this.cmb_projeNo_SelectedIndexChanged);
            // 
            // proje_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 607);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "proje_list";
            this.Text = "Projeler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.proje_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_prj_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_prj_sil;
        private System.Windows.Forms.Button btn_prj_duzenle;
        private System.Windows.Forms.DataGridView dgw_prj_list;
        private System.Windows.Forms.TextBox txt_prjAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmb_projeNo;
    }
}