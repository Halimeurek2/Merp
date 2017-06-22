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

namespace MERP
{
    public partial class aktivite_giris : Form
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

        public aktivite_giris()
        {
            InitializeComponent();
        }

        private void aktivite_giris_Load(object sender, EventArgs e)
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
                cmb_prj_no.Items.Add(myReader["proje_no"]);
            }
            myReader.Close();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            db = new DBConnect();
            db.InsertAktiviteGiris(Convert.ToString(cmb_prj_no.Text), Convert.ToString(cmb_oncelik.Text), Convert.ToString(cmb_statu.Text), Convert.ToString(rcb_acıklama.Text), Convert.ToString(cmb_rapor_edilecek.Text), Convert.ToDateTime(date_olusturma.Text), Convert.ToDateTime(date_bitis.Text));
            this.Close();
        }
    }
}
