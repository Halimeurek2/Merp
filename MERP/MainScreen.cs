using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;



namespace MERP
{
    public partial class MainScreen : Form
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

        string fatura_vade;
        DateTime fatura_vade_tarih;
        DateTime tarih;
        DateTime now;
        public int fatura_id;
        public int flag = 0;
        SmtpClient sc;
        int elemanSayisi = 0;
        int i = 0;
        Series series;
        Series seriesCopy;
        DateTime[] tarih_array_K = new DateTime[99999];
        float[] fatura_tutar_K = new float[99999];
        DateTime[] tarih_array_G = new DateTime[99999];
        float[] toplam_fatura_G = new float[12];
        float[] toplam_fatura_K = new float[12];
        float[] fatura_tutar_G = new float[99999];
        private DataSet dsDovizKur;

        ToolTip tooltip = new ToolTip();
        Point? clickPosition = null;


        /*
         * test edilecek
         */
         enum years
        {
            y2016 = 0,
            y2017
        };

        float[,] sum_fatura = new float[2,12];



        public MainScreen()
        {
            InitializeComponent();       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "uretimplanlama_2";
            uid = "root";
            password = "root";
            //string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            myConnection = new MySqlConnection(connectionString);
            myConnection.Open();

            dsDovizKur = new DataSet();
            dsDovizKur.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
            DataRow dr = dsDovizKur.Tables[1].Rows[0];
            lbl_usd.Text = dr[4].ToString().Replace('.', ',');
            dr = dsDovizKur.Tables[1].Rows[3];
            lbl_eur.Text = dr[4].ToString().Replace('.', ',');
            dr = dsDovizKur.Tables[1].Rows[4];
            lbl_gbp.Text = dr[4].ToString().Replace('.', ',');



            sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("altinaymerp@gmail.com", "123456qweasd");

            komut = "SELECT DISTINCT proje_no FROM db_projeler";
            da = new MySqlDataAdapter(komut, connection);
            myCommand = new MySqlCommand(komut, myConnection);
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                cmb_proje.Items.Add(myReader["proje_no"]);
            }

            komut = "SELECT fatura_id,fatura_vade,fatura_vade_tarih  FROM db_faturalar WHERE fatura_check=" + 1 + " ";
            da = new MySqlDataAdapter(komut, connection);

