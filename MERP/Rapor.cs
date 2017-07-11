﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;

namespace MERP
{
    public partial class Rapor : Form
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        string connectionString;
        string komut;
        MySqlCommand myCommand;
        MySqlDataAdapter da;
        MySqlConnection myConnection;
        MySqlDataReader myReader;
        DataTable dt = new DataTable();

        string el_mal;
        string mek_mal;
        string genel_mal;

        Series elektrikMaliyet;
        Series mekanikMaliyet;
        Series genelMaliyet;

        Bitmap memoryImage;

        private System.IO.Stream streamToPrint;

        string streamType;

        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt
        (
            IntPtr hdcDest, // handle to destination DC
            int nXDest, // x-coord of destination upper-left corner
            int nYDest, // y-coord of destination upper-left corner
            int nWidth, // width of destination rectangle
            int nHeight, // height of destination rectangle
            IntPtr hdcSrc, // handle to source DC
            int nXSrc, // x-coordinate of source upper-left corner
            int nYSrc, // y-coordinate of source upper-left corner
            System.Int32 dwRop // raster operation code
        );

        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "uretimplanlama_2";
            uid = "root";
            password = "root";
            //string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            myConnection = new MySqlConnection(connectionString);
            myConnection.Open();


            komut = "SELECT DISTINCT proje_no FROM db_projeler";
            da = new MySqlDataAdapter(komut, connection);
            myCommand = new MySqlCommand(komut, myConnection);
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                cmb_projeler.Items.Add(myReader["proje_no"]);
            }

            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Maliyet");

            elektrikMaliyet = this.chart1.Series.Add("Elektrik");
            elektrikMaliyet.ChartType = SeriesChartType.Pie;
            elektrikMaliyet.Color = Color.Red;
            elektrikMaliyet.IsValueShownAsLabel = true;
            elektrikMaliyet.LabelAngle = 30;


            mekanikMaliyet = chart1.Series.Add("Mekanik");
            mekanikMaliyet.ChartType = elektrikMaliyet.ChartType;
            mekanikMaliyet.Color = Color.Blue;
            mekanikMaliyet.IsValueShownAsLabel = true;
            mekanikMaliyet.LabelAngle = 30;


            genelMaliyet = chart1.Series.Add("Genel");
            genelMaliyet.ChartType = elektrikMaliyet.ChartType;
            genelMaliyet.Color = Color.Orange;
            genelMaliyet.IsValueShownAsLabel = true;
            genelMaliyet.LabelAngle = 30;

            myReader.Close();
            myConnection.Close();
        }
        public void DrawChart()
        {
            myConnection.Open();
            try
            {
                komut = "select sum(fatura_euro) as EURO from db_faturalar where fatura_cinsi='elektrik' AND fatura_proje_no ='" + cmb_projeler.Text + "'";
                da = new MySqlDataAdapter(komut, connection);

                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    el_mal = Convert.ToString(myReader.GetString(0));
                }
                myReader.Close();
            }
            catch
            {
                el_mal = "0";
            }
            try
            {
                komut = "select sum(fatura_euro) as EURO from db_faturalar where fatura_cinsi='mekanik'";
                da = new MySqlDataAdapter(komut, connection);

                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    mek_mal = Convert.ToString(myReader.GetString(0));
                }
                myReader.Close();
            }
            catch
            {
                mek_mal = "0";
            }
            try
            {
                komut = "select sum(fatura_euro) as EURO from db_faturalar";
                da = new MySqlDataAdapter(komut, connection);

                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    genel_mal = Convert.ToString(myReader.GetString(0));
                }
                myReader.Close();
            }
            catch
            {
                genel_mal = "0";
            }
            myConnection.Close();

            elektrikMaliyet.Points.Clear();
            mekanikMaliyet.Points.Clear();
            genelMaliyet.Points.Clear();

            elektrikMaliyet.Points.Add(Convert.ToDouble(el_mal));
            mekanikMaliyet.Points.Add(Convert.ToDouble(mek_mal));
            genelMaliyet.Points.Add(Convert.ToDouble(genel_mal));

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmb_projeler_SelectedIndexChanged(object sender, EventArgs e)
        {
                myConnection.Open();

                komut = "SELECT COUNT(*) FROM db_siparis_emri WHERE proje_no='" + cmb_projeler.Text + "'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    lbl_top_se.Text = Convert.ToString(myReader.GetString(0));
                }
                myReader.Close();
            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_proje_no ='" + cmb_projeler.Text + "'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    lbl_top_maliyet.Text = Convert.ToString(myReader.GetString(0));
                }
                myReader.Close();
            }
            catch
            {
                lbl_top_maliyet.Text = "0";
            }

            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_durum='ÖDENDİ' AND fatura_proje_no ='" + cmb_projeler.Text + "'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    lbl_odenenTop.Text = Convert.ToString(myReader.GetString(0));
                }
            }
            catch
            {
                lbl_odenenTop.Text = "0";
            }

            myConnection.Close();

            FillDGW();
            DGWToplam();
            DrawChart();
        }

        public void FillDGW()
        {
            myConnection.Open();

            komut = "SELECT fatura_no as FaturaNo," +
                    "fatura_vade as Vade," +
                    "fatura_vade_tarih as VadeTarih," +
                    "fatura_euro as Euro," +
                    "fatura_cinsi as Tip FROM db_faturalar WHERE fatura_durum='ÖDENMEDİ' AND fatura_proje_no ='" + cmb_projeler.Text + "' AND fatura_tipi='G'";
            myCommand = new MySqlCommand(komut, myConnection);
            da = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            // myReader = myCommand.ExecuteReader();

            da.Fill(dt);
            dgw_odenmemisG.DataSource = dt;

            dgw_odenmemisG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_odenmemisG.AutoSizeColumnsMode =
                       DataGridViewAutoSizeColumnsMode.Fill;

            komut = "SELECT fatura_no as FaturaNo," +
                    "fatura_vade as Vade," +
                    "fatura_vade_tarih as VadeTarih," +
                    "fatura_euro as Euro," +
                    "fatura_cinsi as Tip FROM db_faturalar WHERE fatura_durum='ÖDENMEDİ' AND fatura_proje_no ='" + cmb_projeler.Text + "' AND fatura_tipi='K'";
            myCommand = new MySqlCommand(komut, myConnection);
            da = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            // myReader = myCommand.ExecuteReader();

            da.Fill(dt);
            dgw_odenmemisK.DataSource = dt;

            dgw_odenmemisK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_odenmemisK.AutoSizeColumnsMode =
                       DataGridViewAutoSizeColumnsMode.Fill;

            myConnection.Close();
        }

        public void DGWToplam()
        {
            myConnection.Open();
            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_proje_no ='" + cmb_projeler.Text + "' AND fatura_tipi='G'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    gb_G.Text = Convert.ToString(myReader.GetString(0));
                }
                myReader.Close();
            }
            catch
            {
                gb_G.Text = "0";
            }

            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_proje_no ='" + cmb_projeler.Text + "' AND fatura_tipi='K'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    gb_K.Text = Convert.ToString(myReader.GetString(0));
                }
            }
            catch
            {
                gb_K.Text = "0";
            }
          
            myReader.Close();
            myConnection.Close();
        }
        public void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printPreviewDialog1.ShowDialog();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            String filename = System.IO.Path.GetTempFileName();

            Graphics g1 = this.CreateGraphics();
            Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            MyImage.Save(filename, ImageFormat.Png);
            FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StartPrint(fileStream, "Image");
            fileStream.Close();
            if (System.IO.File.Exists(filename))
            {
                System.IO.File.Delete(filename);
            }
            //    Process snippingToolProcess = new Process();
            //    snippingToolProcess.EnableRaisingEvents = true;
            //    if (!Environment.Is64BitProcess)
            //    {
            //        snippingToolProcess.StartInfo.FileName = "C:\\Windows\\sysnative\\SnippingTool.exe";
            //        snippingToolProcess.Start();
            //    }
            //    else
            //    {
            //        snippingToolProcess.StartInfo.FileName = "C:\\Windows\\system32\\SnippingTool.exe";
            //        snippingToolProcess.Start();
            //    }
            //CaptureScreen();
            //printDocument1.Print();
            //printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Image image = System.Drawing.Image.FromStream(this.streamToPrint);

            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;

            int width = image.Width;
            int height = image.Height;
            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }
            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }
        public void StartPrint(Stream streamToPrint, string streamType)
        {

            this.printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            this.streamToPrint = streamToPrint;

            this.streamType = streamType;

            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();

            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
