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

namespace SQL_Client
{
    public partial class Form2 : Form
    {
        //data member
        private string account;
        private string password;


        //constructor
        public Form2()
        {
            //init variables
            account = string.Empty;
            password = string.Empty;

            //ask user to login
            Form1 loginForm = new Form1();
            if (loginForm.ShowDialog() != DialogResult.OK) 
            {
                Environment.Exit(Environment.ExitCode); 
                return;
            }
            else
            {
                account = loginForm.accountStr();
                password = loginForm.passwordStr();
                loginForm.Close();
            }


            InitializeComponent();

            this.textBox1.Text = account;
            this.textBox2.Text = password;
        }

        private void FetchData_Click(object sender, EventArgs e)
        {
            //get data from sql database(db)
            string dbIP = "127.0.0.1";
            string dbUser = "swallow";
            string dbPass = "collin24";
            string dbName = "testdatabase";
            string dbTable = "jewelry";
            string connStr = "server=" + dbIP + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Fetch all data!");
                command.CommandText = "select * from " + dbTable + ";";
                MySqlDataReader reader = command.ExecuteReader();
                                  
                string data = string.Empty;
                while (reader.Read())
                {
                    for (int col = 0; col < 3; col++)
                    {
                        data += (reader.GetString(col) + "  ");
                    }
                    data += System.Environment.NewLine;
                }

                this.ShowBox.Text = data;
                reader.Close();
                conn.Close();
            }
            else  //failed to open
            {
                MessageBox.Show("failed to reach sql server!");
                conn.Close();
            }


        }

        private void Add10Data_Click(object sender, EventArgs e)
        {
            //get data from sql database(db)
            string dbIP = "127.0.0.1";
            string dbUser = "swallow";
            string dbPass = "collin24";
            string dbName = "testdatabase";
            string dbTable = "jewelry";
            string connStr = "server=" + dbIP + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Add 10 data into data base");
                for(int i=0; i<10; i++)
                {
                    int id = i + 3;
                    string jewel_Name = "jewel_" + i.ToString();
                    float price = i * 10000;
                    command.CommandText = "insert into " + dbTable + "(id, jewel_name, price) " + "value(" + id.ToString() + ", '" + jewel_Name.ToString() + "', " + price.ToString() + ");";
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
            else  //failed to open
            {
                MessageBox.Show("failed to reach sql server!");
                conn.Close();
            }
        }
    }
}
