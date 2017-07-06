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
    public partial class siparisemri_duzenle : Form
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


        decimal siparis_euro;

        public siparisemri_duzenle()
        {
            InitializeComponent();
            hf = new HelperFunctions();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (txt_mlz_brmFiyat.Text.Contains('.') & txt_mlz_brmFiyat.Text.Contains(','))
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
                txt_mlz_brmFiyat.Text = hf.Comma2Dot(txt_mlz_brmFiyat.Text);

                DateTime dt = Convert.ToDateTime(date_teslim.Text);

                string dateToday = dt.ToString("d");
                DayOfWeek day = Convert.ToDateTime(date_teslim.Text).DayOfWeek;
             

                if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday))
                {
                    MessageBox.Show("Lütfen hafta içi olacak bir tarih giriniz! ");
                }
                else
                {
                    siparis_euro = Convert.ToDecimal(hf.EuroCalculation(date_teslim.Text, txt_mlz_brmFiyat.Text, cmb_paraBirimi.Text, Convert.ToString(siparis_euro)));

                    if(siparis_euro==Convert.ToDecimal(0000))
                    {
                        MessageBox.Show("Lütfen İnternete Bağlanınız");
                    }
                    else
                    {
                        db = new DBConnect();
                        db.UpdateSE(Convert.ToInt32(lbl_id.Text), Convert.ToString(cmb_prjno.Text), Convert.ToString(txt_siparisNo.Text), Convert.ToString(txt_tedarikci.Text), Convert.ToString(txt_talepKisi.Text), Convert.ToDateTime(date_teslim.Text), Convert.ToInt32(txt_vade.Text), Convert.ToDateTime(date_temin.Text), Convert.ToDecimal(txt_mlz_brmFiyat.Text), Convert.ToString(cmb_paraBirimi.Text), siparis_euro, Convert.ToString(rcb_aciklama.Text));
                        this.Close();
                    }
                }
            }
        }

        private void satinalma_duzenle_Load(object sender, EventArgs e)
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
                cmb_prjno.Items.Add(myReader["proje_no"]);
            }
            myReader.Close();
        }
    }
}
