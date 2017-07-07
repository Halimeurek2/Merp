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
    public partial class acil_normal_isler : Form
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
        public int akt_id;

        public acil_normal_isler()
        {
            InitializeComponent();
        }

        private void biten_isler_Load(object sender, EventArgs e)
        {
            server = "localhost";
            server = "localhost";
            server = "localhost";
            database = "uretimplanlama_2";
            uid = "root";
            password = "root";
            //string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            myConnection = new MySqlConnection(connectionString);
            myConnection.Open();

            komut = "SELECT * FROM db_aktivite WHERE akt_oncelik='" + Convert.ToString("ACİL") + "'";
            myCommand = new MySqlCommand(komut, myConnection);
            da = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            // myReader = myCommand.ExecuteReader();

            da.Fill(dt);

            dg_acil.DataSource = dt;

            dg_acil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_acil.AutoSizeColumnsMode =
                       DataGridViewAutoSizeColumnsMode.Fill;


            myConnection.Close();

            komut = "SELECT * FROM db_aktivite WHERE akt_oncelik='" + Convert.ToString("NORMAL") + "'";
            myCommand = new MySqlCommand(komut, myConnection);
            da = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            // myReader = myCommand.ExecuteReader();

            da.Fill(dt);

            dg_normal.DataSource = dt;

            dg_normal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_normal.AutoSizeColumnsMode =
                       DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {

        }

        private void dg_bitenisler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Aktivite_Düzenle ag = new Aktivite_Düzenle();
            ag.Show();

            akt_id = Convert.ToInt32(dg_acil.Rows[e.RowIndex].Cells[0].Value.ToString());
            Aktivite_Düzenle f1 = (Aktivite_Düzenle)Application.OpenForms["Aktivite_Düzenle"];
            ComboBox no = (ComboBox)f1.Controls["cmb_prj_no"];
            ComboBox oncelik = (ComboBox)f1.Controls["cmb_oncelik"];
            ComboBox statu = (ComboBox)f1.Controls["cmb_statu"];
            RichTextBox acıklama = (RichTextBox)f1.Controls["rcb_acıklama"];
            ComboBox rapor = (ComboBox)f1.Controls["cmb_rapor_edilecek"];
            DateTimePicker olusturma = (DateTimePicker)f1.Controls["date_olusturma"];
            DateTimePicker bitis = (DateTimePicker)f1.Controls["date_bitis"];
            Label id = (Label)f1.Controls["lbl_id"];
            id.Text = dg_acil.Rows[e.RowIndex].Cells[0].Value.ToString();
            no.Text = dg_acil.Rows[e.RowIndex].Cells[1].Value.ToString();
            oncelik.Text = dg_acil.Rows[e.RowIndex].Cells[2].Value.ToString();
            statu.Text = dg_acil.Rows[e.RowIndex].Cells[3].Value.ToString();
            acıklama.Text = dg_acil.Rows[e.RowIndex].Cells[4].Value.ToString();
            rapor.Text = dg_acil.Rows[e.RowIndex].Cells[5].Value.ToString();
            olusturma.Text = dg_acil.Rows[e.RowIndex].Cells[6].Value.ToString();
            bitis.Text = dg_acil.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow a in dg_acil.Rows)
            {
                if (a.Selected == true)
                {
                    DialogResult sil = new DialogResult();
                    sil = MessageBox.Show("Emin misiniz?", "FATURA SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (sil == DialogResult.Yes)
                    {
                        komut = "DELETE FROM db_aktivite WHERE akt_id='" + akt_id + "'";
                        myCommand = new MySqlCommand(komut, myConnection);
                        da = new MySqlDataAdapter(myCommand);
                        dt = new DataTable();
                        // myReader = myCommand.ExecuteReader();

                        da.Fill(dt);

                        dg_acil.DataSource = dt;

                        dg_acil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dg_acil.AutoSizeColumnsMode =
                                   DataGridViewAutoSizeColumnsMode.Fill;


                        komut = "SELECT * FROM db_aktivite WHERE akt_oncelik='" + Convert.ToString("ACİL") + "'";
                        myCommand = new MySqlCommand(komut, myConnection);
                        da = new MySqlDataAdapter(myCommand);
                        dt = new DataTable();
                        // myReader = myCommand.ExecuteReader();

                        da.Fill(dt);

                        dg_acil.DataSource = dt;

                        dg_acil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dg_acil.AutoSizeColumnsMode =
                                   DataGridViewAutoSizeColumnsMode.Fill;


                        myConnection.Close();
                    }
                }
            }
            foreach (DataGridViewRow n in dg_normal.Rows)
            {
                if (n.Selected == true)
                {
                    DialogResult sil = new DialogResult();
                    sil = MessageBox.Show("Emin misiniz?", "FATURA SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (sil == DialogResult.Yes)
                    {
                        komut = "DELETE FROM db_aktivite WHERE akt_id='" + akt_id + "'";
                        myCommand = new MySqlCommand(komut, myConnection);
                        da = new MySqlDataAdapter(myCommand);
                        dt = new DataTable();
                        // myReader = myCommand.ExecuteReader();

                        da.Fill(dt);

                        dg_normal.DataSource = dt;

                        dg_normal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dg_normal.AutoSizeColumnsMode =
                                   DataGridViewAutoSizeColumnsMode.Fill;


                        komut = "SELECT * FROM db_aktivite WHERE akt_oncelik='" + Convert.ToString("NORMAL") + "'";
                        myCommand = new MySqlCommand(komut, myConnection);
                        da = new MySqlDataAdapter(myCommand);
                        dt = new DataTable();
                        // myReader = myCommand.ExecuteReader();

                        da.Fill(dt);

                        dg_normal.DataSource = dt;

                        dg_normal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dg_normal.AutoSizeColumnsMode =
                                   DataGridViewAutoSizeColumnsMode.Fill;


                        myConnection.Close();
                    }
                }
            }
        }

        private void dg_normal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Aktivite_Düzenle ag = new Aktivite_Düzenle();
            ag.Show();

            akt_id = Convert.ToInt32(dg_normal.Rows[e.RowIndex].Cells[0].Value.ToString());
            Aktivite_Düzenle f1 = (Aktivite_Düzenle)Application.OpenForms["Aktivite_Düzenle"];
            ComboBox no = (ComboBox)f1.Controls["cmb_prj_no"];
            ComboBox oncelik = (ComboBox)f1.Controls["cmb_oncelik"];
            ComboBox statu = (ComboBox)f1.Controls["cmb_statu"];
            RichTextBox acıklama = (RichTextBox)f1.Controls["rcb_acıklama"];
            ComboBox rapor = (ComboBox)f1.Controls["cmb_rapor_edilecek"];
            DateTimePicker olusturma = (DateTimePicker)f1.Controls["date_olusturma"];
            DateTimePicker bitis = (DateTimePicker)f1.Controls["date_bitis"];
            Label id = (Label)f1.Controls["lbl_id"];
            id.Text = dg_normal.Rows[e.RowIndex].Cells[0].Value.ToString();
            no.Text = dg_normal.Rows[e.RowIndex].Cells[1].Value.ToString();
            oncelik.Text = dg_normal.Rows[e.RowIndex].Cells[2].Value.ToString();
            statu.Text = dg_normal.Rows[e.RowIndex].Cells[3].Value.ToString();
            acıklama.Text = dg_normal.Rows[e.RowIndex].Cells[4].Value.ToString();
            rapor.Text = dg_normal.Rows[e.RowIndex].Cells[5].Value.ToString();
            olusturma.Text = dg_normal.Rows[e.RowIndex].Cells[6].Value.ToString();
            bitis.Text = dg_normal.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
