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
using System.Windows.Forms.DataVisualization.Charting;

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


            komut = "select sum(fatura_euro) as EURO from db_faturalar where fatura_cinsi='elektrik'";
            da = new MySqlDataAdapter(komut, connection);

            myCommand = new MySqlCommand(komut, myConnection);
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                el_mal = Convert.ToString(myReader.GetString(0));
            }
            myReader.Close();
            komut = "select sum(fatura_euro) as EURO from db_faturalar where fatura_cinsi='mekanik'";
            da = new MySqlDataAdapter(komut, connection);

            myCommand = new MySqlCommand(komut, myConnection);
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                mek_mal = Convert.ToString(myReader.GetString(0));
            }
            myReader.Close();
            komut = "select sum(fatura_euro) as EURO from db_faturalar";
            da = new MySqlDataAdapter(komut, connection);

            myCommand = new MySqlCommand(komut, myConnection);
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                genel_mal = Convert.ToString(myReader.GetString(0));
            }
            myReader.Close();
            myConnection.Close();

            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Maliyet");

            elektrikMaliyet = this.chart1.Series.Add("Elektrik");
            elektrikMaliyet.ChartType = SeriesChartType.Pie;
            elektrikMaliyet.Color = Color.Red;
            elektrikMaliyet.MarkerStyle = MarkerStyle.Circle;
            elektrikMaliyet.MarkerColor = Color.Red;
            elektrikMaliyet.IsValueShownAsLabel = true;
            elektrikMaliyet.LabelAngle = 30;


            mekanikMaliyet = chart1.Series.Add("Mekanik");
            mekanikMaliyet.ChartType = elektrikMaliyet.ChartType;
            mekanikMaliyet.Color = Color.Blue;
            mekanikMaliyet.MarkerColor = elektrikMaliyet.MarkerColor;
            mekanikMaliyet.MarkerStyle = elektrikMaliyet.MarkerStyle;
            mekanikMaliyet.IsValueShownAsLabel = true;
            mekanikMaliyet.LabelAngle = 30;


            genelMaliyet = chart1.Series.Add("Genel");
            genelMaliyet.ChartType = elektrikMaliyet.ChartType;
            genelMaliyet.Color = Color.Orange;
            genelMaliyet.MarkerColor = Color.Blue;
            genelMaliyet.MarkerStyle = MarkerStyle.Square;
            genelMaliyet.IsValueShownAsLabel = true;
            genelMaliyet.LabelAngle = 30;

            DrawChart();
        }
        public void DrawChart()
        {
            //elektrikMaliyet.Points.Add(Convert.ToDouble(el_mal));
            mekanikMaliyet.Points.Add(Convert.ToDouble(mek_mal));
            //genelMaliyet.Points.Add(Convert.ToDouble(genel_mal));
        }
    }
}