            myConnection = new MySqlConnection(connectionString);
            myCommand = new MySqlCommand(komut, myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            // Always call Read before accessing data.

            while (myReader.Read())
            {

                fatura_vade = myReader["fatura_vade"].ToString();
                fatura_vade_tarih = Convert.ToDateTime(myReader["fatura_vade_tarih"]);
                tarih = fatura_vade_tarih.AddDays(int.Parse(fatura_vade));

                now = DateTime.Now;


                if ((now - tarih).TotalDays < 5)
                {
                    NotificationWindow.PopupNotifier popup = new NotificationWindow.PopupNotifier();

                    if (flag == 0)
                    {
                        popup.Image = Properties.Resources.information_alert_attention_sign_help_48;
                        popup.TitleText = "Uyarı";
                        popup.ContentText = tarih + "Yaklaşan Vade Tarihi";
                        popup.popupIndex = 1;
                        popup.Popup();
                        flag = 1;

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("altinaymerp@gmail.com", "ALTINAY UYARI SİSTEMİ");
                        mail.To.Add("murathan.dincer@altinay.com");
                        mail.Subject = "FATURA UYARISI";
                        mail.IsBodyHtml = true;
                        mail.Body = "MGEO müşterisine kesilen faturanızın ödemesi 5 gün içinde yapılmalıdır";
                        //sc.Send(mail);
                    }
                    else if (flag == 1)
                    {
                        popup.Image = Properties.Resources.information_alert_attention_sign_help_48;
                        popup.TitleText = "Uyarı";
                        popup.ContentText = tarih + "Yaklaşan Vade Tarihi";
                        popup.popupIndex = 2;
                        popup.Popup();
                        flag = 2;
                        popup.popupIndex++;
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("altinaymerp@gmail.com", "ALTINAY UYARI SİSTEMİ");
                        mail.To.Add("murathan.dincer@altinay.com");
                        mail.Subject = "FATURA UYARISI";
                        mail.IsBodyHtml = true;
                        mail.Body = "MGEO müşterisine kesilen faturanızın ödemesi 5 gün içinde yapılmalıdır";
                        //sc.Send(mail);
                    }
                    else if (flag == 2)
                    {
                        popup.Image = Properties.Resources.information_alert_attention_sign_help_48;
                        popup.TitleText = "Uyarı";
                        popup.ContentText = tarih + "Yaklaşan Vade Tarihi";
                        popup.popupIndex = 3;
                        popup.Popup();
                        flag = 3;
                        popup.popupIndex++;
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("altinaymerp@gmail.com", "ALTINAY UYARI SİSTEMİ");
                        mail.To.Add("murathan.dincer@altinay.com");
                        mail.Subject = "FATURA UYARISI";
                        mail.IsBodyHtml = true;
                        mail.Body = "MGEO müşterisine kesilen faturanızın ödemesi 5 gün içinde yapılmalıdır";
                        //sc.Send(mail);
                    }
                    else if (flag == 3)
                    {
                        popup.Image = Properties.Resources.information_alert_attention_sign_help_48;
                        popup.TitleText = "Uyarı";
                        popup.ContentText = tarih + "Yaklaşan Vade Tarihi";
                        popup.popupIndex = 4;
                        popup.Popup();
                        flag = 4;
                        popup.popupIndex++;
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("altinaymerp@gmail.com", "ALTINAY UYARI SİSTEMİ");
                        mail.To.Add("murathan.dincer@altinay.com");
                        mail.Subject = "FATURA UYARISI";
                        mail.IsBodyHtml = true;
                        mail.Body = "MGEO müşterisine kesilen faturanızın ödemesi 5 gün içinde yapılmalıdır";
                        //sc.Send(mail);
                    }
                    else if (flag == 4)
                    {
                        popup.Image = Properties.Resources.information_alert_attention_sign_help_48;
                        popup.TitleText = "Uyarı";
                        popup.ContentText = tarih + "Yaklaşan Vade Tarihi";
                        popup.popupIndex = 5;
                        popup.Popup();
                        popup.popupIndex++;
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("altinaymerp@gmail.com", "ALTINAY UYARI SİSTEMİ");
                        mail.To.Add("murathan.dincer@altinay.com");
                        mail.Subject = "FATURA UYARISI";
                        mail.IsBodyHtml = true;
                        mail.Body = "MGEO müşterisine kesilen faturanızın ödemesi 5 gün içinde yapılmalıdır";
                        //sc.Send(mail);
                    }
                    else
                    {
                        popup.Image = Properties.Resources.information_alert_attention_sign_help_48;
                        popup.TitleText = "Uyarı";
                        popup.ContentText = tarih + "Yaklaşan Vade Tarihi";
                        popup.popupIndex = 6;
                        popup.Popup();
                        popup.popupIndex++;
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("altinaymerp@gmail.com", "ALTINAY UYARI SİSTEMİ");
                        mail.To.Add("murathan.dincer@altinay.com");
                        mail.Subject = "FATURA UYARISI";
                        mail.IsBodyHtml = true;
                        mail.Body = "MGEO müşterisine kesilen faturanızın ödemesi 5 gün içinde yapılmalıdır";
                        //sc.Send(mail);
                    }

                }

            }

            myReader.Close();
            myConnection.Close();

            komut = "SELECT * FROM db_aktivite WHERE akt_oncelik='" + Convert.ToString("COK ACİL") + "' AND akt_statu='" + Convert.ToString("AKTİF") + "'";
            myCommand = new MySqlCommand(komut, myConnection);
            da = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            // myReader = myCommand.ExecuteReader();

            da.Fill(dt);

            dg_cokacil.DataSource = dt;

            dg_cokacil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_cokacil.AutoSizeColumnsMode =
                       DataGridViewAutoSizeColumnsMode.Fill;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            this.chart1.Series.Clear();
            // this.chart1.ChartAreas.Clear();
            this.chart1.Titles.Add("Faturalar");
            series = this.chart1.Series.Add("Gelen Faturalar");
            series.ChartType = SeriesChartType.StepLine;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerColor = Color.Red;
            series.IsValueShownAsLabel = true;
            series.LabelAngle = 30;

            ChartArea area1 = chart1.ChartAreas.Add("ChartAreaCopy_" + series.Name);
            area1.BackColor = Color.Transparent;
            area1.BorderColor = Color.Transparent;
            area1.Position.FromRectangleF(area1.Position.ToRectangleF());
            area1.InnerPlotPosition.FromRectangleF(area1.InnerPlotPosition.ToRectangleF());
            area1.AxisX.MajorGrid.Enabled = false;
            area1.AxisX.MajorTickMark.Enabled = false;
            area1.AxisX.LabelStyle.Enabled = false;
            area1.AxisY.MajorGrid.Enabled = false;
            area1.AxisY.MajorTickMark.Enabled = false;
            area1.AxisY.LabelStyle.Enabled = false;

            area1.AxisY2.Enabled = AxisEnabled.True;
            area1.AxisY2.LabelStyle.Enabled = true;

            seriesCopy = chart1.Series.Add("Kesilen Faturalar");
            seriesCopy.ChartType = series.ChartType;
            seriesCopy.MarkerColor = series.MarkerColor;
            seriesCopy.MarkerStyle = series.MarkerStyle;
            seriesCopy.IsValueShownAsLabel = true;
            seriesCopy.LabelAngle = 30;
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            myConnection.Close();
            maliyet_hesapla();
        }

