﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERP
{
    public partial class GenelRapor : Form
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

        int state = 0;
        Boolean processDone = false;

        public GenelRapor()
        {
            InitializeComponent();
        }

        private void GenelRapor_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "uretimplanlama_2";
            uid = "root";
            password = "root";
            //string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            myConnection = new MySqlConnection(connectionString);
            myConnection.Open();

            komut = "SELECT fatura_firma,fatura_euro from db_faturalar where fatura_tipi='G' group by fatura_firma order by fatura_euro DESC";
            da = new MySqlDataAdapter(komut, connection);
            myCommand = new MySqlCommand(komut, myConnection);
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (processDone == false)
                {
                    switch (state)
                    {
                        case 0:
                            {
                                lbl_firma4.Text = Convert.ToString(myReader.GetString(0));
                                state = 1;
                                break;
                            }
                        case 1:
                            {
                                lbl_firma5.Text = Convert.ToString(myReader.GetString(0));
                                state = 2;
                                break;
                            }
                        case 2:
                            {
                                lbl_firma6.Text = Convert.ToString(myReader.GetString(0));
                                state = 0;
                                processDone = true;
                                break;
                            }
                    }
                }
            }
            myReader.Close();
            processDone = false;

            komut = "SELECT tedarikci,siparis_euro from db_siparis_emri group by tedarikci order by siparis_euro DESC";
            da = new MySqlDataAdapter(komut, connection);
            myCommand = new MySqlCommand(komut, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (processDone == false)
                {
                    switch (state)
                    {
                        case 0:
                            {
                                lbl_firma1.Text = Convert.ToString(myReader.GetString(0));
                                state = 1;
                                break;
                            }
                        case 1:
                            {
                                lbl_firma2.Text = Convert.ToString(myReader.GetString(0));
                                state = 2;
                                break;
                            }
                        case 2:
                            {
                                lbl_firma3.Text = Convert.ToString(myReader.GetString(0));
                                state = 0;
                                processDone = true;
                                break;
                            }
                    }
                }
            }
        }
    }
}
