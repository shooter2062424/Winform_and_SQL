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
        private SQL_Util sql;


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

            //show account and password
            this.textBox1.Text = account;
            this.textBox2.Text = password;

            //initial sql
            sql = new SQL_Util();
            //sql.IP = "36.234.144.134";
            //sql.userAccount = "shooter";
            //sql.userPwd = "11111111";
            //sql.database = "sys";
            sql.IP = "127.0.0.1";
            sql.userAccount = "swallow";
            sql.userPwd = "collin24";
            sql.database = "testdatabase";
            sql.table = "main_table";
            sql.OpenConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GetNext_Click(object sender, EventArgs e)
        {
            if (sql.checkConnection())
            {
                if (this.id.Text != string.Empty)
                {
                    int val = Convert.ToInt32(this.id.Text);
                    SQL_Structure ss = sql.Read(val);
                    this.id.Text = ss.id.ToString();
                    this.modelID.Text = ss.modelID;
                    this.gender.Text = ss.gender;
                    this.hasImg.Text = ss.blobImg == null ? "None" : "Has";
                    setDataGrid(ss);
                    if (ss.blobImg != null)
                    {
                        setImgBox(sql.BlobToImage(ss.blobImg));
                    }
                    else
                    {
                        clearImgBox();
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to MYSQL server!");
            }
        }

        private void setDataGrid(SQL_Structure ss)
        {
            dataGrid.ColumnCount = 9;
            dataGrid.Columns[0].Name = "has stone";
            dataGrid.Columns[1].Name = "is ring";
            dataGrid.Columns[2].Name = "is couple";
            dataGrid.Columns[3].Name = "is pendant";
            dataGrid.Columns[4].Name = "is wristband";
            dataGrid.Columns[5].Name = "is bracelet";
            dataGrid.Columns[6].Name = "is earring";
            dataGrid.Columns[7].Name = "is necklace";
            dataGrid.Columns[8].Name = "is other";
            string[] row = new string[dataGrid.ColumnCount];
            row[0] = OorX(ss.has_stone);
            row[1] = OorX(ss.is_ring);
            row[2] = OorX(ss.is_couple);
            row[3] = OorX(ss.is_pendant);
            row[4] = OorX(ss.is_wristband);
            row[5] = OorX(ss.is_bracelet);
            row[6] = OorX(ss.is_earring);
            row[7] = OorX(ss.is_necklace);
            row[8] = OorX(ss.is_other);
            dataGrid.Rows.Clear();
            dataGrid.Rows.Add(row);
        }

        private string OorX(bool b)
        {
            Console.Write(b.ToString());
            return b ? "O" : "X";
        }

        private void LoadImg_Click(object sender, EventArgs e)
        {
            Image img = sql.LoadImage();
            imgBox.Image = img;
        }

        private void SendImg2Sql_Click(object sender, EventArgs e)
        {
            Image img = imgBox.Image;
            int val = Convert.ToInt32(this.id.Text);
            sql.updateImg(img, val);
        }

        private void setImgBox(Image img)
        {
            if(imgBox.Image != null)
            {
                //release memory usage
                imgBox.Image.Dispose();
            }
            imgBox.Image = img;
        }

        private void clearImgBox()
        {
            if (imgBox.Image != null)
            {
                //release memory usage
                imgBox.Image.Dispose();
                imgBox.Image = null;
            }
        }


        //old testing
        /*
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
        */
    }
}
