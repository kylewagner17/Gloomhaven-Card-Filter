using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHCardsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Connection button handler
        private void button1_Click(object sender, EventArgs e)
        {
            //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
            //Creating string containing information for connecting to sql server
            string connectionString;
            connectionString = @"Data Source=DESKTOP-QN510QT\SQLEXPRESS;Initial Catalog=""Gloomhaven Cards"";Integrated Security=True;Encrypt=False;Trusted_Connection=True;";
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = "Select CardPicture from Gloomhaven_Cards";
            cnn.Open();
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0);
            }

            MessageBox.Show(Output);

            //Possibly use sqlCredential for security relating to database








            //Opens sql connection using property settings of SqlConnection

            MessageBox.Show("Connection Open!");

            //Closes sql connection
            cnn.Close();
        }

        private static byte[] HexString2Bytes(string hexString)
        {
            int bytesCount = (hexString.Length) / 2;
            byte[] bytes = new byte[bytesCount];
            for (int x = 0; x < bytesCount; ++x)
            {
                bytes[x] = Convert.ToByte(hexString.Substring(x * 2, 2), 16);
            }

            return bytes;
        }

    }
}