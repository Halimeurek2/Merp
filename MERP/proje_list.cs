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
    public partial class proje_list : Form
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

        string id;
        string proje_adi;
        string proje_no;
        string butce;
        string birim;
        string harcamalar;
        string harcama_birim;
        string musteri;
        string vade;
        string aciklama;
        DateTime baslangic;
        DateTime bitis;

        HelperFunctions hf;

        public string harcama_m_mlz;
        public string harcama_el_mlz;
        public string harcama_imalat;
        public string harcama_test;
        public string harcama_risk;
        public string odeme_avans;
        public string odeme_pdr;
        public string odeme_cdr;
        public string odeme_prototip;
        public string odeme_test;
        public string odeme_kabul;
        public string flag;

        public DateTime dtp_avans;
        public DateTime dtp_test;
        public DateTime dtp_kabul;
        public DateTime dtp_pdr;
        public DateTime dtp_cdr;
        public DateTime dtp_prototip;

        DataTable dt = new DataTable();

<<<<<<< HEAD

=======
>>>>>>> b478a4018d812fdc8a7c542575f82540f2c6843c
        public proje_list()
        {
            InitializeComponent();
            hf = new HelperFunctions();
        }

        private void proje_list_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "uretimplanlama_2";
            uid = "root";
            password = "root";
            //string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            myConnection = new MySqlConnection(connectionString);
            myConnection.Open();

            komut = "SELECT proje_no as ProjeNo," +
                    "proje_ismi as Projeİsmi," +
                    "proje_butce as Bütçe," +
                    "proje_birim as Birim," +
                    "proje_musteri as Müşteri," +
                    "proje_baslangic as Başlangıç," +
                    "proje_bitis as Bitiş," +
                    "proje_vade as Vade," +
                    "proje_aciklama as Açıklama," +
                    "harcama_toplam as Harcama," +
                    "harcama_toplam_birim as HarcamaBirim," +
                    "prj_tip as Tip FROM db_projeler";
            myCommand = new MySqlCommand(komut, myConnection);
            da = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            da.Fill(dt);
            dgw_prj_list.DataSource = dt;
            dgw_prj_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw_prj_list.AutoSizeColumnsMode =
                       DataGridViewAutoSizeColumnsMode.Fill;


            myConnection.Close();
        }

        private void btn_prj_sil_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Emin misiniz?", "FATURA SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (sil == DialogResult.Yes)
            {
                komut = "DELETE FROM db_projeler WHERE proje_id='" + id + "'";
                myCommand = new MySqlCommand(komut, myConnection);
                da = new MySqlDataAdapter(myCommand);
                dt = new DataTable();
                // myReader = myCommand.ExecuteReader();

                da.Fill(dt);

                dgw_prj_list.DataSource = dt;

                dgw_prj_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgw_prj_list.AutoSizeColumnsMode =
                           DataGridViewAutoSizeColumnsMode.Fill;


                komut = "SELECT proje_no,proje_ismi,proje_butce,proje_birim,proje_musteri,proje_baslangic,proje_bitis,proje_vade,proje_aciklama,harcama_toplam,harcama_toplam_birim,prj_tip FROM db_projeler";
                myCommand = new MySqlCommand(komut, myConnection);
                da = new MySqlDataAdapter(myCommand);
                dt = new DataTable();
                // myReader = myCommand.ExecuteReader();

                da.Fill(dt);

                dgw_prj_list.DataSource = dt;

                dgw_prj_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgw_prj_list.AutoSizeColumnsMode =
                           DataGridViewAutoSizeColumnsMode.Fill;

                myConnection.Close();
            }
            else
            {

            }
        }

        private void dgw_prj_list_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            proje_duzenle obj = new proje_duzenle();
            proje_no = dgw_prj_list.Rows[e.RowIndex].Cells[0].Value.ToString();
            proje_adi = dgw_prj_list.Rows[e.RowIndex].Cells[1].Value.ToString();
            butce = dgw_prj_list.Rows[e.RowIndex].Cells[2].Value.ToString();
            birim = dgw_prj_list.Rows[e.RowIndex].Cells[3].Value.ToString();
         
            musteri = dgw_prj_list.Rows[e.RowIndex].Cells[4].Value.ToString();
            baslangic = Convert.ToDateTime(dgw_prj_list.Rows[e.RowIndex].Cells[5].Value.ToString());
            bitis = Convert.ToDateTime(dgw_prj_list.Rows[e.RowIndex].Cells[6].Value.ToString());
            vade= dgw_prj_list.Rows[e.RowIndex].Cells[7].Value.ToString();
            aciklama = dgw_prj_list.Rows[e.RowIndex].Cells[8].Value.ToString();
            harcamalar = dgw_prj_list.Rows[e.RowIndex].Cells[9].Value.ToString();
            harcama_birim = dgw_prj_list.Rows[e.RowIndex].Cells[10].Value.ToString();
            flag= dgw_prj_list.Rows[e.RowIndex].Cells[11].Value.ToString();

            myConnection.Open();
            komut = "SELECT * FROM db_projeler WHERE proje_no='"+proje_no+"' AND proje_ismi='"+proje_adi+"'";
            da = new MySqlDataAdapter(komut, connection);

            //  myConnection = new MySqlConnection(connectionString);
            myCommand = new MySqlCommand(komut, myConnection);
            //   myConnection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            // Always call Read before accessing data.
            while (myReader.Read())
            {
                id = myReader.GetString(0);
                harcama_m_mlz = myReader.GetString(10);
                harcama_el_mlz = myReader.GetString(11);
                harcama_imalat = myReader.GetString(12);
                harcama_test = myReader.GetString(13);
                harcama_risk = myReader.GetString(14);
                odeme_avans = myReader.GetString(17);
                dtp_avans = Convert.ToDateTime(myReader.GetString(18));
                odeme_pdr = myReader.GetString(19);
                dtp_pdr = Convert.ToDateTime(myReader.GetString(20));
                odeme_cdr = myReader.GetString(21);
                dtp_cdr = Convert.ToDateTime(myReader.GetString(22));
                odeme_prototip = myReader.GetString(23);
                dtp_prototip = Convert.ToDateTime(myReader.GetString(24));
                odeme_test = myReader.GetString(25);
                dtp_test = Convert.ToDateTime(myReader.GetString(26));
                odeme_kabul = myReader.GetString(27);
                dtp_kabul = Convert.ToDateTime(myReader.GetString(28));
            }
            myReader.Close();

        }

        private void txt_prjNo_TextChanged(object sender, EventArgs e)
        {
            Refresh(1, txt_prjNo.Text);
        }

        private void txt_prjAdi_TextChanged(object sender, EventArgs e)
        {
            Refresh(2, txt_prjAdi.Text);
        }

        private void btn_prj_duzenle_Click(object sender, EventArgs e)
        {
            proje_duzenle obj = new proje_duzenle();
            obj.lbl_id.Text = id;
            obj.cmb_birim.Text = birim;
            obj.txt_butce.Text = butce;
            obj.txt_musteri.Text = musteri;
            obj.txt_proje_adi.Text = proje_adi;
            obj.txt_proje_no.Text = proje_no;
            obj.dtp_baslangıc.Value = baslangic;
            obj.dtp_bitis.Value = bitis;
            obj.txt_vade.Text = vade;
            obj.rcb_aciklama.Text = aciklama;
            obj.lbl_harcamalar.Text = harcamalar;
            obj.lbl_birim.Text = harcama_birim;
            if(flag=="S") { obj.ck_seri.Checked = true; }
            else { obj.ck_prj.Checked = true; }
            obj.Show();
          

            harcama_ongorusu ho = new harcama_ongorusu();
            ho.txt_m_mlz.Text = harcama_m_mlz;
            ho.txt_el_mlz.Text = harcama_el_mlz;
            ho.txt_imalat.Text = harcama_imalat;
            ho.txt_test.Text = harcama_test;
            ho.txt_risk.Text = harcama_risk;
            ho.txt_avans.Text = odeme_avans;
            ho.txt_pdr.Text = odeme_pdr;
            ho.txt_cdr.Text = odeme_cdr;
            ho.txt_prototip.Text = odeme_prototip;
            ho.txt_o_test.Text = odeme_test;
            ho.txt_kabul.Text = odeme_kabul;
            ho.dtp_avans.Value = dtp_avans;
            ho.dtp_pdr.Value = dtp_pdr;
            ho.dtp_cdr.Value = dtp_cdr;
            ho.dtp_prototip.Value = dtp_prototip;
            ho.dtp_test.Value = dtp_test;
            ho.dtp_kabul.Value = dtp_kabul;

            ho.Show();
        

        }
        public void Refresh(int i,string name)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgw_prj_list.DataSource;
            bs.Filter = dgw_prj_list.Columns[i].HeaderText.ToString() + " LIKE '%" + name + "%'";
            dgw_prj_list.DataSource = bs;

            dgw_prj_list.Refresh();
        }
    }
}
