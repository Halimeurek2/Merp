using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using System.Globalization;

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
        HelperFunctions hf;

        public decimal TOPLAM=0;

        string el_mal;
        string mek_mal;
        string genel_mal;
        
        string el_ongorulen;
        string el_harcanan;
        string el_kalan;

        public string mek_ongorulen;
        string mek_harcanan;
        string mek_kalan;

        string genel_ongorulen;
        string genel_harcanan;
        string genel_kalan;
       

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
            hf = new HelperFunctions();
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

            chart2.Titles.Add("ELEKTRONİK");
            chart3.Titles.Add("MEKANİK");
            chart4.Titles.Add("GENEL GİDERLER");

            myReader.Close();
            myConnection.Close();
        }
        public void DrawChart1()
        {
            myConnection.Open();
            try
            {
                komut = "select sum(fatura_euro) as EURO from db_faturalar where fatura_cinsi='Elektronik' AND fatura_proje_no ='" + cmb_projeler.Text + "'";
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
                myReader.Close();
            }
            try
            {
                komut = "select sum(fatura_euro) as EURO from db_faturalar where fatura_cinsi='Mekanik' AND fatura_proje_no ='" + cmb_projeler.Text + "'";
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
                myReader.Close();
            }
            try
            {
                komut = "select sum(fatura_euro) as EURO from db_faturalar WHERE fatura_cinsi='Genel Giderler' AND fatura_proje_no ='" + cmb_projeler.Text + "'";
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
                myReader.Close();
            }
            chart1.Series["pieChart"].Points.Clear();

           // el_mal = Convert.ToString(Convert.ToDouble(el_mal, CultureInfo.GetCultureInfo("en-US").NumberFormat));

            chart1.Series["pieChart"].Points.Add(Convert.ToDouble(el_mal));
            chart1.Series["pieChart"].Points.Add(Convert.ToDouble(mek_mal));
            chart1.Series["pieChart"].Points.Add(Convert.ToDouble(genel_mal));

            var p1 = chart1.Series["pieChart"].Points[0];
            p1.AxisLabel = Convert.ToString(el_mal);
            p1.LegendText = "Elektronik";

            var p2 = chart1.Series["pieChart"].Points[1];
            p2.AxisLabel = Convert.ToString(mek_mal);
            p2.LegendText = "Mekanik";

            var p3 = chart1.Series["pieChart"].Points[2];
            p3.AxisLabel = Convert.ToString(genel_mal);
            p3.LegendText = "Genel Giderler";

            myConnection.Close();

        }
        public void DrawChart2()
        {
            myConnection.Open();

            try
            {
                komut = "select sum(harcama_el_mlz) from db_projeler where proje_no in(select fatura_proje_no from db_faturalar where fatura_cinsi='Elektronik' and fatura_proje_no='"+cmb_projeler.Text+"')";
                da = new MySqlDataAdapter(komut, connection);

                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    el_ongorulen = Convert.ToString(myReader.GetString(0));
                }
                myReader.Close();
            }
            catch
            {
                el_ongorulen = "0";
                myReader.Close();
            }
            try
            {
                el_harcanan = el_mal;
            }
            catch
            {
                el_harcanan = "0";
                myReader.Close();
            }
            try
            {
                el_kalan = Convert.ToString((Convert.ToDecimal(el_ongorulen)-Convert.ToDecimal(el_harcanan)));
            }
            catch
            {

            }
            
            chart2.Series["Series1"].Points.Clear();

            // el_ongorulen = Convert.ToString(el_ongorulen, CultureInfo.GetCultureInfo("de-DE").NumberFormat);
            // el_ongorulen=string.Format(new System.Globalization.CultureInfo("de-DE"), "{0:C2}", el_ongorulen);
            // el_ongorulen= string.Format("{0:#.00}", Convert.ToDecimal(el_ongorulen) / 100);
            // string html = String.Format("{0:C}", el_ongorulen);

            //decimal ongorulen = Convert.ToDecimal(el_ongorulen);
            //el_ongorulen = string.Format(new CultureInfo("de-DE"), "{0:C2}", ongorulen);
            el_ongorulen = hf.DecimalToCurrency(Convert.ToDecimal(el_ongorulen), el_ongorulen);

            chart2.Legends[0].Title = "Öngörülen Toplam" + " " + el_ongorulen;

            chart2.Series["Series1"].Points.Add(Convert.ToDouble(el_harcanan));
            chart2.Series["Series1"].Points.Add(Convert.ToDouble(el_kalan));

            //var p1 = chart2.Series["Series1"].Points[0];
            //p1.AxisLabel = Convert.ToString(el_ongorulen);
            //p1.LegendText = "Öngörülen";

            var p1 = chart2.Series["Series1"].Points[0];
            p1.AxisLabel = Convert.ToString(el_harcanan);
            p1.LegendText = "Harcanan";

            var p2 = chart2.Series["Series1"].Points[1];
            p2.AxisLabel = Convert.ToString(el_kalan);
            p2.LegendText = "Kalan";

            myConnection.Close();
        }

        public void DrawChart3()
        {
            myConnection.Open();

            try
            {
                komut = "select (sum(harcama_m_mlz)+sum(harcama_imalat)) from db_projeler where proje_no in(select fatura_proje_no from db_faturalar where fatura_cinsi='Mekanik' and fatura_proje_no='" + cmb_projeler.Text + "')";
                da = new MySqlDataAdapter(komut, connection);

                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    mek_ongorulen = Convert.ToString(myReader.GetString(0));
                }
                myReader.Close();
            }
            catch
            {
                mek_ongorulen = "0";
                myReader.Close();
            }
            try
            {
                mek_harcanan = mek_mal;
            }
            catch
            {
                mek_harcanan = "0";
                myReader.Close();
            }
            try
            {
                mek_kalan = Convert.ToString((Convert.ToDecimal(mek_ongorulen) - Convert.ToDecimal(mek_harcanan)));
            }
            catch
            {

            }
            
            chart3.Series["Series1"].Points.Clear();
            
            mek_ongorulen =hf.DecimalToCurrency(Convert.ToDecimal(mek_ongorulen), mek_ongorulen);

            chart3.Legends[0].Title = "Öngörülen Toplam" + " " + mek_ongorulen;
            chart3.Series["Series1"].Points.Add(Convert.ToDouble(mek_harcanan));
            chart3.Series["Series1"].Points.Add(Convert.ToDouble(mek_kalan));

            var p1 = chart3.Series["Series1"].Points[0];
            p1.AxisLabel = Convert.ToString(mek_harcanan);
            p1.LegendText = "Harcanan";

            var p2 = chart3.Series["Series1"].Points[1];
            p2.AxisLabel = Convert.ToString(mek_kalan);
            p2.LegendText = "Kalan";

            myConnection.Close();
        }

        public void DrawChart4()
        {
            myConnection.Open();

            try
            {
                komut = "select (sum(harcama_risk)+sum(harcama_test)) from db_projeler where proje_no in(select fatura_proje_no from db_faturalar where fatura_cinsi='genel' and fatura_proje_no='" + cmb_projeler.Text + "')";
                da = new MySqlDataAdapter(komut, connection);

                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    genel_ongorulen = Convert.ToString(myReader.GetString(0));
                }
                myReader.Close();
            }
            catch
            {
                genel_ongorulen = "0";
                myReader.Close();
            }
            try
            {
                genel_harcanan = genel_mal;
            }
            catch
            {
                genel_harcanan = "0";
                myReader.Close();
            }
            try
            {
                genel_kalan = Convert.ToString((Convert.ToDecimal(genel_ongorulen) - Convert.ToDecimal(genel_harcanan)));
            }
            catch
            {

            }
            
            chart4.Series["Series1"].Points.Clear();

            genel_ongorulen = hf.DecimalToCurrency(Convert.ToDecimal(genel_ongorulen), genel_ongorulen);

            chart4.Legends[0].Title = "Öngörülen Toplam" + " " + genel_ongorulen;
            chart4.Series["Series1"].Points.Add(Convert.ToDouble(genel_harcanan));
            chart4.Series["Series1"].Points.Add(Convert.ToDouble(genel_kalan));

            var p1 = chart4.Series["Series1"].Points[0];
            p1.AxisLabel = Convert.ToString(genel_harcanan);
            p1.LegendText = "Harcanan";

            var p2 = chart4.Series["Series1"].Points[1];
            p2.AxisLabel = Convert.ToString(genel_kalan);
            p2.LegendText = "Kalan";

            myConnection.Close();
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
                    lbl_adet_se.Text = Convert.ToString(myReader.GetString(0));
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
                    TOPLAM = Convert.ToDecimal(myReader.GetString(0));
                    lbl_top_maliyet.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
                }
                myReader.Close();
            }
            catch
            {
                lbl_top_maliyet.Text = "0";
                myReader.Close();
            }

            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_durum='ÖDENDİ' AND fatura_proje_no ='" + cmb_projeler.Text + "'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TOPLAM = Convert.ToDecimal(myReader.GetString(0));
                    lbl_odenenTop.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
                }
                myReader.Close();
            }
            catch
            {
                lbl_odenenTop.Text = "0";
                myReader.Close();
            }

            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_durum='ÖDENMEDİ' AND fatura_proje_no ='" + cmb_projeler.Text + "'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TOPLAM = Convert.ToDecimal(myReader.GetString(0));
                    lbl_odenmemisTop.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
                }
                myReader.Close();
            }
            catch
            {
                   lbl_odenmemisTop.Text = "0";
                   myReader.Close();
            }

            try
            {
                komut = "SELECT sum(siparis_euro) FROM db_siparis_emri WHERE proje_no='" + cmb_projeler.Text + "'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TOPLAM = Convert.ToDecimal(myReader.GetString(0));
                    lbl_top_se.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
                }
                myReader.Close();
            }
            catch
            {
                lbl_top_se.Text = "0";
                myReader.Close();
            }

            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_durum='ÖDENMEDİ' AND fatura_proje_no ='" + cmb_projeler.Text + "' AND fatura_tipi='K'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TOPLAM = Convert.ToDecimal(myReader.GetString(0));
                    lbl_odenmemisK.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
                }
                myReader.Close();
            }
            catch
            {
                lbl_odenmemisK.Text = "0";
                myReader.Close();
            }

            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_durum='ÖDENDİ' AND fatura_proje_no ='" + cmb_projeler.Text + "' AND fatura_tipi='K'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TOPLAM = Convert.ToDecimal(myReader.GetString(0));
                    lbl_odenmisK.Text = string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
                }
                myReader.Close();
            }
            catch
            {
                lbl_odenmisK.Text = "0";
                myReader.Close();
            }

            myConnection.Close();

            FillDGW();
            DGWToplam();
            DrawChart1();
            DrawChart2();
            DrawChart3();
            DrawChart4();
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

            dgw_odenmemisK.Columns[3].DefaultCellStyle.Format = "c2";
            dgw_odenmemisK.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("de-DE");
            dgw_odenmemisG.Columns[3].DefaultCellStyle.Format = "c2";
            dgw_odenmemisG.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("de-DE");
            myConnection.Close();
        }
        public void DGWToplam()
        {
            myConnection.Open();
            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_durum='ÖDENMEDİ' AND fatura_proje_no ='" + cmb_projeler.Text + "' AND fatura_tipi='G'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TOPLAM = Convert.ToDecimal(myReader.GetString(0));
                    gb_G.Text = "Toplam Gelen : " + string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
                }
                myReader.Close();
            }
            catch
            {
                gb_G.Text = "0";
            }

            try
            {
                komut = "SELECT sum(fatura_euro) FROM db_faturalar WHERE fatura_durum='ÖDENMEDİ' AND fatura_proje_no ='" + cmb_projeler.Text + "' AND fatura_tipi='K'";
                da = new MySqlDataAdapter(komut, connection);
                myCommand = new MySqlCommand(komut, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TOPLAM= Convert.ToDecimal(myReader.GetString(0));
                    gb_K.Text = "Toplam Kesilen : " + string.Format(new CultureInfo("de-DE"), "{0:C2}", Convert.ToDecimal(TOPLAM));
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
            string filename = Path.GetTempFileName();

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
            if (File.Exists(filename))
            {
                File.Delete(filename);
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
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image image = Image.FromStream(streamToPrint);

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
            Rectangle destRect = new Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
        }
        public void StartPrint(Stream streamToPrint, string streamType)
        {

            this.printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            this.streamToPrint = streamToPrint;

            this.streamType = streamType;

            PrintDialog PrintDialog1 = new PrintDialog();

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
