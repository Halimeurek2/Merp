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
            this.txt_prjNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_prj_list)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_prj_sil
            // 
            this.btn_prj_sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_prj_sil.BackColor = System.Drawing.Color.Red;
            this.btn_prj_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_prj_sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_prj_sil.Location = new System.Drawing.Point(838, 562);
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
            this.btn_prj_duzenle.Location = new System.Drawing.Point(502, 562);
            this.btn_prj_duzenle.Name = "btn_prj_duzenle";
            this.btn_prj_duzenle.Size = new System.Drawing.Size(87, 36);
            this.btn_prj_duzenle.TabIndex = 38;
            this.btn_prj_duzenle.Text = "DÜZENLE";
            this.btn_prj_duzenle.UseVisualStyleBackColor = true;
            this.btn_prj_duzenle.Click += new System.EventHandler(this.btn_prj_duzenle_Click);
            // 
            // dgw_prj_list
            // 
            this.dgw_prj_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_prj_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_prj_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_prj_list.Location = new System.Drawing.Point(15, 118);
            this.dgw_prj_list.Name = "dgw_prj_list";
            this.dgw_prj_list.Size = new System.Drawing.Size(1335, 438);
            this.dgw_prj_list.TabIndex = 37;
            this.dgw_prj_list.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_prj_list_RowHeaderMouseClick);
            // 
            // txt_prjAdi
            // 
            this.txt_prjAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_prjAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_prjAdi.Location = new System.Drawing.Point(783, 71);
            this.txt_prjAdi.Name = "txt_prjAdi";
            this.txt_prjAdi.Size = new System.Drawing.Size(268, 22);
            this.txt_prjAdi.TabIndex = 36;
            this.txt_prjAdi.TextChanged += new System.EventHandler(this.txt_prjAdi_TextChanged);
            // 
            // txt_prjNo
            // 
            this.txt_prjNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_prjNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_prjNo.Location = new System.Drawing.Point(431, 71);
            this.txt_prjNo.Name = "txt_prjNo";
            this.txt_prjNo.Size = new System.Drawing.Size(233, 22);
            this.txt_prjNo.TabIndex = 35;
            this.txt_prjNo.TextChanged += new System.EventHandler(this.txt_prjNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(696, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Proje Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(349, 74);
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
            this.label4.Location = new System.Drawing.Point(616, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "PROJELER";
            // 
            // proje_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 607);
            this.Controls.Add(this.btn_prj_sil);
            this.Controls.Add(this.btn_prj_duzenle);
            this.Controls.Add(this.dgw_prj_list);
            this.Controls.Add(this.txt_prjAdi);
            this.Controls.Add(this.txt_prjNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "proje_list";
            this.Text = "Projeler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.proje_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_prj_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prj_sil;
        private System.Windows.Forms.Button btn_prj_duzenle;
        private System.Windows.Forms.DataGridView dgw_prj_list;
        private System.Windows.Forms.TextBox txt_prjAdi;
        private System.Windows.Forms.TextBox txt_prjNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}