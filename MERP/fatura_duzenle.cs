using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml;
using System.Globalization;

namespace MERP
{
    public partial class fatura_duzenle : Form
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
        DataTable dt = new DataTable();
        DBConnect db;
        HelperFunctions hf;
        string fatura_euro;


        public fatura_duzenle()
        {
            InitializeComponent();
            hf = new HelperFunctions();
        }

        private void fatura_duzenle_Load(object sender, EventArgs e)
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

            //  myConnection = new MySqlConnection(connectionString);
            myCommand = new MySqlCommand(komut, myConnection);
            //   myConnection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            // Always call Read before accessing data.
            while (myReader.Read())
            {
                cmb_projeNo.Items.Add(myReader["proje_no"]);
            }
            myReader.Close();
        }

        private void btn_ftr_dzn_Click(object sender, EventArgs e)
        {
            if (txt_ftr_tutar.Text.Contains('.') & txt_ftr_tutar.Text.Contains(','))
            {
                DialogResult uyarı = new DialogResult();
                uyarı = MessageBox.Show("Aynı anda hem virgül hem nokta giremezsiniz!", "FATURA SİLME", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (uyarı == DialogResult.OK)
                {

                }
                else
                {

                }
            }
            else
            {
                txt_ftr_tutar.Text = hf.Comma2Dot(txt_ftr_tutar.Text);

                DateTime dt = Convert.ToDateTime(txt_ftr_tarih.Text);

                string dateToday = dt.ToString("d");
                DayOfWeek day = Convert.ToDateTime(txt_ftr_tarih.Text).DayOfWeek;
                string dayToday = day.ToString();

                if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday))
                {
                    MessageBox.Show("Lütfen hafta içi olacak bir tarih giriniz! ");
                }
                else
                {

                    fatura_euro = hf.EuroCalculation(txt_ftr_tarih.Text, txt_ftr_tutar.Text, cmb_birim.Text, fatura_euro);

                    db = new DBConnect();
                    db.UpdateFaturalar(Convert.ToInt32(lbl_id.Text), Convert.ToString(txt_fatura_no.Text), Convert.ToString(cmb_projeNo.Text), Convert.ToString(txt_firma.Text), Convert.ToInt32(txt_ftr_vade.Text), Convert.ToDateTime(date_alarm.Text), Convert.ToString(rcb_acıklama.Text), Convert.ToDateTime(txt_ftr_tarih.Text), ck_alarm.Checked, Convert.ToDecimal(txt_ftr_tutar.Text), Convert.ToString(cmb_birim.Text), Convert.ToInt32(txt_avans.Text), Convert.ToString(fatura_euro), Convert.ToString(lbl_tip.Text));
                    this.Close();


                }
            } 
        }
    }
}
