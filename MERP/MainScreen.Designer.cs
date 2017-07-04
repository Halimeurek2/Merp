using System;

namespace MERP
{
    partial class MainScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toDoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisEmriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fATURALARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gELENFATURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kESİLENFATURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJELERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniProrjeGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKKINDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dg_maliyet = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_cokacil = new System.Windows.Forms.DataGridView();
            this.btn_diger = new System.Windows.Forms.Button();
            this.btn_acil_normal = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_gbp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_eur = new System.Windows.Forms.Label();
            this.lbl_usd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmb_proje = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_maliyet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cokacil)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toDoListToolStripMenuItem,
            this.siparisEmriToolStripMenuItem,
            this.fATURALARToolStripMenuItem,
            this.pROJELERToolStripMenuItem,
            this.hAKKINDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toDoListToolStripMenuItem
            // 
            this.toDoListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniGirişToolStripMenuItem});
            this.toDoListToolStripMenuItem.Name = "toDoListToolStripMenuItem";
            this.toDoListToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.toDoListToolStripMenuItem.Text = "To Do";
            // 
            // yeniGirişToolStripMenuItem
            // 
            this.yeniGirişToolStripMenuItem.Name = "yeniGirişToolStripMenuItem";
            this.yeniGirişToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.yeniGirişToolStripMenuItem.Text = "Yeni Aktivite Girişi";
            this.yeniGirişToolStripMenuItem.Click += new System.EventHandler(this.yeniGirişToolStripMenuItem_Click);
            // 
            // siparisEmriToolStripMenuItem
            // 
            this.siparisEmriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOluşturToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.siparisEmriToolStripMenuItem.Name = "siparisEmriToolStripMenuItem";
            this.siparisEmriToolStripMenuItem.Size = new System.Drawing.Size(123, 23);
            this.siparisEmriToolStripMenuItem.Text = "SİPARİŞ EMRİ";
            // 
            // yeniOluşturToolStripMenuItem
            // 
            this.yeniOluşturToolStripMenuItem.Name = "yeniOluşturToolStripMenuItem";
            this.yeniOluşturToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.yeniOluşturToolStripMenuItem.Text = "Yeni Sipariş Emri Oluştur";
            this.yeniOluşturToolStripMenuItem.Click += new System.EventHandler(this.yeniOluşturToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // fATURALARToolStripMenuItem
            // 
            this.fATURALARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gELENFATURAToolStripMenuItem,
            this.kESİLENFATURAToolStripMenuItem,
            this.listeleToolStripMenuItem1});
            this.fATURALARToolStripMenuItem.Name = "fATURALARToolStripMenuItem";
            this.fATURALARToolStripMenuItem.Size = new System.Drawing.Size(111, 23);
            this.fATURALARToolStripMenuItem.Text = "FATURALAR";
            // 
            // gELENFATURAToolStripMenuItem
            // 
            this.gELENFATURAToolStripMenuItem.Name = "gELENFATURAToolStripMenuItem";
            this.gELENFATURAToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.gELENFATURAToolStripMenuItem.Text = "GELEN FATURA";
            this.gELENFATURAToolStripMenuItem.Click += new System.EventHandler(this.gELENFATURAToolStripMenuItem_Click);
            // 
            // kESİLENFATURAToolStripMenuItem
            // 
            this.kESİLENFATURAToolStripMenuItem.Name = "kESİLENFATURAToolStripMenuItem";
            this.kESİLENFATURAToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.kESİLENFATURAToolStripMenuItem.Text = "KESİLEN FATURA";
            this.kESİLENFATURAToolStripMenuItem.Click += new System.EventHandler(this.kESİLENFATURAToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem1
            // 
            this.listeleToolStripMenuItem1.Name = "listeleToolStripMenuItem1";
            this.listeleToolStripMenuItem1.Size = new System.Drawing.Size(205, 24);
            this.listeleToolStripMenuItem1.Text = "Listele";
            this.listeleToolStripMenuItem1.Click += new System.EventHandler(this.listeleToolStripMenuItem1_Click);
            // 
            // pROJELERToolStripMenuItem
            // 
            this.pROJELERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniProrjeGirişiToolStripMenuItem,
            this.listeleToolStripMenuItem2});
            this.pROJELERToolStripMenuItem.Name = "pROJELERToolStripMenuItem";
            this.pROJELERToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.pROJELERToolStripMenuItem.Text = "PROJELER";
            // 
            // yeniProrjeGirişiToolStripMenuItem
            // 
            this.yeniProrjeGirişiToolStripMenuItem.Name = "yeniProrjeGirişiToolStripMenuItem";
            this.yeniProrjeGirişiToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.yeniProrjeGirişiToolStripMenuItem.Text = "Yeni Prorje Girişi";
            this.yeniProrjeGirişiToolStripMenuItem.Click += new System.EventHandler(this.yeniProrjeGirişiToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem2
            // 
            this.listeleToolStripMenuItem2.Name = "listeleToolStripMenuItem2";
            this.listeleToolStripMenuItem2.Size = new System.Drawing.Size(198, 24);
            this.listeleToolStripMenuItem2.Text = "Listele";
            this.listeleToolStripMenuItem2.Click += new System.EventHandler(this.listeleToolStripMenuItem2_Click);
            // 
            // hAKKINDAToolStripMenuItem
            // 
            this.hAKKINDAToolStripMenuItem.Name = "hAKKINDAToolStripMenuItem";
            this.hAKKINDAToolStripMenuItem.Size = new System.Drawing.Size(100, 23);
            this.hAKKINDAToolStripMenuItem.Text = "HAKKINDA";
            this.hAKKINDAToolStripMenuItem.Click += new System.EventHandler(this.hAKKINDAToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dg_maliyet);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(13, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 207);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PROJE MALİYETLERİ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dg_maliyet
            // 
            this.dg_maliyet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_maliyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_maliyet.Location = new System.Drawing.Point(6, 20);
            this.dg_maliyet.Name = "dg_maliyet";
            this.dg_maliyet.Size = new System.Drawing.Size(560, 181);
            this.dg_maliyet.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dg_cokacil);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 611);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÇOK ACİL İŞLER :";
            // 
            // dg_cokacil
            // 
            this.dg_cokacil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_cokacil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cokacil.Location = new System.Drawing.Point(7, 20);
            this.dg_cokacil.Name = "dg_cokacil";
            this.dg_cokacil.Size = new System.Drawing.Size(1227, 101);
            this.dg_cokacil.TabIndex = 0;
            this.dg_cokacil.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_cokacil_RowHeaderMouseClick);
            // 
            // btn_diger
            // 
            this.btn_diger.Location = new System.Drawing.Point(591, 128);
            this.btn_diger.Name = "btn_diger";
            this.btn_diger.Size = new System.Drawing.Size(90, 66);
            this.btn_diger.TabIndex = 11;
            this.btn_diger.Text = "Diğer Aktiviteler";
            this.btn_diger.UseVisualStyleBackColor = true;
            this.btn_diger.Click += new System.EventHandler(this.btn_diger_Click);
            // 
            // btn_acil_normal
            // 
            this.btn_acil_normal.Location = new System.Drawing.Point(591, 56);
            this.btn_acil_normal.Name = "btn_acil_normal";
            this.btn_acil_normal.Size = new System.Drawing.Size(90, 66);
            this.btn_acil_normal.TabIndex = 10;
            this.btn_acil_normal.Text = "Acil-Normal ";
            this.btn_acil_normal.UseVisualStyleBackColor = true;
            this.btn_acil_normal.Click += new System.EventHandler(this.btn_biten_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lbl_gbp);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.lbl_eur);
            this.groupBox5.Controls.Add(this.lbl_usd);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(1086, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(167, 120);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "KURLAR ";
            // 
            // lbl_gbp
            // 
            this.lbl_gbp.AutoSize = true;
            this.lbl_gbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gbp.Location = new System.Drawing.Point(83, 88);
            this.lbl_gbp.Name = "lbl_gbp";
            this.lbl_gbp.Size = new System.Drawing.Size(45, 16);
            this.lbl_gbp.TabIndex = 5;
            this.lbl_gbp.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "GBP :";
            // 
            // lbl_eur
            // 
            this.lbl_eur.AutoSize = true;
            this.lbl_eur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eur.Location = new System.Drawing.Point(83, 58);
            this.lbl_eur.Name = "lbl_eur";
            this.lbl_eur.Size = new System.Drawing.Size(45, 16);
            this.lbl_eur.TabIndex = 3;
            this.lbl_eur.Text = "label4";
            // 
            // lbl_usd
            // 
            this.lbl_usd.AutoSize = true;
            this.lbl_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_usd.Location = new System.Drawing.Point(83, 27);
            this.lbl_usd.Name = "lbl_usd";
            this.lbl_usd.Size = new System.Drawing.Size(45, 16);
            this.lbl_usd.TabIndex = 2;
            this.lbl_usd.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "EUR :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "USD : ";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 2;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisX.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX2.MajorGrid.Interval = 0D;
            chartArea1.AxisX2.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY.MinorTickMark.Size = 0.3F;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 287);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawSideBySide=True";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelAngle = 30;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1233, 301);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // cmb_proje
            // 
            this.cmb_proje.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_proje.FormattingEnabled = true;
            this.cmb_proje.Location = new System.Drawing.Point(1134, 205);
            this.cmb_proje.Name = "cmb_proje";
            this.cmb_proje.Size = new System.Drawing.Size(118, 21);
            this.cmb_proje.TabIndex = 14;
            this.cmb_proje.SelectedIndexChanged += new System.EventHandler(this.cmb_proje_SelectedIndexChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = global::MERP.Properties.Resources.Refresh_20;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(591, 205);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(90, 50);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 750);
            this.Controls.Add(this.cmb_proje);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_diger);
            this.Controls.Add(this.btn_acil_normal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTINAT MANUEL ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_maliyet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cokacil)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toDoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisEmriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fATURALARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gELENFATURAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kESİLENFATURAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pROJELERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniProrjeGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hAKKINDAToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_maliyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_cokacil;
        private System.Windows.Forms.Button btn_diger;
        private System.Windows.Forms.Button btn_acil_normal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_gbp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_eur;
        private System.Windows.Forms.Label lbl_usd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmb_proje;
    }
}

