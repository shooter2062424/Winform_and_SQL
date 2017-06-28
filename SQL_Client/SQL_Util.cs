using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace SQL_Client
{
    class SQL_Util
    {
        //data member
        public string IP { get; set;}
        public string userAccount { get; set; }
        public string userPwd { get; set; }
        public string database { get; set; }
        public string table { get; set; }

        private MySqlConnection conn;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;

        private bool connectionSuccess;

        //constructor
        public SQL_Util()
        {
            connectionSuccess = false;
            IP = string.Empty;
            userAccount = string.Empty;
            userPwd = string.Empty;
            database = string.Empty;
            table = string.Empty;
        }

        //data checking
        private bool hasEmptyValue()
        {
            if(IP == string.Empty)
            {
                return true;
            }

            if(userAccount == string.Empty)
            {
                return true;
            }

            if(userPwd == string.Empty)
            {
                return true;
            }

            if(database == string.Empty)
            {
                return true;
            }

            if(table == string.Empty)
            {
                return true;
            }

            return false;   
        }

        //SQL commands
        public bool OpenConnection()
        {
            if (hasEmptyValue() == false)
            {
                string connStr = "server=" + IP + ";uid=" + userAccount + ";pwd=" + userPwd + ";database=" + database;
                conn = new MySqlConnection(connStr);
                command = conn.CreateCommand();
                connectionSuccess = true;
            }
            return connectionSuccess;
        }

        public bool checkConnection()
        {
            return connectionSuccess;
        }

        public bool Insert()
        {
            return true;
        }

        public bool updateImg(Image img, int id)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            byte[] arr = ImageToBlob(img);
            cmd.CommandText = "update " + table + " set design_img=" + "@img" + " where id=" + id.ToString();
            cmd.Parameters.Add("@img", MySqlDbType.MediumBlob);
            cmd.Parameters["@img"].Value = arr;

            if(cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data replaced");
            }

            conn.Close();
            return true;
        }

        public SQL_Structure Read(int id)
        {
            SQL_Structure sql_struct = new SQL_Structure();
            conn.Open();
            /*
            if(conn.State != ConnectionState.Open)
            {
                conn.Close();
                return sql_struct;
            }
            */
            //add query
            command.CommandText = "select * from " + table + " where id = '" + id.ToString() + "'";
            adapter = new MySqlDataAdapter(command);
            DataTable t = new DataTable();
            adapter.Fill(t);
            //fill structure
            sql_struct.id = (int)t.Rows[0][0];
            sql_struct.modelID = t.Rows[0][1].ToString();
            sql_struct.gender = t.Rows[0][2].ToString();
            sql_struct.has_stone = (bool)t.Rows[0][3];
            sql_struct.is_ring = (bool)t.Rows[0][4];
            sql_struct.is_couple = (bool)t.Rows[0][5];
            sql_struct.is_pendant = (bool)t.Rows[0][6];
            sql_struct.is_wristband = (bool)t.Rows[0][7];
            sql_struct.is_bracelet = (bool)t.Rows[0][8];
            sql_struct.is_earring = (bool)t.Rows[0][9];
            sql_struct.is_necklace = (bool)t.Rows[0][10];
            sql_struct.is_other = (bool)t.Rows[0][11];
            if (t.Rows[0][12] != System.DBNull.Value) 
            {
                sql_struct.blobImg = (byte[])t.Rows[0][12];
            }
            //release memory use by adapter
            adapter.Dispose();
            conn.Close();
            return sql_struct;
        }



        //Image functions
        public Image LoadImage()
        {
            string path = getImageNameFromDialog();
            return ReadImage(path);
        }

        public Image ReadImage(string name)
        {
            return Image.FromFile(name);
        }

        public byte[] ImageToBlob(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }

        public Image BlobToImage(byte[] bArr)
        {
            MemoryStream ms = new MemoryStream(bArr);
            return Image.FromStream(ms);
        }

        //interaction functions
        public string getImageNameFromDialog()
        {
            string fileName = string.Empty;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "image files (*.bmp, *.jpg)|*.bmp;*.jpg;";
            DialogResult result = fileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                if (fileDialog.CheckFileExists == true)
                {
                    fileName = fileDialog.FileName;
                }
            }
            return fileName;
        }
    }

    class SQL_Structure
    {
        //data member
        public int id = 0;
        public string modelID;
        public string gender;
        public bool has_stone;
        public bool is_ring;
        public bool is_couple;
        public bool is_pendant;
        public bool is_wristband;
        public bool is_bracelet;
        public bool is_earring;
        public bool is_necklace;
        public bool is_other;
        public byte[] blobImg = null;
    }
}