        public void maliyet_hesapla()
        {
            server = "localhost";
            database = "uretimplanlama_2";
            uid = "root";
            password = "root";
            //string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            myConnection = new MySqlConnection(connectionString);
            myConnection.Open();
            int a = dg_maliyet.RowCount;

            komut = "select fatura_proje_no as PROJE_NO, sum(case when fatura_birim = 'TRY' then fatura_tutari else 0 end) as TRY, " +
                    "sum(case when fatura_birim = 'EUR' then fatura_tutari else 0 end) as EUR ," +
                    "sum(case when fatura_birim = 'USD' then fatura_tutari else 0 end) as USD , " +
                    "sum(case when fatura_birim = 'GBP' then fatura_tutari else 0 end) as GBP , " +
                    "sum(case when fatura_birim = 'CHF' then fatura_tutari else 0 end) as CHF  " +
                    "from db_faturalar group by fatura_proje_no";

            myCommand = new MySqlCommand(komut, myConnection);
            da = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            da.Fill(dt);
            dg_maliyet.DataSource = dt;
            dg_maliyet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_maliyet.AutoSizeColumnsMode =
                       DataGridViewAutoSizeColumnsMode.Fill;
            myConnection.Close();
        }

        private void yeniGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktivite_giris ag = new aktivite_giris();
            ag.Show();        
        }

        private void yeniOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisemri_giris stf = new siparisemri_giris();
            stf.Show();         
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisemri_list stf_list = new siparisemri_list();
            stf_list.Show();
        }

        private void gELENFATURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fatura_giris ftrg = new fatura_giris();
            ftrg.Show();          
        }

        private void kESİLENFATURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kesilen_fatura kf = new kesilen_fatura();
            kf.Show();          
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            faturalar ftr = new faturalar();
            ftr.Show();
        }

        private void yeniProrjeGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proje_giris pyg = new proje_giris();
            pyg.Show();
           
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            proje_list pyl = new proje_list();
            pyl.Show();
        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkinda hk = new hakkinda();
            hk.Show();
          
        }

        private void dg_cokacil_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Aktivite_Düzenle ag = new Aktivite_Düzenle();
            ag.Show();
          

            fatura_id = Convert.ToInt32(dg_cokacil.Rows[e.RowIndex].Cells[0].Value.ToString());
            Aktivite_Düzenle f1 = (Aktivite_Düzenle)Application.OpenForms["Aktivite_Düzenle"];
            ComboBox no = (ComboBox)f1.Controls["cmb_prj_no"];
            ComboBox oncelik = (ComboBox)f1.Controls["cmb_oncelik"];
            ComboBox statu = (ComboBox)f1.Controls["cmb_statu"];
            RichTextBox acıklama = (RichTextBox)f1.Controls["rcb_acıklama"];
            ComboBox rapor = (ComboBox)f1.Controls["cmb_rapor_edilecek"];
            DateTimePicker olusturma = (DateTimePicker)f1.Controls["date_olusturma"];
            DateTimePicker bitis = (DateTimePicker)f1.Controls["date_bitis"];
            Label id = (Label)f1.Controls["lbl_id"];
            id.Text = dg_cokacil.Rows[e.RowIndex].Cells[0].Value.ToString();
            no.Text = dg_cokacil.Rows[e.RowIndex].Cells[1].Value.ToString();
            oncelik.Text = dg_cokacil.Rows[e.RowIndex].Cells[2].Value.ToString();
            statu.Text = dg_cokacil.Rows[e.RowIndex].Cells[3].Value.ToString();
            acıklama.Text = dg_cokacil.Rows[e.RowIndex].Cells[4].Value.ToString();
            rapor.Text = dg_cokacil.Rows[e.RowIndex].Cells[5].Value.ToString();
            olusturma.Text = dg_cokacil.Rows[e.RowIndex].Cells[6].Value.ToString();
            bitis.Text = dg_cokacil.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_diger_Click(object sender, EventArgs e)
        {
            diger_isler di = new diger_isler();
            di.Show();
        }

        private void btn_biten_Click(object sender, EventArgs e)
        {
            acil_normal_isler bi = new acil_normal_isler();
            bi.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            komut = "SELECT * FROM db_aktivite WHERE akt_oncelik='" + Convert.ToString("COK ACİL") + "' AND akt_statu='" + Convert.ToString("AKTİF") + "'";
            myCommand = new MySqlCommand(komut, myConnection);
            da = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            // myReader = myCommand.ExecuteReader();

            da.Fill(dt);

            dg_cokacil.DataSource = dt;

            dg_cokacil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_cokacil.AutoSizeColumnsMode =
                       DataGridViewAutoSizeColumnsMode.Fill;



            myConnection.Close();
            maliyet_hesapla();
        }

        private void cmb_proje_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (i = 0; i < toplam_fatura_G.Length; i++)
            {
                toplam_fatura_G[i] = 0;
                toplam_fatura_K[i] = 0;
            }
            ChartControl();
        }

        public void ChartControl()
        {
            i = 0;
            elemanSayisi = 0;
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
            myConnection.Open();
            komut = "SELECT * FROM db_faturalar WHERE fatura_proje_no='" + cmb_proje.Text + "' AND fatura_tipi='K'";
            da = new MySqlDataAdapter(komut, connection);

            //  myConnection = new MySqlConnection(connectionString);
            myCommand = new MySqlCommand(komut, myConnection);
            myReader = myCommand.ExecuteReader();
            // Always call Read before accessing data.
            while (myReader.Read())
            {           
                tarih_array_K[i] = Convert.ToDateTime(myReader.GetString(7));            
                fatura_tutar_K[i] = (float)Convert.ToDouble(myReader.GetString(12));
                i++;
                elemanSayisi++;
            }
            myReader.Close();

            i = 0;
            elemanSayisi = 0;

            komut = "SELECT * FROM db_faturalar WHERE fatura_proje_no='" + cmb_proje.Text + "' AND fatura_tipi='G'";
            da = new MySqlDataAdapter(komut, connection);

            //  myConnection = new MySqlConnection(connectionString);
            myCommand = new MySqlCommand(komut, myConnection);
            myReader = myCommand.ExecuteReader();
            // Always call Read before accessing data.
            while (myReader.Read())
            {
                tarih_array_G[i] = Convert.ToDateTime(myReader.GetString(7));
               // MessageBox.Show(Convert.ToString(tarih_array_G[i]));
                fatura_tutar_G[i] = (float)Convert.ToDouble(myReader.GetString(12));
               // MessageBox.Show(Convert.ToString(fatura_tutar_G[i]));
                i++;
                elemanSayisi++;
            }
            myReader.Close();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////   

            Int32 month;
            for (month = 0; month < tarih_array_G.Length; month++)
                if(Int32.Parse(tarih_array_G[month].ToString("yyyy"))==2017)
                    toplam_fatura_G[Int32.Parse(tarih_array_G[month].ToString("MM"))-1] += fatura_tutar_G[month];

            for (month = 0; month < tarih_array_K.Length; month++)
                if (Int32.Parse(tarih_array_G[month].ToString("yyyy")) == 2017)
                    toplam_fatura_K[Int32.Parse(tarih_array_K[month].ToString("MM")) - 1] += fatura_tutar_K[month];


            //Düzeltilecek
            for (month = 0; month < tarih_array_K.Length; month++)
                 sum_fatura[Int32.Parse(tarih_array_K[month].ToString("yyyy"))-2016, Int32.Parse(tarih_array_K[month].ToString("MM")) - 1] += fatura_tutar_K[month];
            //

            series.Points.Clear();
            seriesCopy.Points.Clear();
            for (i = 0; i < toplam_fatura_K.Length; i++)
            {
                seriesCopy.Points.AddXY(Convert.ToString(tarih_array_K[i]), Convert.ToDecimal(toplam_fatura_K[i]));
            }
          //  this.chart1.Series.Clear();
            for (i = 0; i < toplam_fatura_G.Length; i++)
            {
                series.Points.AddXY(Convert.ToString(tarih_array_G[i]), Convert.ToDecimal(toplam_fatura_G[i]));
            }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
            myConnection.Close();
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            clickPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                                         ChartElementType.PlottingArea);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.PlottingArea)
                {
                    var xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);

                    tooltip.Show("X=" + xVal + ", Y=" + yVal,
                                 this.chart1, e.Location.X, e.Location.Y - 15);
                }
            }
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickPosition.HasValue && e.Location != clickPosition)
            {
                tooltip.RemoveAll();
                clickPosition = null;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
